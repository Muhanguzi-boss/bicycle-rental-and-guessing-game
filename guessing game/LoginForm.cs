using System;
using System.Windows.Forms;

namespace GuessingGame;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void loginButton_Click(object? sender, EventArgs e)
    {
        if (usernameTextBox.Text == "student" && passwordTextBox.Text == "1234")
        {
            var menu = new MainMenuForm();
            menu.FormClosed += (_, _) => Close();
            Hide();
            menu.Show();
            return;
        }

        MessageBox.Show("The username or password is incorrect.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        passwordTextBox.Clear();
        passwordTextBox.Focus();
    }
}
