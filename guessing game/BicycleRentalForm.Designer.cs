using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame;

partial class BicycleRentalForm
{
    private Label titleLabel = null!;
    private Label subtitleLabel = null!;
    private Label startTimeLabel = null!;
    private Label endTimeLabel = null!;
    private Label totalLabel = null!;
    private Label ratesTitleLabel = null!;
    private Label rateLabel = null!;
    private TextBox startTimeTextBox = null!;
    private TextBox endTimeTextBox = null!;
    private TextBox totalTextBox = null!;
    private Button calculateButton = null!;
    private Button backButton = null!;
    private Panel headerPanel = null!;
    private Panel rentalCard = null!;
    private Panel ratesCard = null!;

    private void InitializeComponent()
    {
        titleLabel = new Label();
        subtitleLabel = new Label();
        startTimeLabel = new Label();
        endTimeLabel = new Label();
        totalLabel = new Label();
        ratesTitleLabel = new Label();
        rateLabel = new Label();
        startTimeTextBox = new TextBox();
        endTimeTextBox = new TextBox();
        totalTextBox = new TextBox();
        calculateButton = new Button();
        backButton = new Button();
        headerPanel = new Panel();
        rentalCard = new Panel();
        ratesCard = new Panel();
        headerPanel.SuspendLayout();
        rentalCard.SuspendLayout();
        ratesCard.SuspendLayout();
        SuspendLayout();

        // Left sidebar (also hosts the back button)
        headerPanel.BackColor = Color.FromArgb(24, 32, 56);
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Controls.Add(subtitleLabel);
        headerPanel.Controls.Add(backButton);
        headerPanel.Dock = DockStyle.Left;
        headerPanel.Size = new Size(240, 420);
        titleLabel.AutoSize = true;
        titleLabel.MaximumSize = new Size(200, 0);
        titleLabel.Font = new Font("Georgia", 22F, FontStyle.Bold);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(22, 50);
        titleLabel.Text = "Bicycle Rental";
        subtitleLabel.AutoSize = true;
        subtitleLabel.MaximumSize = new Size(200, 0);
        subtitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        subtitleLabel.ForeColor = Color.FromArgb(244, 166, 150);
        subtitleLabel.Location = new Point(24, 170);
        subtitleLabel.Text = "Enter the rental hours to calculate the total price.";
        backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        backButton.BackColor = Color.FromArgb(24, 32, 56);
        backButton.FlatAppearance.BorderColor = Color.FromArgb(244, 166, 150);
        backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 88);
        backButton.FlatStyle = FlatStyle.Flat;
        backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        backButton.ForeColor = Color.White;
        backButton.Location = new Point(24, 352);
        backButton.Size = new Size(160, 38);
        backButton.Text = "Back to menu";
        backButton.UseVisualStyleBackColor = false;
        backButton.Click += backButton_Click;

        // Input card
        rentalCard.BackColor = Color.White;
        rentalCard.Controls.Add(startTimeLabel);
        rentalCard.Controls.Add(startTimeTextBox);
        rentalCard.Controls.Add(endTimeLabel);
        rentalCard.Controls.Add(endTimeTextBox);
        rentalCard.Controls.Add(calculateButton);
        rentalCard.Controls.Add(totalLabel);
        rentalCard.Controls.Add(totalTextBox);
        rentalCard.Location = new Point(270, 36);
        rentalCard.Size = new Size(310, 348);
        startTimeLabel.AutoSize = true;
        startTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        startTimeLabel.ForeColor = Color.FromArgb(112, 118, 138);
        startTimeLabel.Location = new Point(24, 22);
        startTimeLabel.Text = "Starting time (0 to 23)";
        startTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
        startTimeTextBox.Font = new Font("Segoe UI", 11F);
        startTimeTextBox.ForeColor = Color.FromArgb(36, 41, 61);
        startTimeTextBox.Location = new Point(26, 48);
        startTimeTextBox.Size = new Size(260, 27);
        endTimeLabel.AutoSize = true;
        endTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        endTimeLabel.ForeColor = Color.FromArgb(112, 118, 138);
        endTimeLabel.Location = new Point(24, 94);
        endTimeLabel.Text = "Ending time (1 to 24)";
        endTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
        endTimeTextBox.Font = new Font("Segoe UI", 11F);
        endTimeTextBox.ForeColor = Color.FromArgb(36, 41, 61);
        endTimeTextBox.Location = new Point(26, 120);
        endTimeTextBox.Size = new Size(260, 27);
        calculateButton.BackColor = Color.FromArgb(232, 93, 76);
        calculateButton.FlatAppearance.BorderSize = 0;
        calculateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 118, 100);
        calculateButton.FlatStyle = FlatStyle.Flat;
        calculateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        calculateButton.ForeColor = Color.White;
        calculateButton.Location = new Point(26, 174);
        calculateButton.Size = new Size(260, 44);
        calculateButton.Text = "Calculate cost";
        calculateButton.UseVisualStyleBackColor = false;
        calculateButton.Click += calculateButton_Click;
        totalLabel.AutoSize = true;
        totalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        totalLabel.ForeColor = Color.FromArgb(112, 118, 138);
        totalLabel.Location = new Point(24, 248);
        totalLabel.Text = "Total amount";
        totalTextBox.BackColor = Color.FromArgb(246, 244, 240);
        totalTextBox.BorderStyle = BorderStyle.None;
        totalTextBox.Font = new Font("Georgia", 15F, FontStyle.Bold);
        totalTextBox.ForeColor = Color.FromArgb(232, 93, 76);
        totalTextBox.Location = new Point(26, 274);
        totalTextBox.ReadOnly = true;
        totalTextBox.Size = new Size(260, 30);

        // Rates card
        ratesCard.BackColor = Color.White;
        ratesCard.Controls.Add(ratesTitleLabel);
        ratesCard.Controls.Add(rateLabel);
        ratesCard.Location = new Point(600, 36);
        ratesCard.Size = new Size(290, 348);
        ratesTitleLabel.AutoSize = true;
        ratesTitleLabel.Font = new Font("Georgia", 14F, FontStyle.Bold);
        ratesTitleLabel.ForeColor = Color.FromArgb(24, 32, 56);
        ratesTitleLabel.Location = new Point(22, 20);
        ratesTitleLabel.Text = "Hourly rates";
        rateLabel.Location = new Point(24, 66);
        rateLabel.Size = new Size(250, 260);
        rateLabel.Font = new Font("Consolas", 9.5F);
        rateLabel.ForeColor = Color.FromArgb(36, 41, 61);
        rateLabel.Text = "00:00-07:00     500 RWF per hour\r\n\r\n07:00-14:00  1,000 RWF per hour\r\n\r\n14:00-19:00  1,500 RWF per hour\r\n\r\n19:00-21:00  1,000 RWF per hour\r\n\r\n21:00-24:00     500 RWF per hour";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 244, 240);
        ClientSize = new Size(920, 420);
        Controls.Add(ratesCard);
        Controls.Add(rentalCard);
        Controls.Add(headerPanel);
        Font = new Font("Segoe UI", 10F);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bicycle Rental";
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        rentalCard.ResumeLayout(false);
        rentalCard.PerformLayout();
        ratesCard.ResumeLayout(false);
        ratesCard.PerformLayout();
        ResumeLayout(false);
    }
}
