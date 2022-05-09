using FastColoredTextBoxNS;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHelper;

public static class Globals
{
    public static ProjectModel? ProjectModel { get; set; }
    public static Form1? MainForm { get; set; }

    public static string? GetLowestBaseType(this Type type)
    {
        if (type.BaseType == null) return null;
        
        var baseType = type.BaseType;

        while (baseType!.BaseType != null)
        {
            if(baseType.BaseType.BaseType == null) break;
            baseType = baseType.BaseType;
        }

        return baseType.Name;
    }
    
    public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
    {
        // TODO: Argument validation
        try
        {
            return assembly.GetTypes();
        }
        catch (ReflectionTypeLoadException e)
        {
            return e.Types.Where(t => t != null);
        }
    }

    public static AutocompleteMenu CreateAutocompleteMenu(FastColoredTextBox target, ICollection<string> autoCompleteList)
    {
        var menu = new AutocompleteMenu(target)
        {
            Enabled = true,
            SelectedColor = Color.FromArgb(154, 164, 183),
            BackColor = Color.FromName("ControlLightLight"),
            Font = new Font("Segoe UI Semibold", 9),
            MinimumSize = new Size(225, 50),
            AppearInterval = 1
        };

        menu.Items.SetAutocompleteItems(autoCompleteList);

        return menu;
    }

    private static IEnumerable<string> GetAllFiles() 
        => Directory.GetFiles(ProjectModel!.AssembliesPath, $"{ProjectModel!.Prefix}*.dll");
    private static IEnumerable<string> GetAllDllFiles() 
        => Directory.GetFiles(ProjectModel!.AssembliesPath, $"*.dll");

    public static IEnumerable<Type> GetAllTypes()
    {
        var types = new List<Type>();

        foreach (var file in GetAllFiles())
        {
            var assembly = Assembly.LoadFrom(file);
            types.AddRange(assembly.GetLoadableTypes().ToList());
        }

        return types;
    }    
    
    
    public static IEnumerable<string> GetInterfaces() 
        => GetAllTypes().Where(t => t.IsInterface).Select(t => t.Name);

    public static IEnumerable<string> GetEntitiesNames()
        => GetAllTypes().Where(t => t.GetLowestBaseType() == "StandardEntity").Select(t => t.Name);  
    
    public static IEnumerable<Type> GetEntities()
        => GetAllTypes().Where(t => t.GetLowestBaseType() == "StandardEntity");

    public static Type GetEntityByName(string name) => GetAllTypes().FirstOrDefault(t => t.GetLowestBaseType() == "StandardEntity" && t.Name == name)!;

    public static IEnumerable<string> GetEntityIncludableProperties(string entityName)
    {
        var result = new List<string>();
        var entityProperties = GetEntityByName(entityName).GetProperties();
        
        result.AddRange(entityProperties.Where(t => t.PropertyType.GetLowestBaseType() == "StandardEntity").Select(t => t.Name));
        result.AddRange(entityProperties.Where(t => t.PropertyType.IsGenericType && t.PropertyType.GetGenericArguments()[0].GetLowestBaseType() == "StandardEntity").Select(t => t.Name));

        return result;
    }
    

    public static IEnumerable<string> GetEntityProperties(string entityName)
    {
        var entity = GetEntityByName(entityName);
        return entity.GetProperties().Select(e => e.PropertyType.AliasOrName() + " " + e.Name);
    }


    public static string? FirstCharToLowerCase(this string? str)
    {
        if ( !string.IsNullOrEmpty(str) && char.IsUpper(str[0]))
            return str.Length == 1 ? char.ToLower(str[0]).ToString() : char.ToLower(str[0]) + str[1..];

        return str;
    }

    public static string RecordPattern { get; } = @"public record [[NAME]]
{
[[MEMBERS]]
};";
    public static string CQRecordCtorPattern { get; } = "public record [[NAME]][[QC]]([[MEMBERS]]) : [[PAGINATION]]IRequest[[RETURN]];";
    public static string CQRecordPattern { get; } = @"public record [[NAME]][[QC]] : [[PAGINATION]]IRequest[[RETURN]]
{
[[MEMBERS]]
}";
    public static string CQHandlerPattern { get; } = @$"using MediatR;
[[USINGS]]

namespace [[PREFIX]].[[LAYER]].[[AREA]].[[FOLDER_NAME]].[[QC2]];

[[COMMAND]]

public class [[NAME]][[QC]]Handler : IRequestHandler<[[NAME]][[QC]][[RETURN2]]>
{{
[[DI_PROPS]]

    public [[NAME]][[QC]]Handler([[DI_CTOR]])
    {{
[[DI_ASSIGN]]
    }}

    public async Task<[[RETURN]]> Handle([[NAME]][[QC]] request, CancellationToken cancellationToken)
    {{
[[BODY]]
    }}
}}";

    public static string QHandlerBodyPatter = @"";

}