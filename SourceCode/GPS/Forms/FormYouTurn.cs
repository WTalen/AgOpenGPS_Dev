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
        private readonly FormGPS mf;

        public FormYouTurn(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
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

            cboxRowHeight.SelectedIndex = mf.yt.rowSkipsHeight - 1;
            cboxRowWidth.SelectedIndex = mf.yt.rowSkipsWidth - 1;

            //populate the Enter and Exit pages.
            PopulateSequencePages();

            lblDistance.Text = mf.yt.youTurnStartOffset.ToString();
            if (mf.yt.isYouTurnBtnOn)
            {
                lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
                if (mf.yt.youTurnStartOffset < 0) lblWhenTrig.Text = "Before";
                else lblWhenTrig.Text = "After";
            }
            else
            {
                lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
                if (mf.yt.youTurnStartOffset < 0) lblWhenTrig.Text = "Before";
                else lblWhenTrig.Text = "After";
            }
        }

        private void PopulateSequencePages()
        {
            if (mf.seq.seqEnter[0].function == 0)
            {
                cboxEnterFunc0.SelectedIndex = mf.seq.seqEnter[0].function;
                cboxEnterAction0.SelectedIndex = -1;
            }
            else
            {
                cboxEnterFunc0.SelectedIndex = mf.seq.seqEnter[0].function;
                cboxEnterAction0.SelectedIndex = mf.seq.seqEnter[0].action;
                nudEnter0.Value = (decimal)mf.seq.seqEnter[0].distance;
            }

            if (mf.seq.seqEnter[1].function == 0)
            {
                cboxEnterFunc1.SelectedIndex = mf.seq.seqEnter[1].function;
                cboxEnterAction1.SelectedIndex = -1;
            }
            else
            {
                cboxEnterFunc1.SelectedIndex = mf.seq.seqEnter[1].function;
                cboxEnterAction1.SelectedIndex = mf.seq.seqEnter[1].action;
                nudEnter1.Value = (decimal)mf.seq.seqEnter[1].distance;
            }

            if (mf.seq.seqEnter[2].function == 0)
            {
                cboxEnterFunc2.SelectedIndex = mf.seq.seqEnter[2].function;
                cboxEnterAction2.SelectedIndex = -1;
            }
            else
            {
                cboxEnterFunc2.SelectedIndex = mf.seq.seqEnter[2].function;
                cboxEnterAction2.SelectedIndex = mf.seq.seqEnter[2].action;
                nudEnter2.Value = (decimal)mf.seq.seqEnter[2].distance;
            }

            if (mf.seq.seqEnter[3].function == 0)
            {
                cboxEnterFunc3.SelectedIndex = mf.seq.seqEnter[3].function;
                cboxEnterAction3.SelectedIndex = -1;
            }
            else
            {
                cboxEnterFunc3.SelectedIndex = mf.seq.seqEnter[3].function;
                cboxEnterAction3.SelectedIndex = mf.seq.seqEnter[3].action;
                nudEnter3.Value = (decimal)mf.seq.seqEnter[3].distance;
            }

            if (mf.seq.seqEnter[4].function == 0)
            {
                cboxEnterFunc4.SelectedIndex = mf.seq.seqEnter[4].function;
                cboxEnterAction4.SelectedIndex = -1;
            }
            else
            {
                cboxEnterFunc4.SelectedIndex = mf.seq.seqEnter[4].function;
                cboxEnterAction4.SelectedIndex = mf.seq.seqEnter[4].action;
                nudEnter4.Value = (decimal)mf.seq.seqEnter[4].distance;
            }

            //Exit page

            if (mf.seq.seqExit[0].function == 0)
            {
                cboxExitFunc0.SelectedIndex = mf.seq.seqExit[0].function;
                cboxExitAction0.SelectedIndex = -1;
            }
            else
            {
                cboxExitFunc0.SelectedIndex = mf.seq.seqExit[0].function;
                cboxExitAction0.SelectedIndex = mf.seq.seqExit[0].action;
                nudExit0.Value = (decimal)mf.seq.seqExit[0].distance;
            }

            if (mf.seq.seqExit[1].function == 0)
            {
                cboxExitFunc1.SelectedIndex = mf.seq.seqExit[1].function;
                cboxExitAction1.SelectedIndex = -1;
            }
            else
            {
                cboxExitFunc1.SelectedIndex = mf.seq.seqExit[1].function;
                cboxExitAction1.SelectedIndex = mf.seq.seqExit[1].action;
                nudExit1.Value = (decimal)mf.seq.seqExit[1].distance;
            }

            if (mf.seq.seqExit[2].function == 0)
            {
                cboxExitFunc2.SelectedIndex = mf.seq.seqExit[2].function;
                cboxExitAction2.SelectedIndex = -1;
            }
            else
            {
                cboxExitFunc2.SelectedIndex = mf.seq.seqExit[2].function;
                cboxExitAction2.SelectedIndex = mf.seq.seqExit[2].action;
                nudExit2.Value = (decimal)mf.seq.seqExit[2].distance;
            }

            if (mf.seq.seqExit[3].function == 0)
            {
                cboxExitFunc3.SelectedIndex = mf.seq.seqExit[3].function;
                cboxExitAction3.SelectedIndex = -1;
            }
            else
            {
                cboxExitFunc3.SelectedIndex = mf.seq.seqExit[3].function;
                cboxExitAction3.SelectedIndex = mf.seq.seqExit[3].action;
                nudExit3.Value = (decimal)mf.seq.seqExit[3].distance;
            }

            if (mf.seq.seqExit[4].function == 0)
            {
                cboxExitFunc4.SelectedIndex = mf.seq.seqExit[4].function;
                cboxExitAction4.SelectedIndex = -1;
            }
            else
            {
                cboxExitFunc4.SelectedIndex = mf.seq.seqExit[4].function;
                cboxExitAction4.SelectedIndex = mf.seq.seqExit[4].action;
                nudExit4.Value = (decimal)mf.seq.seqExit[4].distance;
            }
        }

        private void SaveSequences()
        {
            //first the entry save
            if (cboxEnterFunc0.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(0, true);
            }
            else
            {
                mf.seq.seqEnter[0].function = cboxEnterFunc0.SelectedIndex;
                mf.seq.seqEnter[0].action = cboxEnterAction0.SelectedIndex;
                mf.seq.seqEnter[0].isTrig = false;
                mf.seq.seqEnter[0].distance = (int)nudEnter0.Value;
            }

            if (cboxEnterFunc1.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(1, true);
            }
            else
            {
                mf.seq.seqEnter[1].function = cboxEnterFunc1.SelectedIndex;
                mf.seq.seqEnter[1].action = cboxEnterAction1.SelectedIndex;
                mf.seq.seqEnter[1].isTrig = false;
                mf.seq.seqEnter[1].distance = (int)nudEnter1.Value;
            }

            if (cboxEnterFunc2.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(2, true);
            }
            else
            {
                mf.seq.seqEnter[2].function = cboxEnterFunc2.SelectedIndex;
                mf.seq.seqEnter[2].action = cboxEnterAction2.SelectedIndex;
                mf.seq.seqEnter[2].isTrig = false;
                mf.seq.seqEnter[2].distance = (int)nudEnter2.Value;
            }

            if (cboxEnterFunc3.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(3, true);
            }
            else
            {
                mf.seq.seqEnter[3].function = cboxEnterFunc3.SelectedIndex;
                mf.seq.seqEnter[3].action = cboxEnterAction3.SelectedIndex;
                mf.seq.seqEnter[3].isTrig = false;
                mf.seq.seqEnter[3].distance = (int)nudEnter3.Value;
            }

            if (cboxEnterFunc4.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(4, true);
            }
            else
            {
                mf.seq.seqEnter[4].function = cboxEnterFunc4.SelectedIndex;
                mf.seq.seqEnter[4].action = cboxEnterAction4.SelectedIndex;
                mf.seq.seqEnter[4].isTrig = false;
                mf.seq.seqEnter[4].distance = (int)nudEnter4.Value;
            }

            //save the exit fields
            if (cboxExitFunc0.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(0, false);
            }
            else
            {
                mf.seq.seqExit[0].function = cboxExitFunc0.SelectedIndex;
                mf.seq.seqExit[0].action = cboxExitAction0.SelectedIndex;
                mf.seq.seqExit[0].isTrig = false;
                mf.seq.seqExit[0].distance = (int)nudExit0.Value;
            }

            if (cboxExitFunc1.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(1, false);
            }
            else
            {
                mf.seq.seqExit[1].function = cboxExitFunc1.SelectedIndex;
                mf.seq.seqExit[1].action = cboxExitAction1.SelectedIndex;
                mf.seq.seqExit[1].isTrig = false;
                mf.seq.seqExit[1].distance = (int)nudExit1.Value;
            }

            if (cboxExitFunc2.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(2, false);
            }
            else
            {
                mf.seq.seqExit[2].function = cboxExitFunc2.SelectedIndex;
                mf.seq.seqExit[2].action = cboxExitAction2.SelectedIndex;
                mf.seq.seqExit[2].isTrig = false;
                mf.seq.seqExit[2].distance = (int)nudExit2.Value;
            }

            if (cboxExitFunc3.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(3, false);
            }
            else
            {
                mf.seq.seqExit[3].function = cboxExitFunc3.SelectedIndex;
                mf.seq.seqExit[3].action = cboxExitAction3.SelectedIndex;
                mf.seq.seqExit[3].isTrig = false;
                mf.seq.seqExit[3].distance = (int)nudExit3.Value;
            }

            if (cboxExitFunc4.SelectedIndex == 0)
            {
                mf.seq.DisableSeqEvent(4, false);
            }
            else
            {
                mf.seq.seqExit[4].function = cboxExitFunc4.SelectedIndex;
                mf.seq.seqExit[4].action = cboxExitAction4.SelectedIndex;
                mf.seq.seqExit[4].isTrig = false;
                mf.seq.seqExit[4].distance = (int)nudExit4.Value;
            }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            //save all the sequences and events
            SaveSequences();

            Properties.Vehicle.Default.set_youSkipHeight = mf.yt.rowSkipsHeight;
            Properties.Vehicle.Default.set_youSkipWidth = mf.yt.rowSkipsWidth;

            Properties.Vehicle.Default.set_youStartYouTurnAt = mf.yt.youTurnStartOffset;

            StringBuilder sbEntry = new StringBuilder();
            StringBuilder sbExit = new StringBuilder();

            //Sequence functions 0,0,0,0,0
            for (int i = 0; i < FormGPS.MAXFUNCTIONS-1; i++)
            {
                sbEntry.Append(mf.seq.seqEnter[i].function.ToString());
                sbEntry.Append(",");
                sbExit.Append(mf.seq.seqExit[i].function.ToString());
                sbExit.Append(",");
            }
            sbEntry.Append(mf.seq.seqEnter[FormGPS.MAXFUNCTIONS - 1].function.ToString());
            sbExit.Append(mf.seq.seqExit[FormGPS.MAXFUNCTIONS - 1].function.ToString());

            Properties.Vehicle.Default.seq_FunctionEnter = sbEntry.ToString();
            Properties.Vehicle.Default.seq_FunctionExit = sbExit.ToString();
            sbEntry.Clear(); sbExit.Clear();

            //Sequence actions
            for (int i = 0; i < FormGPS.MAXFUNCTIONS-1; i++)
            {
                sbEntry.Append(mf.seq.seqEnter[i].action.ToString());
                sbEntry.Append(",");
                sbExit.Append(mf.seq.seqExit[i].action.ToString());
                sbExit.Append(",");
            }
            sbEntry.Append(mf.seq.seqEnter[FormGPS.MAXFUNCTIONS - 1].action.ToString());
            sbExit.Append(mf.seq.seqExit[FormGPS.MAXFUNCTIONS - 1].action.ToString());

            Properties.Vehicle.Default.seq_ActionEnter = sbEntry.ToString();
            Properties.Vehicle.Default.seq_ActionExit = sbExit.ToString();
            sbEntry.Clear(); sbExit.Clear();

            //Sequence Distances
            for (int i = 0; i < FormGPS.MAXFUNCTIONS-1; i++)
            {
                sbEntry.Append(mf.seq.seqEnter[i].distance.ToString());
                sbEntry.Append(",");
                sbExit.Append(mf.seq.seqExit[i].distance.ToString());
                sbExit.Append(",");
            }
            sbEntry.Append(mf.seq.seqEnter[FormGPS.MAXFUNCTIONS - 1].distance.ToString());
            sbExit.Append(mf.seq.seqExit[FormGPS.MAXFUNCTIONS - 1].distance.ToString());

            Properties.Vehicle.Default.seq_DistanceEnter = sbEntry.ToString();
            Properties.Vehicle.Default.seq_DistanceExit = sbExit.ToString();

            //save it all
            Properties.Vehicle.Default.Save();
            Close();
        }

        #region YouTurn

        // YouTurn Tab
        private void btnDistanceDn_Click(object sender, EventArgs e)
        {
            if (mf.yt.youTurnStartOffset-- < -48) mf.yt.youTurnStartOffset = -49;
            lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
            if (mf.yt.youTurnStartOffset < 0) lblWhenTrig.Text = "Before";
            else lblWhenTrig.Text = "After";
        }

        private void btnDistanceUp_Click(object sender, EventArgs e)
        {
            if (mf.yt.youTurnStartOffset++ > 49) mf.yt.youTurnStartOffset = 50;
            lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
            if (mf.yt.youTurnStartOffset < 0) lblWhenTrig.Text = "Before";
            else lblWhenTrig.Text = "After";
        }

        private void btnYouTurnKeyHole_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\KeyHole.txt");
            Properties.Settings.Default.setAS_youTurnShape = "KeyHole.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.Yellow;
            btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
            btnYouTurnCustom.BackColor = Color.LimeGreen;
            btnYouTurnWideReturn.BackColor = Color.LimeGreen;
        }

        private void btnYouTurnSemiCircle_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\SemiCircle.txt");
            Properties.Settings.Default.setAS_youTurnShape = "SemiCircle.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.LimeGreen;
            btnYouTurnSemiCircle.BackColor = Color.Yellow;
            btnYouTurnCustom.BackColor = Color.LimeGreen;
            btnYouTurnWideReturn.BackColor = Color.LimeGreen;
        }

        private void btnYouTurnWideReturn_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\WideReturn.txt");
            Properties.Settings.Default.setAS_youTurnShape = "WideReturn.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.LimeGreen;
            btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
            btnYouTurnCustom.BackColor = Color.LimeGreen;
            btnYouTurnWideReturn.BackColor = Color.Yellow;
        }

        private void btnYouTurnCustom_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\YouTurnShapes\Custom.txt");
            Properties.Settings.Default.setAS_youTurnShape = "Custom.txt";
            Properties.Settings.Default.Save();
            btnYouTurnKeyHole.BackColor = Color.LimeGreen;
            btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
            btnYouTurnCustom.BackColor = Color.Yellow;
            btnYouTurnWideReturn.BackColor = Color.LimeGreen;
        }

        private void btnYouTurnRecord_Click(object sender, EventArgs e)
        {
            if (mf.ABLine.isABLineSet)
            {
                var form = new FormYouTurnRecord(mf);
                form.Show();
                Close();
            }
            else { mf.TimedMessageBox(3000, "No AB Lines", "Start AB Line Guidance"); }
        }

        private void cboxRowWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.yt.rowSkipsWidth = cboxRowWidth.SelectedIndex + 1;
        }

        private void cboxRowHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.yt.rowSkipsHeight = cboxRowHeight.SelectedIndex + 1;
        }

        #endregion Youturn

        #region Sequence select

        private void cboxEnterFunc0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEnterFunc0.SelectedIndex == 0)
            {
                cboxEnterAction0.SelectedIndex = -1;
                nudEnter0.Value = 0;
            }
        }

        private void cboxEnterFunc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEnterFunc1.SelectedIndex == 0)
            {
                cboxEnterAction1.SelectedIndex = -1;
                nudEnter1.Value = 0;
            }
        }

        private void cboxEnterFunc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEnterFunc2.SelectedIndex == 0)
            {
                cboxEnterAction2.SelectedIndex = -1;
                nudEnter2.Value = 0;
            }
        }

        private void cboxEnterFunc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEnterFunc3.SelectedIndex == 0)
            {
                cboxEnterAction3.SelectedIndex = -1;
                nudEnter3.Value = 0;
            }
        }

        private void cboxEnterFunc4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEnterFunc4.SelectedIndex == 0)
            {
                cboxEnterAction4.SelectedIndex = -1;
                nudEnter4.Value = 0;
            }
        }

        private void cboxExitFunc0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExitFunc0.SelectedIndex == 0)
            {
                cboxExitAction0.SelectedIndex = -1;
                nudExit0.Value = 0;
            }
        }

        private void cboxExitFunc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExitFunc1.SelectedIndex == 0)
            {
                cboxExitAction1.SelectedIndex = -1;
                nudExit1.Value = 0;
            }
        }

        private void cboxExitFunc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExitFunc2.SelectedIndex == 0)
            {
                cboxExitAction2.SelectedIndex = -1;
                nudExit2.Value = 0;
            }
        }

        private void cboxExitFunc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExitFunc3.SelectedIndex == 0)
            {
                cboxExitAction3.SelectedIndex = -1;
                nudExit3.Value = 0;
            }
        }

        private void cboxExitFunc4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExitFunc4.SelectedIndex == 0)
            {
                cboxExitAction4.SelectedIndex = -1;
                nudExit4.Value = 0;
            }
        }

        #endregion Sequence select

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            mf.seq.ResetAllSequences();
            PopulateSequencePages();
        }

    }
}
