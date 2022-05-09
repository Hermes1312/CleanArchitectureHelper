using System.Reflection;
using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class IncludesManagerForm : Form
{
    private string _entityName;

    public IncludesManagerForm(string entityName)
    {
        _entityName = entityName;
      
        InitializeComponent();
    }

    private void guna2ControlBox1_Click(object sender, EventArgs e)
    {

    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        new Guna2MessageDialog()
        {
            Buttons = MessageDialogButtons.OK,
            Caption = "Succeed",
            Icon = MessageDialogIcon.Information,
            Parent = this,
            Style = MessageDialogStyle.Light,
            //                                  \/ WTF
            Text = "Successfully saved properties END"
        }.Show();
        
        Close();
    }

    private void IncludesManagerForm_Load(object sender, EventArgs e)
    {
        var includables = Globals.GetEntityIncludableProperties(_entityName);
        foreach (var includable in includables) IncludablesListBox.Items.Add(includable, CheckState.Checked);
    }
}