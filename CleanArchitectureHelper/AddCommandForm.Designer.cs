using System.ComponentModel;

namespace CleanArchitectureHelper;

partial class AddCommandForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCommandForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.AddCommandButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AreasComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenerateCommandButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commandTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.FolderNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageMembersButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.CtorMembersCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ManageUsingsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ManageInterfacesButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 2;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(814, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 27);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(864, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 27);
            this.guna2ControlBox1.TabIndex = 11;
            // 
            // AddCommandButton
            // 
            this.AddCommandButton.Animated = true;
            this.AddCommandButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddCommandButton.BorderRadius = 1;
            this.AddCommandButton.BorderThickness = 1;
            this.AddCommandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCommandButton.CustomizableEdges.BottomLeft = false;
            this.AddCommandButton.CustomizableEdges.TopRight = false;
            this.AddCommandButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCommandButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCommandButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCommandButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCommandButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCommandButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddCommandButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.AddCommandButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCommandButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AddCommandButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.AddCommandButton.Location = new System.Drawing.Point(761, 571);
            this.AddCommandButton.Name = "AddCommandButton";
            this.AddCommandButton.Size = new System.Drawing.Size(125, 45);
            this.AddCommandButton.TabIndex = 20;
            this.AddCommandButton.Text = "ADD COMMAND";
            this.AddCommandButton.Click += new System.EventHandler(this.AddCommandButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Area*";
            // 
            // AreasComboBox
            // 
            this.AreasComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AreasComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AreasComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AreasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreasComboBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AreasComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AreasComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AreasComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreasComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AreasComboBox.ItemHeight = 30;
            this.AreasComboBox.Location = new System.Drawing.Point(33, 520);
            this.AreasComboBox.Name = "AreasComboBox";
            this.AreasComboBox.Size = new System.Drawing.Size(162, 36);
            this.AreasComboBox.TabIndex = 18;
            // 
            // GenerateCommandButton
            // 
            this.GenerateCommandButton.Animated = true;
            this.GenerateCommandButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenerateCommandButton.BorderRadius = 1;
            this.GenerateCommandButton.BorderThickness = 1;
            this.GenerateCommandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateCommandButton.CustomizableEdges.BottomLeft = false;
            this.GenerateCommandButton.CustomizableEdges.TopRight = false;
            this.GenerateCommandButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateCommandButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateCommandButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateCommandButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateCommandButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateCommandButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GenerateCommandButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.GenerateCommandButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateCommandButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.GenerateCommandButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.GenerateCommandButton.Location = new System.Drawing.Point(761, 520);
            this.GenerateCommandButton.Name = "GenerateCommandButton";
            this.GenerateCommandButton.Size = new System.Drawing.Size(125, 45);
            this.GenerateCommandButton.TabIndex = 21;
            this.GenerateCommandButton.Text = "GENERATE COMMAND";
            this.GenerateCommandButton.Click += new System.EventHandler(this.GenerateCommandButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.commandTextBox);
            this.panel1.Location = new System.Drawing.Point(33, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 419);
            this.panel1.TabIndex = 22;
            // 
            // commandTextBox
            // 
            this.commandTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.commandTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.commandTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.commandTextBox.BackBrush = null;
            this.commandTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.commandTextBox.CharHeight = 14;
            this.commandTextBox.CharWidth = 8;
            this.commandTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commandTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.commandTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commandTextBox.IsReplaceMode = false;
            this.commandTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.commandTextBox.LeftBracket = '(';
            this.commandTextBox.LeftBracket2 = '{';
            this.commandTextBox.Location = new System.Drawing.Point(1, 1);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.commandTextBox.RightBracket = ')';
            this.commandTextBox.RightBracket2 = '}';
            this.commandTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.commandTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("commandTextBox.ServiceColors")));
            this.commandTextBox.Size = new System.Drawing.Size(851, 417);
            this.commandTextBox.TabIndex = 17;
            this.commandTextBox.Zoom = 100;
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.Location = new System.Drawing.Point(33, 593);
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.Size = new System.Drawing.Size(185, 23);
            this.FolderNameTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Folder Name*";
            // 
            // ManageMembersButton
            // 
            this.ManageMembersButton.Animated = true;
            this.ManageMembersButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageMembersButton.BorderRadius = 1;
            this.ManageMembersButton.BorderThickness = 1;
            this.ManageMembersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageMembersButton.CustomizableEdges.BottomLeft = false;
            this.ManageMembersButton.CustomizableEdges.TopRight = false;
            this.ManageMembersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageMembersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageMembersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageMembersButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageMembersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageMembersButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ManageMembersButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ManageMembersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageMembersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ManageMembersButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ManageMembersButton.Location = new System.Drawing.Point(214, 520);
            this.ManageMembersButton.Name = "ManageMembersButton";
            this.ManageMembersButton.Size = new System.Drawing.Size(162, 36);
            this.ManageMembersButton.TabIndex = 25;
            this.ManageMembersButton.Text = "MANAGE MEMBERS";
            this.ManageMembersButton.Click += new System.EventHandler(this.ManageMembersButton_Click);
            // 
            // guna2vSeparator1
            // 
            this.guna2vSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2vSeparator1.Location = new System.Drawing.Point(745, 520);
            this.guna2vSeparator1.Name = "guna2vSeparator1";
            this.guna2vSeparator1.Size = new System.Drawing.Size(10, 115);
            this.guna2vSeparator1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(214, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Members:";
            // 
            // CtorMembersCheckBox
            // 
            this.CtorMembersCheckBox.AutoSize = true;
            this.CtorMembersCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CtorMembersCheckBox.CheckedState.BorderRadius = 0;
            this.CtorMembersCheckBox.CheckedState.BorderThickness = 0;
            this.CtorMembersCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CtorMembersCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CtorMembersCheckBox.Location = new System.Drawing.Point(531, 593);
            this.CtorMembersCheckBox.Name = "CtorMembersCheckBox";
            this.CtorMembersCheckBox.Size = new System.Drawing.Size(217, 23);
            this.CtorMembersCheckBox.TabIndex = 28;
            this.CtorMembersCheckBox.Text = "Write members to constructor";
            this.CtorMembersCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CtorMembersCheckBox.UncheckedState.BorderRadius = 0;
            this.CtorMembersCheckBox.UncheckedState.BorderThickness = 1;
            this.CtorMembersCheckBox.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(398, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Return";
            // 
            // ReturnTextBox
            // 
            this.ReturnTextBox.Location = new System.Drawing.Point(398, 593);
            this.ReturnTextBox.Name = "ReturnTextBox";
            this.ReturnTextBox.PlaceholderText = "Unit";
            this.ReturnTextBox.Size = new System.Drawing.Size(127, 23);
            this.ReturnTextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(398, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Additional usings:";
            // 
            // ManageUsingsButton
            // 
            this.ManageUsingsButton.Animated = true;
            this.ManageUsingsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageUsingsButton.BorderRadius = 1;
            this.ManageUsingsButton.BorderThickness = 1;
            this.ManageUsingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageUsingsButton.CustomizableEdges.BottomLeft = false;
            this.ManageUsingsButton.CustomizableEdges.TopRight = false;
            this.ManageUsingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageUsingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageUsingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageUsingsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageUsingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageUsingsButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ManageUsingsButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ManageUsingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageUsingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ManageUsingsButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ManageUsingsButton.Location = new System.Drawing.Point(398, 520);
            this.ManageUsingsButton.Name = "ManageUsingsButton";
            this.ManageUsingsButton.Size = new System.Drawing.Size(162, 36);
            this.ManageUsingsButton.TabIndex = 31;
            this.ManageUsingsButton.Text = "MANAGE USINGS";
            this.ManageUsingsButton.Click += new System.EventHandler(this.ManageUsingsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(224, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Name*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(224, 593);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(162, 23);
            this.NameTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(577, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Dependency injection:";
            // 
            // ManageInterfacesButton
            // 
            this.ManageInterfacesButton.Animated = true;
            this.ManageInterfacesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageInterfacesButton.BorderRadius = 1;
            this.ManageInterfacesButton.BorderThickness = 1;
            this.ManageInterfacesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageInterfacesButton.CustomizableEdges.BottomLeft = false;
            this.ManageInterfacesButton.CustomizableEdges.TopRight = false;
            this.ManageInterfacesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageInterfacesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageInterfacesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageInterfacesButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageInterfacesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageInterfacesButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ManageInterfacesButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ManageInterfacesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageInterfacesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ManageInterfacesButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ManageInterfacesButton.Location = new System.Drawing.Point(577, 520);
            this.ManageInterfacesButton.Name = "ManageInterfacesButton";
            this.ManageInterfacesButton.Size = new System.Drawing.Size(162, 36);
            this.ManageInterfacesButton.TabIndex = 35;
            this.ManageInterfacesButton.Text = "MANAGE DI";
            this.ManageInterfacesButton.Click += new System.EventHandler(this.ManageInterfacesButton_Click);
            // 
            // AddCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(910, 647);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ManageInterfacesButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ManageUsingsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnTextBox);
            this.Controls.Add(this.CtorMembersCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2vSeparator1);
            this.Controls.Add(this.ManageMembersButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FolderNameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenerateCommandButton);
            this.Controls.Add(this.AddCommandButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreasComboBox);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCommandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Command";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commandTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2GradientButton AddCommandButton;
    private Label label1;
    private Guna.UI2.WinForms.Guna2ComboBox AreasComboBox;
    private Guna.UI2.WinForms.Guna2GradientButton GenerateCommandButton;
    private Panel panel1;
    private Label label2;
    private TextBox FolderNameTextBox;
    private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
    private Guna.UI2.WinForms.Guna2GradientButton ManageMembersButton;
    private Guna.UI2.WinForms.Guna2CheckBox CtorMembersCheckBox;
    private Label label3;
    private Label label4;
    private TextBox ReturnTextBox;
    private Label label5;
    private Guna.UI2.WinForms.Guna2GradientButton ManageUsingsButton;
    private Label label6;
    private TextBox NameTextBox;
    private FastColoredTextBoxNS.FastColoredTextBox commandTextBox;
    private Label label7;
    private Guna.UI2.WinForms.Guna2GradientButton ManageInterfacesButton;
}