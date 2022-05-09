namespace CleanArchitectureHelper;

public class ProjectModel
{
    public string Prefix { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Path { get; set; } = null!;
    public string DirectoryPath
    {
        get
        {
            var split = Path.Split("\\")[..^1];
            return string.Join("\\", split);
        }
    }
    public string AssembliesPath { get; set; } = null!;
    public List<string>? Areas { get; set; } = new();
}