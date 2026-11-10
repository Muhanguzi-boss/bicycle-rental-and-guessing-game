using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame;

partial class MushroomIdentificationForm
{
    private Label titleLabel = null!;
    private Label subtitleLabel = null!;
    private Label progressLabel = null!;
    private Label questionLabel = null!;
    private Button yesButton = null!;
    private Button noButton = null!;
    private Button backButton = null!;
    private Panel headerPanel = null!;
    private Panel questionCard = null!;

    private void InitializeComponent()
    {
        titleLabel = new Label();
        subtitleLabel = new Label();
        progressLabel = new Label();
        questionLabel = new Label();
        yesButton = new Button();
        noButton = new Button();
        backButton = new Button();
        headerPanel = new Panel();
        questionCard = new Panel();
        headerPanel.SuspendLayout();
        questionCard.SuspendLayout();
        SuspendLayout();

        // Left sidebar (also hosts the back button)
        headerPanel.BackColor = Color.FromArgb(24, 32, 56);
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Controls.Add(subtitleLabel);
        headerPanel.Controls.Add(backButton);
        headerPanel.Dock = DockStyle.Left;
        headerPanel.Name = "headerPanel";
        headerPanel.Size = new Size(240, 400);
        headerPanel.TabIndex = 4;
        titleLabel.AutoSize = true;
        titleLabel.MaximumSize = new Size(200, 0);
        titleLabel.Font = new Font("Georgia", 20F, FontStyle.Bold);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(22, 50);
        titleLabel.Name = "titleLabel";
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Mushroom Identification";
        subtitleLabel.AutoSize = true;
        subtitleLabel.MaximumSize = new Size(200, 0);
        subtitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        subtitleLabel.ForeColor = Color.FromArgb(244, 166, 150);
        subtitleLabel.Location = new Point(24, 170);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.TabIndex = 1;
        subtitleLabel.Text = "Identify one of the six mushroom types.";
        backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        backButton.BackColor = Color.FromArgb(24, 32, 56);
        backButton.FlatAppearance.BorderColor = Color.FromArgb(244, 166, 150);
        backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 88);
        backButton.FlatStyle = FlatStyle.Flat;
        backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        backButton.ForeColor = Color.White;
        backButton.Location = new Point(24, 332);
        backButton.Name = "backButton";
        backButton.Size = new Size(160, 38);
        backButton.TabIndex = 0;
        backButton.Text = "← Back to menu";
        backButton.UseVisualStyleBackColor = false;
        backButton.Click += backButton_Click;

        // Question card
        questionCard.BackColor = Color.White;
        questionCard.Controls.Add(progressLabel);
        questionCard.Controls.Add(questionLabel);
        questionCard.Location = new Point(270, 40);
        questionCard.Name = "questionCard";
        questionCard.Size = new Size(520, 210);
        questionCard.TabIndex = 3;
        progressLabel.AutoSize = true;
        progressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        progressLabel.ForeColor = Color.FromArgb(232, 93, 76);
        progressLabel.Location = new Point(28, 24);
        progressLabel.Name = "progressLabel";
        progressLabel.TabIndex = 0;
        progressLabel.Text = "STEP 1 OF 3";
        questionLabel.Font = new Font("Georgia", 16F, FontStyle.Bold);
        questionLabel.ForeColor = Color.FromArgb(24, 32, 56);
        questionLabel.Location = new Point(28, 64);
        questionLabel.Name = "questionLabel";
        questionLabel.Size = new Size(464, 120);
        questionLabel.TabIndex = 1;
        questionLabel.TextAlign = ContentAlignment.MiddleLeft;

        // Answer buttons
        yesButton.BackColor = Color.FromArgb(232, 93, 76);
        yesButton.FlatAppearance.BorderSize = 0;
        yesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 118, 100);
        yesButton.FlatStyle = FlatStyle.Flat;
        yesButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        yesButton.ForeColor = Color.White;
        yesButton.Location = new Point(270, 280);
        yesButton.Name = "yesButton";
        yesButton.Size = new Size(250, 56);
        yesButton.TabIndex = 2;
        yesButton.Text = "Yes";
        yesButton.UseVisualStyleBackColor = false;
        yesButton.Click += yesButton_Click;
        noButton.BackColor = Color.White;
        noButton.FlatAppearance.BorderColor = Color.FromArgb(24, 32, 56);
        noButton.FlatAppearance.BorderSize = 2;
        noButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 234, 242);
        noButton.FlatStyle = FlatStyle.Flat;
        noButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        noButton.ForeColor = Color.FromArgb(24, 32, 56);
        noButton.Location = new Point(540, 280);
        noButton.Name = "noButton";
        noButton.Size = new Size(250, 56);
        noButton.TabIndex = 1;
        noButton.Text = "No";
        noButton.UseVisualStyleBackColor = false;
        noButton.Click += noButton_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 244, 240);
        ClientSize = new Size(820, 400);
        Controls.Add(noButton);
        Controls.Add(yesButton);
        Controls.Add(questionCard);
        Controls.Add(headerPanel);
        Font = new Font("Segoe UI", 10F);
        Name = "MushroomIdentificationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mushroom Identification";
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        questionCard.ResumeLayout(false);
        questionCard.PerformLayout();
        ResumeLayout(false);
    }
}
