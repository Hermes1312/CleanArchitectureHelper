using Guna.UI2.WinForms;

namespace CleanArchitectureHelper.ManagerForms;

public partial class VmPropsManagerForm : Form
{
    private List<string> _plainProps;
    private string _entityName;

    public VmPropsManagerForm(List<string> plainProps, string entityName)
    {
        _plainProps = plainProps;
        _entityName = entityName;
        InitializeComponent();
    }

    private void guna2ControlBox1_Click(object sender, EventArgs e)
    {

    }

    private void VmPropsManagerForm_Load(object sender, EventArgs e)
    {
        if(_entityName == "-")
            propsTextBox.Text = string.Join(Environment.NewLine, _plainProps);
        else
        {
            var includables = Globals.GetEntityIncludableProperties(_entityName).ToList();
            includables.AddRange(Globals.GetEntityIncludableProperties(_entityName).Select(e => e + "Id"));

            var tempList = (from plainProp in _plainProps
                let plainPropName = plainProp.Split(' ')[1]
                where !includables.Contains(plainPropName)
                select plainProp).ToList();
            
            propsTextBox.Text = string.Join(Environment.NewLine, tempList);
        }
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