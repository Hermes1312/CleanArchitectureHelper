using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class VmPropsManagerForm : Form
{
    private List<string> _plainProps;

    public VmPropsManagerForm(List<string> plainProps)
    {
        _plainProps = plainProps;
        InitializeComponent();

        propsTextBox.Text = string.Join(Environment.NewLine, _plainProps);
    }

    private void guna2ControlBox1_Click(object sender, EventArgs e)
    {

    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        _plainProps.Clear();
        _plainProps.AddRange(propsTextBox.Text.Split(Environment.NewLine));
        
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
}