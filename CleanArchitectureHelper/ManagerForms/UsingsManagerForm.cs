using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class UsingsManagerForm : Form
{
    private List<string> _plainUsings;

    public UsingsManagerForm(List<string> plainUsings)
    {
        _plainUsings = plainUsings;
        InitializeComponent();

        UsingsTextBox.Text = string.Join(Environment.NewLine, _plainUsings);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        _plainUsings.Clear();
        _plainUsings.AddRange(UsingsTextBox.Text.Split(Environment.NewLine));
        
        new Guna2MessageDialog()
        {
            Buttons = MessageDialogButtons.OK,
            Caption = "Succeed",
            Icon = MessageDialogIcon.Information,
            Parent = this,
            Style = MessageDialogStyle.Light,
            //                                  \/ WTF
            Text = "Successfully saved usings END"
        }.Show();
        
        Close();
    }
}