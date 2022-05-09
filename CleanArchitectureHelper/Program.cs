using System.Linq.Expressions;
using System.Reflection;
using TheArtOfDevHtmlRenderer.Core;

namespace CleanArchitectureHelper;

static class Program
{
    [STAThread]
    static void Main()
    {
         // var files = Directory.GetFiles(@"E:\Projekty\WinePassionWebApp\WinePassion.API\bin\Debug\net6.0\", "WinePassion*.dll");
         // var interfaces = new List<string>();
         // var allTypes = new List<Type>();
         //
         // foreach (var file in files) 
         // {
         //     var assembly = Assembly.LoadFrom(file);
         //     var types = assembly.GetLoadableTypes().ToList();
         //     allTypes.AddRange(types);
         //     interfaces.AddRange(types.Where(t => t.IsInterface).Select(t => t.Name));
         // }
         //
         // var entities = allTypes.Where(t => t.GetLowestBaseType() == "StandardEntity").ToList();
         // var test = entities[0].GetProperties().Select(p => p.PropertyType.AliasOrName());
         //var test = entities[0].GetProperties()[10].PropertyType.AliasOrName();
         
         ApplicationConfiguration.Initialize();
         Globals.MainForm = new Form1();
         Application.Run(Globals.MainForm);
    }
    public static object GetPropValue(object src, string propName)
    {
        return src.GetType().GetProperty(propName).GetValue(src, null);
    }

}