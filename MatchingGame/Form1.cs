using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        // Use this Random object to choose random icons for the squares
        Random random = new Random();
        // Each of these letters is an interesting icon
        // in the WebDings font,
        // and each icon appears twice in thes list
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if(clickedLabel!= null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed - -
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                // if firstClicked is null, this is the first icon
                // in the pair that the player clicked,
                // so set firstClicked to te label that the player
                // clicked, change its color to black, and return
                if(firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                CheckForWinner();
                if(firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                timer1.Start();
            }
        }

        // firstClicked points to the first Label control
        // that the player clicks, but it will be null
        // if the player hasn't clickeda label yet
        Label firstClicked = null;
        // secondClicked points to the second label control
        // that the player clicks
        Label secondClicked = null;

        /// <summary>
        /// This timer is started when the player clicks
        /// two icons that don't match,
        /// so it counts three quarters of a second
        /// and then turns itself off and hide both icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // stop the timer
            timer1.Stop();
            // hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            // reset firstClicked and secondClicked
            // so the next time a label is
            // clicked, the programm knows its the first click
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("You matched all the icons!", "Congratulations!");
            Close();
        }
    }
}
