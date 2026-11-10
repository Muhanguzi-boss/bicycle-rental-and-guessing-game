using System;
using System.Windows.Forms;

namespace GuessingGame;

public partial class MainMenuForm : Form
{
    public MainMenuForm()
    {
        InitializeComponent();
    }

    private void bicycleButton_Click(object? sender, EventArgs e)
    {
        OpenPage(new BicycleRentalForm());
    }

    private void mushroomButton_Click(object? sender, EventArgs e)
    {
        OpenPage(new MushroomIdentificationForm());
    }

    private void OpenPage(Form page)
    {
        Hide();
        page.FormClosed += (_, _) => Show();
        page.Show();
    }
}
