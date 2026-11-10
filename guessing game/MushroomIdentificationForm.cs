using System;
using System.Windows.Forms;

namespace GuessingGame;

public partial class MushroomIdentificationForm : Form
{
    private int questionNumber;
    private bool hasConvexCup;

    public MushroomIdentificationForm()
    {
        InitializeComponent();
        ResetQuestions();
    }

    private void yesButton_Click(object? sender, EventArgs e)
    {
        Answer(true);
    }

    private void noButton_Click(object? sender, EventArgs e)
    {
        Answer(false);
    }

    private void Answer(bool yes)
    {
        string? mushroom = null;

        if (questionNumber == 1)
        {
            hasConvexCup = yes;
            questionNumber = 2;
        }
        else if (questionNumber == 2)
        {
            if (yes)
                questionNumber = 3;
            else
                mushroom = hasConvexCup ? "Agaric Jaunissant" : "Coprin chevelu";
        }
        else if (questionNumber == 3)
        {
            if (hasConvexCup)
                mushroom = yes ? "Amanite tue-mouche" : "Pied bleu";
            else
                mushroom = yes ? "Girolle" : "Cepe de Bordeaux";
        }

        if (mushroom is not null)
        {
            MessageBox.Show($"Your mushroom is {mushroom}.", "Mushroom identified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetQuestions();
            return;
        }

        ShowQuestion();
    }

    private void ShowQuestion()
    {
        switch (questionNumber)
        {
            case 1:
                questionLabel.Text = "Does your mushroom have a convex cup?";
                break;
            case 2:
                questionLabel.Text = "Does your mushroom grow in a forest?";
                break;
            default:
                questionLabel.Text = hasConvexCup
                    ? "Does your mushroom have a ring?"
                    : "Does your mushroom have gills?";
                break;
        }
        progressLabel.Text = $"STEP {questionNumber} OF 3";
    }

    private void ResetQuestions()
    {
        questionNumber = 1;
        hasConvexCup = false;
        ShowQuestion();
    }

    private void backButton_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
