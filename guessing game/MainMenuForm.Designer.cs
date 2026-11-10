using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame;

partial class MainMenuForm
{
    private Label titleLabel = null!;
    private Label subtitleLabel = null!;
    private Label bicycleTitleLabel = null!;
    private Label bicycleDescriptionLabel = null!;
    private Label mushroomTitleLabel = null!;
    private Label mushroomDescriptionLabel = null!;
    private Label footerLabel = null!;
    private Button bicycleButton = null!;
    private Button mushroomButton = null!;
    private Panel headerPanel = null!;
    private Panel bicycleCard = null!;
    private Panel mushroomCard = null!;

    private void InitializeComponent()
    {
        titleLabel = new Label();
        subtitleLabel = new Label();
        bicycleTitleLabel = new Label();
        bicycleDescriptionLabel = new Label();
        mushroomTitleLabel = new Label();
        mushroomDescriptionLabel = new Label();
        footerLabel = new Label();
        bicycleButton = new Button();
        mushroomButton = new Button();
        headerPanel = new Panel();
        bicycleCard = new Panel();
        mushroomCard = new Panel();
        headerPanel.SuspendLayout();
        bicycleCard.SuspendLayout();
        mushroomCard.SuspendLayout();
        SuspendLayout();

        // Left sidebar
        headerPanel.BackColor = Color.FromArgb(24, 32, 56);
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Controls.Add(subtitleLabel);
        headerPanel.Dock = DockStyle.Left;
        headerPanel.Size = new Size(260, 470);
        titleLabel.AutoSize = true;
        titleLabel.MaximumSize = new Size(220, 0);
        titleLabel.Font = new Font("Georgia", 24F, FontStyle.Bold);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(24, 60);
        titleLabel.Text = "Rental & Nature";
        subtitleLabel.AutoSize = true;
        subtitleLabel.MaximumSize = new Size(220, 0);
        subtitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        subtitleLabel.ForeColor = Color.FromArgb(244, 166, 150);
        subtitleLabel.Location = new Point(26, 190);
        subtitleLabel.Text = "Choose a system to get started";

        // Horizontal row cards
        bicycleCard.BackColor = Color.White;
        bicycleCard.Controls.Add(bicycleTitleLabel);
        bicycleCard.Controls.Add(bicycleDescriptionLabel);
        bicycleCard.Controls.Add(bicycleButton);
        bicycleCard.Location = new Point(290, 40);
        bicycleCard.Size = new Size(540, 150);
        bicycleTitleLabel.AutoSize = true;
        bicycleTitleLabel.Font = new Font("Georgia", 15F, FontStyle.Bold);
        bicycleTitleLabel.ForeColor = Color.FromArgb(24, 32, 56);
        bicycleTitleLabel.Location = new Point(24, 20);
        bicycleTitleLabel.Text = "Bicycle Rental";
        bicycleDescriptionLabel.Location = new Point(26, 66);
        bicycleDescriptionLabel.Size = new Size(320, 60);
        bicycleDescriptionLabel.Font = new Font("Segoe UI", 10F);
        bicycleDescriptionLabel.ForeColor = Color.FromArgb(112, 118, 138);
        bicycleDescriptionLabel.Text = "Enter your rental hours and calculate\nthe total cost in RWF.";
        bicycleButton.BackColor = Color.FromArgb(232, 93, 76);
        bicycleButton.FlatAppearance.BorderSize = 0;
        bicycleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 118, 100);
        bicycleButton.FlatStyle = FlatStyle.Flat;
        bicycleButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        bicycleButton.ForeColor = Color.White;
        bicycleButton.Location = new Point(360, 50);
        bicycleButton.Size = new Size(160, 48);
        bicycleButton.Text = "Open bicycle rental";
        bicycleButton.UseVisualStyleBackColor = false;
        bicycleButton.Click += bicycleButton_Click;

        mushroomCard.BackColor = Color.White;
        mushroomCard.Controls.Add(mushroomTitleLabel);
        mushroomCard.Controls.Add(mushroomDescriptionLabel);
        mushroomCard.Controls.Add(mushroomButton);
        mushroomCard.Location = new Point(290, 215);
        mushroomCard.Size = new Size(540, 150);
        mushroomTitleLabel.AutoSize = true;
        mushroomTitleLabel.Font = new Font("Georgia", 15F, FontStyle.Bold);
        mushroomTitleLabel.ForeColor = Color.FromArgb(24, 32, 56);
        mushroomTitleLabel.Location = new Point(24, 20);
        mushroomTitleLabel.Text = "Mushroom Guide";
        mushroomDescriptionLabel.Location = new Point(26, 66);
        mushroomDescriptionLabel.Size = new Size(320, 60);
        mushroomDescriptionLabel.Font = new Font("Segoe UI", 10F);
        mushroomDescriptionLabel.ForeColor = Color.FromArgb(112, 118, 138);
        mushroomDescriptionLabel.Text = "Answer a few questions to identify\none of the six mushrooms.";
        mushroomButton.BackColor = Color.FromArgb(232, 93, 76);
        mushroomButton.FlatAppearance.BorderSize = 0;
        mushroomButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 118, 100);
        mushroomButton.FlatStyle = FlatStyle.Flat;
        mushroomButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        mushroomButton.ForeColor = Color.White;
        mushroomButton.Location = new Point(360, 50);
        mushroomButton.Size = new Size(160, 48);
        mushroomButton.Text = "Open mushroom guide";
        mushroomButton.UseVisualStyleBackColor = false;
        mushroomButton.Click += mushroomButton_Click;

        footerLabel.AutoSize = true;
        footerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        footerLabel.ForeColor = Color.FromArgb(112, 118, 138);
        footerLabel.Location = new Point(292, 392);
        footerLabel.Text = "A simple classroom system";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 244, 240);
        ClientSize = new Size(870, 470);
        Controls.Add(footerLabel);
        Controls.Add(bicycleCard);
        Controls.Add(mushroomCard);
        Controls.Add(headerPanel);
        Font = new Font("Segoe UI", 10F);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Menu";
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        bicycleCard.ResumeLayout(false);
        bicycleCard.PerformLayout();
        mushroomCard.ResumeLayout(false);
        mushroomCard.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
