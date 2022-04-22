namespace CleanArchitectureHelper;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddCommandButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.AddQueryButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LoadProjectButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ProjectSettingsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(81, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "NO PROJECT";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 45);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // AddCommandButton
            // 
            this.AddCommandButton.Animated = true;
            this.AddCommandButton.BorderColor = System.Drawing.Color.Gainsboro;
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
            this.AddCommandButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCommandButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AddCommandButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.AddCommandButton.Location = new System.Drawing.Point(27, 107);
            this.AddCommandButton.Name = "AddCommandButton";
            this.AddCommandButton.Size = new System.Drawing.Size(313, 54);
            this.AddCommandButton.TabIndex = 7;
            this.AddCommandButton.Text = "ADD COMMAND";
            this.AddCommandButton.Click += new System.EventHandler(this.AddCommandButton_Click);
            this.AddCommandButton.MouseEnter += new System.EventHandler(this.ProjectSettingsButton_MouseEnter);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 2;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AddQueryButton
            // 
            this.AddQueryButton.Animated = true;
            this.AddQueryButton.BorderColor = System.Drawing.Color.Gainsboro;
            this.AddQueryButton.BorderRadius = 1;
            this.AddQueryButton.BorderThickness = 1;
            this.AddQueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQueryButton.CustomizableEdges.BottomLeft = false;
            this.AddQueryButton.CustomizableEdges.TopRight = false;
            this.AddQueryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddQueryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddQueryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddQueryButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddQueryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddQueryButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddQueryButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.AddQueryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddQueryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AddQueryButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.AddQueryButton.Location = new System.Drawing.Point(27, 176);
            this.AddQueryButton.Name = "AddQueryButton";
            this.AddQueryButton.Size = new System.Drawing.Size(313, 54);
            this.AddQueryButton.TabIndex = 8;
            this.AddQueryButton.Text = "ADD QUERY";
            this.AddQueryButton.Click += new System.EventHandler(this.AddQueryButton_Click);
            this.AddQueryButton.MouseEnter += new System.EventHandler(this.ProjectSettingsButton_MouseEnter);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(319, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 27);
            this.guna2ControlBox1.TabIndex = 9;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(269, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 27);
            this.guna2ControlBox2.TabIndex = 10;
            // 
            // LoadProjectButton
            // 
            this.LoadProjectButton.Animated = true;
            this.LoadProjectButton.BorderColor = System.Drawing.Color.Gainsboro;
            this.LoadProjectButton.BorderRadius = 1;
            this.LoadProjectButton.BorderThickness = 1;
            this.LoadProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadProjectButton.CustomizableEdges.BottomLeft = false;
            this.LoadProjectButton.CustomizableEdges.TopRight = false;
            this.LoadProjectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoadProjectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoadProjectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadProjectButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadProjectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoadProjectButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.LoadProjectButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.LoadProjectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadProjectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.LoadProjectButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.LoadProjectButton.Location = new System.Drawing.Point(190, 278);
            this.LoadProjectButton.Name = "LoadProjectButton";
            this.LoadProjectButton.Size = new System.Drawing.Size(150, 40);
            this.LoadProjectButton.TabIndex = 14;
            this.LoadProjectButton.Text = "LOAD PROJECT";
            this.LoadProjectButton.Click += new System.EventHandler(this.LoadProjectButton_Click);
            // 
            // ProjectSettingsButton
            // 
            this.ProjectSettingsButton.Animated = true;
            this.ProjectSettingsButton.BorderColor = System.Drawing.Color.Gainsboro;
            this.ProjectSettingsButton.BorderRadius = 1;
            this.ProjectSettingsButton.BorderThickness = 1;
            this.ProjectSettingsButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ProjectSettingsButton.CustomizableEdges.BottomLeft = false;
            this.ProjectSettingsButton.CustomizableEdges.TopRight = false;
            this.ProjectSettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProjectSettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProjectSettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProjectSettingsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProjectSettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProjectSettingsButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectSettingsButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ProjectSettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProjectSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ProjectSettingsButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ProjectSettingsButton.Location = new System.Drawing.Point(27, 278);
            this.ProjectSettingsButton.Name = "ProjectSettingsButton";
            this.ProjectSettingsButton.Size = new System.Drawing.Size(150, 40);
            this.ProjectSettingsButton.TabIndex = 15;
            this.ProjectSettingsButton.Text = "PROJECT SETTINGS";
            this.ProjectSettingsButton.Click += new System.EventHandler(this.ProjectSettingsButton_Click);
            this.ProjectSettingsButton.MouseEnter += new System.EventHandler(this.ProjectSettingsButton_MouseEnter);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Separator1.Location = new System.Drawing.Point(27, 251);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(313, 10);
            this.guna2Separator1.TabIndex = 17;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Separator2.Location = new System.Drawing.Point(27, 336);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(313, 10);
            this.guna2Separator2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(138, 333);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "HERMES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(364, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ProjectSettingsButton);
            this.Controls.Add(this.LoadProjectButton);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.AddQueryButton);
            this.Controls.Add(this.AddCommandButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clean Architure Helper - winopasja.cahp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Label label1;
    private TableLayoutPanel tableLayoutPanel1;
    private Guna.UI2.WinForms.Guna2GradientButton AddCommandButton;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna.UI2.WinForms.Guna2GradientButton AddQueryButton;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Guna.UI2.WinForms.Guna2GradientButton LoadProjectButton;
    private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    private Guna.UI2.WinForms.Guna2GradientButton ProjectSettingsButton;
    private Label label2;
    private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
}