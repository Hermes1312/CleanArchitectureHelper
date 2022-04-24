using CleanArchitectureHelper.ManagerForms;
using Guna.UI2.WinForms;

namespace CleanArchitectureHelper;

public partial class AddCommandForm : Form
{
    private readonly List<string> _plainMembers = new();
    private readonly List<string> _plainUsings = new();
    private readonly List<string> _plainInterfaces = new();
    
    public AddCommandForm()
    {
        InitializeComponent();
        
        AreasComboBox.Items.AddRange(Globals.ProjectModel!.Areas.ToArray());
    }

    private void ManageMembersButton_Click(object sender, EventArgs e) => new ParametersManagerForm(_plainMembers).ShowDialog();

    private void ManageUsingsButton_Click(object sender, EventArgs e) => new UsingsManagerForm(_plainUsings).ShowDialog();

    private void ManageInterfacesButton_Click(object sender, EventArgs e) => new DependencyInjectionManagerForm(_plainInterfaces).ShowDialog();

    private void AddCommandButton_Click(object sender, EventArgs e)
    {
        var dir = $"{Globals.ProjectModel!.DirectoryPath}\\{Globals.ProjectModel.Prefix}.Application.{AreasComboBox.Text}\\{FolderNameTextBox.Text}\\Commands\\";
        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        var path = $"{dir}{NameTextBox.Text}CommandHandler.cs";
        File.WriteAllText(path, commandTextBox.Text);

        if (File.Exists(path))
        {
            new Guna2MessageDialog()
            {
                Buttons = MessageDialogButtons.OK,
                Caption = "Succeed",
                Icon = MessageDialogIcon.Information,
                Parent = this,
                Style = MessageDialogStyle.Light,
                Text = "Successfully added new command! END"
            }.Show();
        }
        else
        {
            new Guna2MessageDialog()
            {
                Buttons = MessageDialogButtons.OK,
                Caption = "Error",
                Icon = MessageDialogIcon.Error,
                Parent = this,
                Style = MessageDialogStyle.Light,
                Text = "Something went wrong! END"
            }.Show();
        }
    }


    private void GenerateCommandButton_Click(object sender, EventArgs e)
    {
        var handlerCode = Globals.CQHandlerPattern;
        
        var commandCode = CtorMembersCheckBox.Checked
            ? Globals.CQRecordCtorPattern
            : Globals.CQRecordPattern;

        if (CtorMembersCheckBox.Checked)
        {
            commandCode = commandCode.Replace("[[NAME]]", NameTextBox.Text);
            commandCode = commandCode.Replace("[[MEMBERS]]", string.Join(", ", _plainMembers));
            commandCode = commandCode.Replace("[[RETURN]]", string.IsNullOrEmpty(ReturnTextBox.Text) ? "" : $"<{ReturnTextBox.Text}>");
        }

        else
        {
            commandCode = commandCode.Replace("[[NAME]]", NameTextBox.Text);
            commandCode = commandCode.Replace("[[RETURN]]", string.IsNullOrEmpty(ReturnTextBox.Text) ? "" : $"<{ReturnTextBox.Text}>");
            var membersList = (from plainMember in _plainMembers let memberString = $"\tpublic {plainMember} {{ get; init; }}" select memberString + (plainMember[..4] == "List" ? " = new();" : "")).ToList();
            var members = string.Join(Environment.NewLine, membersList);
            commandCode = commandCode.Replace("[[MEMBERS]]", members);
        }

        commandCode = commandCode.Replace("[[QC]]", "Command");
        commandCode = commandCode.Replace("[[PAGINATION]]", "");
        
        List<string> diProps = new(), diCtor = new(), diAssign = new();

        foreach (var plainInterface in _plainInterfaces)
        {
            var name = plainInterface[0] == 'I' ? plainInterface[1..] : plainInterface;

            if (plainInterface.Contains('<')) 
                name = plainInterface[..plainInterface.IndexOf('<')];

            name = "_"+name.FirstCharToLowerCase();

            diAssign.Add($"\t\t{name} = {name[1..]};");
            diCtor.Add($"{plainInterface} {name[1..]}");
            diProps.Add($"\tprivate readonly {plainInterface} {name};");
        }

        handlerCode = handlerCode.Replace("[[DI_PROPS]]", string.Join(Environment.NewLine, diProps));
        handlerCode = handlerCode.Replace("[[DI_ASSIGN]]", string.Join(Environment.NewLine, diAssign));
        handlerCode = handlerCode.Replace("[[DI_CTOR]]", string.Join(',', diCtor));
        handlerCode = handlerCode.Replace("[[QC2]]", "Commands");
        handlerCode = handlerCode.Replace("[[QC]]", "Command");
        handlerCode = handlerCode.Replace("[[PAGINATION]]", "");
        handlerCode = handlerCode.Replace("[[LAYER]]", "Application");

        handlerCode = handlerCode.Replace("[[PREFIX]]", Globals.ProjectModel!.Prefix);
        handlerCode = handlerCode.Replace("[[USINGS]]", string.Join(Environment.NewLine, _plainUsings.Select(u => $"using {u};").ToArray()));
        handlerCode = handlerCode.Replace("[[AREA]]", AreasComboBox.Text);
        handlerCode = handlerCode.Replace("[[FOLDER_NAME]]", FolderNameTextBox.Text);
        handlerCode = handlerCode.Replace("[[COMMAND]]", commandCode);
        handlerCode = handlerCode.Replace("[[NAME]]", NameTextBox.Text);
        handlerCode = handlerCode.Replace("[[RETURN]]", string.IsNullOrEmpty(ReturnTextBox.Text) ? "Unit" : $"{ReturnTextBox.Text}");
        handlerCode = handlerCode.Replace("[[RETURN2]]", string.IsNullOrEmpty(ReturnTextBox.Text) ? "" : $", {ReturnTextBox.Text}");

        commandTextBox.Text = handlerCode;
    }
}