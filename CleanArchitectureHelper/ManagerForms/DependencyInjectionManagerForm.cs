using System.Reflection;
using FastColoredTextBoxNS;
using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class DependencyInjectionManagerForm : Form
{
    private List<string> _plainInterfaces;
    private AutocompleteMenu _autocompleteMenu;

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

    private void DependencyInjectionManagerForm_Load(object sender, EventArgs e)
    {
        Focus();

        var files = Directory.GetFiles(@"E:\Projekty\WinePassionWebApp\WinePassion.API\bin\Debug\net6.0\", "WinePassion*.dll");
        var interfaces = new List<string>();

        foreach (var file in files)
        {
            var assembly = Assembly.LoadFrom(file);
            var types = assembly.GetLoadableTypes().ToList();
            interfaces.AddRange(types.Where(t => t.IsInterface).Select(t => t.Name));
        }

        _autocompleteMenu = Globals.CreateAutocompleteMenu(InterfacesTextBox, interfaces);
    }

    private void DependencyInjectionManagerForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _autocompleteMenu.Dispose();
    }
}