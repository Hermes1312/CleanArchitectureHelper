using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class DependencyInjectionManagerForm : Form
{
    private List<string> _plainInterfaces;

    public DependencyInjectionManagerForm(List<string> plainInterfaces)
    {
        _plainInterfaces = plainInterfaces;
        InitializeComponent();

        InterfacesTextBox.Text = string.Join(Environment.NewLine, _plainInterfaces);
    }
    
    private void SaveButton_Click(object sender, EventArgs e)
    {
        _plainInterfaces.Clear();
        _plainInterfaces.AddRange(InterfacesTextBox.Text.Split(Environment.NewLine));
        
        new Guna2MessageDialog()
        {
            Buttons = MessageDialogButtons.OK,
            Caption = "Succeed",
            Icon = MessageDialogIcon.Information,
            Parent = this,
            Style = MessageDialogStyle.Light,
            //                                  \/ WTF
            Text = "Successfully saved interfaces END"
        }.Show();
        
        Close();
    }
}