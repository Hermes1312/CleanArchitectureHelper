using System.Text.Json;
using Guna.UI2.WinForms;

namespace CleanArchitectureHelper;

public partial class ProjectSettingsForm : Form
{
    public ProjectSettingsForm(bool firstTime = false) 
        => InitializeComponent();

    private void ProjectSettingsForm_Load(object sender, EventArgs e)
    {
        label.Text = Globals.ProjectModel?.Prefix + " settings";

        if (Globals.ProjectModel == null) return;

        mainPathTextBox.Text = Globals.ProjectModel.Path;
        nameTextBox.Text = Globals.ProjectModel.Prefix;
        BinPathTextBox.Text = Globals.ProjectModel.AssembliesPath;
    }

    private void MainPathButton_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog()
        {
            Filter = @"Solution file (*.sln)|*.sln|All files (*.*)|*.*",
        };

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        
        mainPathTextBox.Text = openFileDialog.FileName;
        
        var split = openFileDialog.FileName.Split("\\");
        nameTextBox.Text = split[^1][..^4];
    }

    private void SaveSettingsButton_Click(object sender, EventArgs e)
    {
        Globals.ProjectModel!.Path = mainPathTextBox.Text;
        Globals.ProjectModel.Prefix = nameTextBox.Text;
        Globals.ProjectModel.AssembliesPath = BinPathTextBox.Text;

        var fileNameLength = Globals.ProjectModel.Path.Split("\\")[^1].Length;
        var path = Globals.ProjectModel.Path[..^fileNameLength];
        Globals.ProjectModel.Areas = Directory.GetDirectories(path, $"{Globals.ProjectModel.Prefix}.Infrastructure.*").Select(d => d.Split("\\")[^1].Split(".")[^1]).ToList();
        
        var json = JsonSerializer.Serialize(Globals.ProjectModel);
        var settingsPath = Globals.ProjectModel.Name + ".json";
        
        
        File.WriteAllText(settingsPath, json);
        File.WriteAllText("last", settingsPath);
        
        new Guna2MessageDialog()
        {
            Buttons = MessageDialogButtons.OK,
            Caption = "Succeed",
            Icon = MessageDialogIcon.Information,
            Parent = this,
            Style = MessageDialogStyle.Light,
            Text = $"Saved to "+settingsPath
        }.Show();

        Close();
    }

    private void BinPathButton_Click(object sender, EventArgs e)
    {
        var folderBrowserDialog = new FolderBrowserDialog();

        if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

        BinPathTextBox.Text = folderBrowserDialog.SelectedPath;
    }


}