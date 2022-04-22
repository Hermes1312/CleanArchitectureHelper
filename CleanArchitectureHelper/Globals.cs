namespace CleanArchitectureHelper;

public static class Globals
{
    public static ProjectModel? ProjectModel { get; set; }
    public static Form1? MainForm { get; set; }
    
    public static string? FirstCharToLowerCase(this string? str)
    {
        if ( !string.IsNullOrEmpty(str) && char.IsUpper(str[0]))
            return str.Length == 1 ? char.ToLower(str[0]).ToString() : char.ToLower(str[0]) + str[1..];

        return str;
    }
    
    public static string CommandPatternCtorMembers { get; } = "public record [[NAME]]Command([[MEMBERS]]) : IRequest[[RETURN]];";
    public static string CommandPatternMembers { get; } = @"public record [[NAME]]Command : IRequest[[RETURN]]
{
[[MEMBERS]]
}";
    public static string CommandBodyPatternCtorMembers { get; } = @$"using MediatR;
[[USINGS]]

namespace [[PREFIX]].Application.[[AREA]].[[FOLDER_NAME]].Commands;

[[COMMAND]]

public class [[NAME]]CommandHandler : IRequestHandler<[[NAME]]Command>
{{
[[DI_PROPS]]

    public [[NAME]]CommandHandler([[DI_CTOR]])
    {{
[[DI_ASSIGN]]
    }}

    public Task<[[RETURN]]> Handle([[NAME]]Command request, CancellationToken cancellationToken)
    {{
        throw new NotImplementedException();
    }}
}}";
    

}