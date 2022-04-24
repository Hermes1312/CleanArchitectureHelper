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
        throw new NotImplementedException();
    }}
}}";
    

}