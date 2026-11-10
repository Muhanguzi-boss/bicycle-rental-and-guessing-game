using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame;

partial class LoginForm
{
    private Label titleLabel = null!;
    private Label subtitleLabel = null!;
    private Label usernameLabel = null!;
    private Label passwordLabel = null!;
    private Label hintLabel = null!;
    private TextBox usernameTextBox = null!;
    private TextBox passwordTextBox = null!;
    private Button loginButton = null!;
    private Panel headerPanel = null!;
    private Panel loginCard = null!;

    private void InitializeComponent()
    {
        titleLabel = new Label();
        subtitleLabel = new Label();
        usernameLabel = new Label();
        passwordLabel = new Label();
        hintLabel = new Label();
        usernameTextBox = new TextBox();
        passwordTextBox = new TextBox();
        loginButton = new Button();
        headerPanel = new Panel();
        loginCard = new Panel();
        headerPanel.SuspendLayout();
        loginCard.SuspendLayout();
        SuspendLayout();

        // Left sidebar
        headerPanel.BackColor = Color.FromArgb(24, 32, 56);
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Controls.Add(subtitleLabel);
        headerPanel.Dock = DockStyle.Left;
        headerPanel.Size = new Size(260, 440);
        titleLabel.AutoSize = true;
        titleLabel.MaximumSize = new Size(220, 0);
        titleLabel.Font = new Font("Georgia", 22F, FontStyle.Bold);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(24, 70);
        titleLabel.Text = "Welcome back";
        subtitleLabel.AutoSize = true;
        subtitleLabel.MaximumSize = new Size(220, 0);
        subtitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        subtitleLabel.ForeColor = Color.FromArgb(244, 166, 150);
        subtitleLabel.Location = new Point(26, 160);
        subtitleLabel.Text = "Rental & Nature System";

        // Form area (no card chrome, transparent so the page color shows)
        loginCard.BackColor = Color.FromArgb(246, 244, 240);
        loginCard.Controls.Add(usernameLabel);
        loginCard.Controls.Add(usernameTextBox);
        loginCard.Controls.Add(passwordLabel);
        loginCard.Controls.Add(passwordTextBox);
        loginCard.Controls.Add(loginButton);
        loginCard.Controls.Add(hintLabel);
        loginCard.Location = new Point(260, 0);
        loginCard.Size = new Size(460, 440);
        usernameLabel.AutoSize = true;
        usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        usernameLabel.ForeColor = Color.FromArgb(112, 118, 138);
        usernameLabel.Location = new Point(40, 90);
        usernameLabel.Text = "Username";
        usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
        usernameTextBox.Font = new Font("Segoe UI", 11F);
        usernameTextBox.ForeColor = Color.FromArgb(36, 41, 61);
        usernameTextBox.Location = new Point(42, 116);
        usernameTextBox.Size = new Size(376, 27);
        passwordLabel.AutoSize = true;
        passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        passwordLabel.ForeColor = Color.FromArgb(112, 118, 138);
        passwordLabel.Location = new Point(40, 168);
        passwordLabel.Text = "Password";
        passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
        passwordTextBox.Font = new Font("Segoe UI", 11F);
        passwordTextBox.ForeColor = Color.FromArgb(36, 41, 61);
        passwordTextBox.Location = new Point(42, 194);
        passwordTextBox.Size = new Size(376, 27);
        passwordTextBox.UseSystemPasswordChar = true;
        loginButton.BackColor = Color.FromArgb(232, 93, 76);
        loginButton.FlatAppearance.BorderSize = 0;
        loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 118, 100);
        loginButton.FlatStyle = FlatStyle.Flat;
        loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        loginButton.ForeColor = Color.White;
        loginButton.Location = new Point(42, 255);
        loginButton.Size = new Size(376, 48);
        loginButton.Text = "Log in";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += loginButton_Click;
        hintLabel.AutoSize = true;
        hintLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        hintLabel.ForeColor = Color.FromArgb(112, 118, 138);
        hintLabel.Location = new Point(42, 328);
        hintLabel.Text = "Demo account: student   |   Password: 1234";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 244, 240);
        ClientSize = new Size(720, 440);
        Controls.Add(loginCard);
        Controls.Add(headerPanel);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        loginCard.ResumeLayout(false);
        loginCard.PerformLayout();
        ResumeLayout(false);
    }
}
