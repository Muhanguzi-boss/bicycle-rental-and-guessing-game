using System;
using System.Windows.Forms;

namespace GuessingGame;

public partial class BicycleRentalForm : Form
{
    public BicycleRentalForm()
    {
        InitializeComponent();
    }

    private void calculateButton_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(startTimeTextBox.Text, out var startTime) ||
            !int.TryParse(endTimeTextBox.Text, out var endTime))
        {
            MessageBox.Show("Enter whole numbers for both times.", "Invalid time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            totalTextBox.Clear();
            return;
        }

        if (startTime < 0 || startTime > 23 || endTime < 1 || endTime > 24 || startTime >= endTime)
        {
            MessageBox.Show("Start time must be 0-23, end time must be 1-24, and start must be earlier than end.", "Invalid time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            totalTextBox.Clear();
            return;
        }

        var total = 0;
        for (var hour = startTime; hour < endTime; hour++)
        {
            if (hour < 7)
                total += 500;
            else if (hour < 14)
                total += 1000;
            else if (hour < 19)
                total += 1500;
            else if (hour < 21)
                total += 1000;
            else
                total += 500;
        }

        totalTextBox.Text = $"{total:N0} RWF";
    }

    private void backButton_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
