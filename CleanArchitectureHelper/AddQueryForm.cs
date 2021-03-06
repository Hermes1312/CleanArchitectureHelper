using CleanArchitectureHelper.ManagerForms;
using Guna.UI2.WinForms;

namespace CleanArchitectureHelper;

public partial class AddQueryForm : Form
{
    private readonly List<string>
        _plainParameters = new(),
        _plainUsings = new(),
        _plainInterfaces = new(),
        _plainVmProps = new();
    
    public AddQueryForm()
    {
        InitializeComponent();
 
    }

    private void ManageMembersButton_Click(object sender, EventArgs e) => new ParametersManagerForm(_plainParameters).ShowDialog();

    private void ManageUsingsButton_Click(object sender, EventArgs e) => new UsingsManagerForm(_plainUsings).ShowDialog();

    private void ManageInterfacesButton_Click(object sender, EventArgs e) => new DependencyInjectionManagerForm(_plainInterfaces).ShowDialog();
    
    private void ManageVmPropsButton_Click(object sender, EventArgs e) => new VmPropsManagerForm(_plainVmProps, EntitiesComboBox.Text).ShowDialog();

    private void AddQueryForm_Load(object sender, EventArgs e)
    {
        AreasComboBox.Items.AddRange(Globals.ProjectModel!.Areas.ToArray());
        EntitiesComboBox.Items.AddRange(Globals.GetEntitiesNames().ToArray());
    }

    private void EntitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (EntitiesComboBox.Text == "-")
        {
            _plainVmProps.Clear();
            return;
        }
        
        _plainVmProps.Clear(); 
        _plainVmProps.AddRange(Globals.GetEntityProperties(EntitiesComboBox.Text));
    }

    private void ManageIncludesButton_Click(object sender, EventArgs e)
    => new IncludesManagerForm(EntitiesComboBox.Text).ShowDialog();

    private void PaginatedListCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (PaginatedListCheckBox.Checked) 
            _plainParameters.Add("string SearchPhrase");
        else 
            _plainParameters.Remove("string SearchPhrase");
    }

    private void AddQueryButton_Click(object sender, EventArgs e)
    {
        try
        {
            var queryDir =
                $"{Globals.ProjectModel!.DirectoryPath}\\{Globals.ProjectModel.Prefix}.Application.{AreasComboBox.Text}\\{FolderNameTextBox.Text}\\Queries\\";
            if (!Directory.Exists(queryDir)) Directory.CreateDirectory(queryDir);

            var handlerDir =
                $"{Globals.ProjectModel!.DirectoryPath}\\{Globals.ProjectModel.Prefix}.Infrastructure.{AreasComboBox.Text}\\{FolderNameTextBox.Text}\\Queries\\";
            if (!Directory.Exists(handlerDir)) Directory.CreateDirectory(handlerDir);

            var queryPath = $"{queryDir}{NameTextBox.Text}Query.cs";
            File.WriteAllText(queryPath, QueryVmTextBox.Text);

            var handlerPath = $"{handlerDir}{NameTextBox.Text}QueryHandler.cs";
            File.WriteAllText(handlerPath, QueryHandlerTextBox.Text);


            new Guna2MessageDialog()
            {
                Buttons = MessageDialogButtons.OK,
                Caption = "Succeed",
                Icon = MessageDialogIcon.Information,
                Parent = this,
                Style = MessageDialogStyle.Light,
                Text = "Successfully added new query! END"
            }.Show();
        }
        catch (Exception)
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


    private void GenerateQueryButton_Click(object sender, EventArgs e)
    {
        var handlerCode = Globals.CQHandlerPattern;
        
        var queryCode = CtorParametersCheckBox.Checked
            ? Globals.CQRecordCtorPattern
            : Globals.CQRecordPattern;

        var vmCode = Globals.RecordPattern;

        var returnType = PaginatedListCheckBox.Checked
            ? $"PaginatedList<{NameTextBox.Text}QueryVm>"
            : $"{NameTextBox.Text}QueryVm";

        #region Query

        if (CtorParametersCheckBox.Checked)
            queryCode = queryCode.Replace("[[MEMBERS]]", string.Join(", ", _plainParameters));
        
        else
        {
            var paramsList = (from plainParam in _plainParameters let memberString = $"\tpublic {plainParam} {{ get; init; }}" select memberString + (plainParam[..4] == "List" ? " = new();" : "")).ToList();
            var parameters = string.Join(Environment.NewLine, paramsList);
            queryCode = queryCode.Replace("[[MEMBERS]]", parameters);
        }
        
        queryCode = queryCode.Replace("[[NAME]]", NameTextBox.Text);
        queryCode = queryCode.Replace("[[QC2]]", "Queries");
        queryCode = queryCode.Replace("[[QC]]", "Query");
        queryCode = queryCode.Replace("[[PAGINATION]]", PaginatedListCheckBox.Checked ? "PaginationRequest, " : "");
        queryCode = queryCode.Replace("[[RETURN]]",$"<{returnType}>");

        queryCode = $"namespace {Globals.ProjectModel!.Prefix}.Application.{AreasComboBox.Text}.{FolderNameTextBox.Text}.Queries;{Environment.NewLine}{Environment.NewLine}{queryCode}";
        #endregion

        #region QueryVm
        
        var propList = (from plainMember in _plainVmProps let memberString = $"\tpublic {plainMember} {{ get; init; }}" select memberString + (plainMember[..4] == "List" ? " = new();" : "")).ToList();
        var props = string.Join(Environment.NewLine, propList);
        
        vmCode = vmCode.Replace("[[MEMBERS]]", props);
        vmCode = vmCode.Replace("[[NAME]]", NameTextBox.Text+"Vm");

        #endregion

        #region Dependency Injection
        
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
        
        #endregion

        #region Handler

        handlerCode = handlerCode.Replace("[[DI_PROPS]]", string.Join(Environment.NewLine, diProps));
        handlerCode = handlerCode.Replace("[[DI_ASSIGN]]", string.Join(Environment.NewLine, diAssign));
        handlerCode = handlerCode.Replace("[[DI_CTOR]]", string.Join(',', diCtor));
        handlerCode = handlerCode.Replace("[[QC]]", "Query");
        handlerCode = handlerCode.Replace("[[QC2]]", "Queries");
        //handlerCode = handlerCode.Replace("[[PAGINATION]]", PaginatedListCheckBox.Checked ? "" : "");
        handlerCode = handlerCode.Replace("[[LAYER]]", "Infrastructure");
        
        handlerCode = handlerCode.Replace("[[PREFIX]]", Globals.ProjectModel!.Prefix);
        handlerCode = handlerCode.Replace("[[USINGS]]", string.Join(Environment.NewLine, _plainUsings.Select(u => $"using {u};").ToArray()));
        handlerCode = handlerCode.Replace("[[AREA]]", AreasComboBox.Text);
        handlerCode = handlerCode.Replace("[[FOLDER_NAME]]", FolderNameTextBox.Text);
        handlerCode = handlerCode.Replace("[[COMMAND]]", "");
        handlerCode = handlerCode.Replace("[[NAME]]", NameTextBox.Text);
        handlerCode = handlerCode.Replace("[[RETURN]]", returnType);
        handlerCode = handlerCode.Replace("[[RETURN2]]", ", "+returnType);
        
        if(GenerateHandlerCheckBox.Checked)
        
        #endregion

        QueryHandlerTextBox.Clear(); 
        QueryHandlerTextBox.AppendText(handlerCode); 
        QueryVmTextBox.Text = queryCode+Environment.NewLine+Environment.NewLine+vmCode;
    }
}