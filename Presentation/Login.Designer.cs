using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation;

partial class Login
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pictureBox1 = new PictureBox();
        LblTitle = new Label();
        LblHint = new Label();
        LblServer = new Label();
        LblAuthentication = new Label();
        LblUsername = new Label();
        LblPassword = new Label();
        CmBxServer = new ComboBox();
        CmbxAuthentication = new ComboBox();
        TxtUsername = new TextBox();
        TxtPassword = new TextBox();
        BtnLogin = new Button();
        BtnCancel = new Button();
        panel1 = new Panel();
        groupBox1 = new GroupBox();
        cmbTypeDB = new ComboBox();
        ((ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.Location = new Point(34, 10);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(272, 71);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // LblTitle
        // 
        LblTitle.Font = new Font("Segoe UI Semibold", 16F);
        LblTitle.ForeColor = Color.FromArgb(235, 235, 240);
        LblTitle.Location = new Point(31, 76);
        LblTitle.Name = "LblTitle";
        LblTitle.Size = new Size(277, 53);
        LblTitle.TabIndex = 14;
        LblTitle.Text = "Server Connect";
        LblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblHint
        // 
        LblHint.Font = new Font("Segoe UI", 9.5F);
        LblHint.ForeColor = Color.FromArgb(160, 163, 175);
        LblHint.Location = new Point(31, 118);
        LblHint.Name = "LblHint";
        LblHint.Size = new Size(277, 21);
        LblHint.TabIndex = 13;
        LblHint.Text = "Connect to your SQL Server database";
        LblHint.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblServer
        // 
        LblServer.AutoSize = true;
        LblServer.Font = new Font("Segoe UI", 9.5F);
        LblServer.ForeColor = Color.FromArgb(235, 235, 240);
        LblServer.Location = new Point(31, 151);
        LblServer.Name = "LblServer";
        LblServer.Size = new Size(55, 21);
        LblServer.TabIndex = 12;
        LblServer.Text = "Server";
        // 
        // LblAuthentication
        // 
        LblAuthentication.AutoSize = true;
        LblAuthentication.Font = new Font("Segoe UI", 9.5F);
        LblAuthentication.ForeColor = Color.FromArgb(235, 235, 240);
        LblAuthentication.Location = new Point(31, 262);
        LblAuthentication.Name = "LblAuthentication";
        LblAuthentication.Size = new Size(111, 21);
        LblAuthentication.TabIndex = 10;
        LblAuthentication.Text = "Authentication";
        // 
        // LblUsername
        // 
        LblUsername.AutoSize = true;
        LblUsername.Font = new Font("Segoe UI", 9.5F);
        LblUsername.ForeColor = Color.FromArgb(235, 235, 240);
        LblUsername.Location = new Point(5, 50);
        LblUsername.Name = "LblUsername";
        LblUsername.Size = new Size(81, 21);
        LblUsername.TabIndex = 9;
        LblUsername.Text = "Username";
        // 
        // LblPassword
        // 
        LblPassword.AutoSize = true;
        LblPassword.Font = new Font("Segoe UI", 9.5F);
        LblPassword.ForeColor = Color.FromArgb(235, 235, 240);
        LblPassword.Location = new Point(5, 79);
        LblPassword.Name = "LblPassword";
        LblPassword.Size = new Size(76, 21);
        LblPassword.TabIndex = 8;
        LblPassword.Text = "Password";
        // 
        // CmBxServer
        // 
        CmBxServer.AutoCompleteMode = AutoCompleteMode.Append;
        CmBxServer.AutoCompleteSource = AutoCompleteSource.ListItems;
        CmBxServer.BackColor = Color.FromArgb(36, 38, 44);
        CmBxServer.FlatStyle = FlatStyle.Flat;
        CmBxServer.Font = new Font("Segoe UI", 9.5F);
        CmBxServer.ForeColor = Color.FromArgb(235, 235, 240);
        CmBxServer.IntegralHeight = false;
        CmBxServer.Location = new Point(34, 175);
        CmBxServer.Name = "CmBxServer";
        CmBxServer.Size = new Size(278, 29);
        CmBxServer.TabIndex = 1;
        CmBxServer.SelectedIndexChanged += CmBxServer_SelectedIndexChanged;
        // 
        // CmbxAuthentication
        // 
        CmbxAuthentication.BackColor = Color.FromArgb(36, 38, 44);
        CmbxAuthentication.DropDownStyle = ComboBoxStyle.DropDownList;
        CmbxAuthentication.FlatStyle = FlatStyle.Flat;
        CmbxAuthentication.Font = new Font("Segoe UI", 9.5F);
        CmbxAuthentication.ForeColor = Color.FromArgb(235, 235, 240);
        CmbxAuthentication.IntegralHeight = false;
        CmbxAuthentication.Items.AddRange(new object[] { "Windows Authentication", "SQL Server Authentication" });
        CmbxAuthentication.Location = new Point(31, 283);
        CmbxAuthentication.Name = "CmbxAuthentication";
        CmbxAuthentication.Size = new Size(278, 29);
        CmbxAuthentication.TabIndex = 3;
        CmbxAuthentication.SelectedIndexChanged += CmbxAuthentication_SelectedIndexChanged;
        // 
        // TxtUsername
        // 
        TxtUsername.BackColor = Color.FromArgb(36, 38, 44);
        TxtUsername.BorderStyle = BorderStyle.FixedSingle;
        TxtUsername.Font = new Font("Segoe UI", 9.5F);
        TxtUsername.ForeColor = Color.FromArgb(235, 235, 240);
        TxtUsername.Location = new Point(5, 45);
        TxtUsername.Name = "TxtUsername";
        TxtUsername.Size = new Size(267, 29);
        TxtUsername.TabIndex = 4;
        // 
        // TxtPassword
        // 
        TxtPassword.BackColor = Color.FromArgb(36, 38, 44);
        TxtPassword.BorderStyle = BorderStyle.FixedSingle;
        TxtPassword.Font = new Font("Segoe UI", 9.5F);
        TxtPassword.ForeColor = Color.FromArgb(235, 235, 240);
        TxtPassword.Location = new Point(5, 100);
        TxtPassword.Name = "TxtPassword";
        TxtPassword.PasswordChar = '●';
        TxtPassword.Size = new Size(267, 29);
        TxtPassword.TabIndex = 5;
        TxtPassword.UseSystemPasswordChar = true;
        // 
        // BtnLogin
        // 
        BtnLogin.BackColor = Color.OrangeRed;
        BtnLogin.FlatAppearance.BorderSize = 0;
        BtnLogin.FlatStyle = FlatStyle.Flat;
        BtnLogin.Font = new Font("Segoe UI Semibold", 9.5F);
        BtnLogin.ForeColor = Color.White;
        BtnLogin.Location = new Point(31, 479);
        BtnLogin.Name = "BtnLogin";
        BtnLogin.Size = new Size(133, 31);
        BtnLogin.TabIndex = 6;
        BtnLogin.Text = "Connect";
        BtnLogin.UseVisualStyleBackColor = false;
        BtnLogin.Click += BtnLogin_Click;
        // 
        // BtnCancel
        // 
        BtnCancel.BackColor = Color.FromArgb(45, 47, 54);
        BtnCancel.DialogResult = DialogResult.Cancel;
        BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(55, 58, 66);
        BtnCancel.FlatStyle = FlatStyle.Flat;
        BtnCancel.Font = new Font("Segoe UI", 9.5F);
        BtnCancel.ForeColor = Color.FromArgb(235, 235, 240);
        BtnCancel.Location = new Point(175, 479);
        BtnCancel.Name = "BtnCancel";
        BtnCancel.Size = new Size(133, 31);
        BtnCancel.TabIndex = 7;
        BtnCancel.Text = "Cancel";
        BtnCancel.UseVisualStyleBackColor = false;
        BtnCancel.Click += BtnCancel_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(23, 24, 28);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(382, 553);
        panel1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(TxtPassword);
        groupBox1.Controls.Add(LblUsername);
        groupBox1.Controls.Add(TxtUsername);
        groupBox1.Controls.Add(LblPassword);
        groupBox1.ForeColor = Color.FromArgb(160, 163, 175);
        groupBox1.Location = new Point(31, 324);
        groupBox1.Margin = new Padding(3, 14, 3, 14);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(277, 139);
        groupBox1.TabIndex = 15;
        groupBox1.TabStop = false;
        groupBox1.Text = "Login";
        // 
        // cmbTypeDB
        // 
        cmbTypeDB.AutoCompleteMode = AutoCompleteMode.Append;
        cmbTypeDB.AutoCompleteSource = AutoCompleteSource.ListItems;
        cmbTypeDB.BackColor = Color.FromArgb(36, 38, 44);
        cmbTypeDB.Enabled = false;
        cmbTypeDB.FlatStyle = FlatStyle.Flat;
        cmbTypeDB.Font = new Font("Segoe UI", 9.5F);
        cmbTypeDB.ForeColor = Color.FromArgb(235, 235, 240);
        cmbTypeDB.IntegralHeight = false;
        cmbTypeDB.Items.AddRange(new object[] { "sqlServer" });
        cmbTypeDB.Location = new Point(34, 221);
        cmbTypeDB.Name = "cmbTypeDB";
        cmbTypeDB.Size = new Size(278, 29);
        cmbTypeDB.TabIndex = 16;
        cmbTypeDB.Text = "choose type Server";
        // 
        // Login
        // 
        AcceptButton = BtnLogin;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 20);
        CancelButton = BtnCancel;
        ClientSize = new Size(340, 533);
        Controls.Add(cmbTypeDB);
        Controls.Add(BtnCancel);
        Controls.Add(BtnLogin);
        Controls.Add(CmbxAuthentication);
        Controls.Add(LblAuthentication);
        Controls.Add(CmBxServer);
        Controls.Add(LblServer);
        Controls.Add(LblHint);
        Controls.Add(LblTitle);
        Controls.Add(pictureBox1);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Business Intelligence - Login";
        Load += Login_Load;
        ((ISupportInitialize)pictureBox1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;

    private Label LblTitle;
    private Label LblHint;
    private Label LblServer;
    private Label LblAuthentication;
    private Label LblUsername;
    private Label LblPassword;

    private ComboBox CmBxServer;
    private ComboBox CmbxAuthentication;

    private TextBox TxtUsername;
    private TextBox TxtPassword;

    private Button BtnLogin;
    private Button BtnCancel;

    private Panel panel1;
    private GroupBox groupBox1;
    private ComboBox cmbTypeDB;
}