using System.Linq.Expressions;
using System.Text.Json;
using Guna.UI2.WinForms;

namespace CleanArchitectureHelper;

public partial class Form1 : Form
{
    public Form1()
    {

        if (File.Exists("last"))
        {
            var json = File.ReadAllText(File.ReadAllText("last"));
            Globals.ProjectModel = JsonSerializer.Deserialize<ProjectModel>(json);
        }

        InitializeComponent();

        label1.Text = Globals.ProjectModel == null ? "NO PROJECT" : Globals.ProjectModel.Prefix;
    }

    private void AddCommandButton_Click(object sender, EventArgs e)
        => CheckProjectLoaded(new AddCommandForm());

    private void AddQueryButton_Click(object sender, EventArgs e)
        => CheckProjectLoaded(new ProjectSettingsForm());
    
    private void LoadProjectButton_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog()
        {
            Filter = @"Solution file (*.sln)|*.sln|All files (*.*)|*.*",
        };

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        
        var path = openFileDialog.FileName;
        var name = path.Split("\\")[^1][..^4];

        var settingsPath = name + ".json";
        if (File.Exists(settingsPath))
        {
            var dialog = new Guna2MessageDialog()
            {
                Buttons = MessageDialogButtons.OKCancel,
                Caption = "Settings already exists",
                Icon = MessageDialogIcon.Warning,
                Parent = this,
                Style = MessageDialogStyle.Light,
                //                                          \/ WTF
                Text = "Do you want to load these settings? END"
            }.Show();

            if (dialog == DialogResult.OK)
            {   
                Globals.ProjectModel = JsonSerializer.Deserialize<ProjectModel>(File.ReadAllText(settingsPath));
                return;
            }
        }
        
        Globals.ProjectModel = new ProjectModel()
        {
            Path = path,
            Prefix = name,
            Name = name
        };

        new ProjectSettingsForm().Show();
    }

    private void ProjectSettingsButton_Click(object sender, EventArgs e) 
        => CheckProjectLoaded(new ProjectSettingsForm());

    private void ProjectSettingsButton_MouseEnter(object sender, EventArgs e) 
        => (sender as Control)!.Cursor = Globals.ProjectModel == null ? Cursors.No : Cursors.Hand;

    private void CheckProjectLoaded(Form form)
    {
        if (Globals.ProjectModel == null)
            new Guna2MessageDialog()
            {
                Buttons = MessageDialogButtons.OK,
                Caption = "Error",
                Icon = MessageDialogIcon.Error,
                Parent = this,
                Style = MessageDialogStyle.Light,
                Text = "No project loaded!"
            }.Show();

        else
            form.ShowDialog();
    }
}