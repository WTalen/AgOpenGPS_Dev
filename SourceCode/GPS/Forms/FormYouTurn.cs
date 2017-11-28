using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using Keypad;

namespace AgOpenGPS
{
    public partial class FormYouTurn : Form
    {
        //properties
        private readonly FormGPS mf = null;

        public FormYouTurn(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void btnYouTurnKeyHole_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\KeyHole.txt");
            Properties.Settings.Default.setAS_youTurnShape = "KeyHole.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.Yellow;
            btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
            btnYouTurnCustom.BackColor = Color.LimeGreen;

            //back to FormGPS
            //DialogResult = DialogResult.OK;
        }

        private void btnYouTurnSemiCircle_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\SemiCircle.txt");
            Properties.Settings.Default.setAS_youTurnShape = "SemiCircle.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.LimeGreen;
            btnYouTurnSemiCircle.BackColor = Color.Yellow;
            btnYouTurnCustom.BackColor = Color.LimeGreen;

            //back to FormGPS
            //DialogResult = DialogResult.OK;
        }

        private void btnYouTurnCustom_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\Custom.txt");
            Properties.Settings.Default.setAS_youTurnShape = "Custom.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.LimeGreen;
            btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
            btnYouTurnCustom.BackColor = Color.Yellow;

            //back to FormGPS
            //DialogResult = DialogResult.OK;
        }

        private void btnYouTurnRecord_Click(object sender, EventArgs e)
        {
            if (mf.ABLine.isABLineSet)
            {
                var form = new FormYouTurnRecord(mf);
                form.Show();
                Properties.Settings.Default.setAS_startYouTurnAt = mf.yt.startYouTurnAt;
                Properties.Settings.Default.Save();
                Close();
            }
            else { mf.TimedMessageBox(3000, "No AB Lines", "Start AB Line Guidance"); }
        }

        private void FormYouTurn_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.setAS_youTurnShape == "KeyHole.txt")
            {
                btnYouTurnKeyHole.BackColor = Color.Yellow;
                btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
                btnYouTurnCustom.BackColor = Color.LimeGreen;
            }

            if (Properties.Settings.Default.setAS_youTurnShape == "SemiCircle.txt")
            {
                btnYouTurnKeyHole.BackColor = Color.LimeGreen;
                btnYouTurnSemiCircle.BackColor = Color.Yellow;
                btnYouTurnCustom.BackColor = Color.LimeGreen;
            }

            if (Properties.Settings.Default.setAS_youTurnShape == "Custom.txt")
            {
                btnYouTurnKeyHole.BackColor = Color.LimeGreen;
                btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
                btnYouTurnCustom.BackColor = Color.Yellow;
            }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.setAS_startYouTurnAt = mf.yt.startYouTurnAt;
            //Properties.Settings.Default.Save();
            Close();
        }
    }
}
