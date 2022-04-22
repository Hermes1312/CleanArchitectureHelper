using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Timer = System.Windows.Forms.Timer;

namespace CleanArchitectureHelper;

public partial class ProjectSettingsForm : Form
{
    private readonly ProjectModel? _projectModel;
    private readonly Timer? _timer;
    private const short Timeout = 4;
    private short _tickCounter = 0;

    public ProjectSettingsForm(bool firstTime=false)
    {
        InitializeComponent();
        label.Text = Globals.ProjectModel?.Prefix + " settings";

        if (firstTime)
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += TimerOnTick;
            _timer.Start();

            SaveSettingsButton.Text = (Timeout + 1).ToString();
        }

        _projectModel = Globals.ProjectModel;
        if (_projectModel == null) return;
        
        mainPathTextBox.Text = _projectModel.Path;
        nameTextBox.Text = _projectModel.Prefix;
    }

    private void TimerOnTick(object? sender, EventArgs e)
    {
        SaveSettingsButton.Text = (Timeout - _tickCounter).ToString();
        
        if (_tickCounter > Timeout)
        {
            SaveSettingsButton.Text = "SAVE SETTINGS";
            _timer.Stop();
        }

        _tickCounter++;
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

    private void SaveSettingsButton_MouseEnter(object sender, EventArgs e) 
        => SaveSettingsButton.Cursor = _tickCounter >= Timeout ? Cursors.Hand : Cursors.No;

    private void SaveSettingsButton_Click(object sender, EventArgs e)
    {
        if(_timer != null && _tickCounter <= Timeout) return;
        
        _projectModel.Path = mainPathTextBox.Text;
        _projectModel.Prefix = nameTextBox.Text;

        var fileNameLength = _projectModel.Path.Split("\\")[^1].Length;
        var path = _projectModel.Path[..^fileNameLength];
        _projectModel.Areas = Directory.GetDirectories(path, $"{_projectModel.Prefix}.Infrastructure.*").Select(d => d.Split("\\")[^1].Split(".")[^1]).ToList();
        
        var json = JsonSerializer.Serialize(_projectModel);
        var settingsPath = _projectModel.Name + ".json";
        
        
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
}