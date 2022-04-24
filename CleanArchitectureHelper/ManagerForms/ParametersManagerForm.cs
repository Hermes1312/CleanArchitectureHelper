using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class ParametersManagerForm : Form
{
    private List<string> _plainMembers;

    public ParametersManagerForm(List<string> plainMembers)
    {
        _plainMembers = plainMembers;
        InitializeComponent();

        membersTextBox.Text = string.Join(Environment.NewLine, _plainMembers);
    }

    private void guna2ControlBox1_Click(object sender, EventArgs e)
    {

    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        _plainMembers.Clear();
        _plainMembers.AddRange(membersTextBox.Text.Split(Environment.NewLine));
        
        new Guna2MessageDialog()
        {
            Buttons = MessageDialogButtons.OK,
            Caption = "Succeed",
            Icon = MessageDialogIcon.Information,
            Parent = this,
            Style = MessageDialogStyle.Light,
            //                                  \/ WTF
            Text = "Successfully saved members END"
        }.Show();
        
        Close();
    }
}