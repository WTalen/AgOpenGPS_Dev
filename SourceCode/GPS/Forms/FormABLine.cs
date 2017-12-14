//Please, if you use this, share the improvements

using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormABLine : Form
    {
        //access to the main GPS form and all its variables
        private readonly FormGPS mf = null;

        private double upDnHeading = 0;

        //the abline stored file
        string filename = "";

        public FormABLine(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;

            InitializeComponent();
        }

        private void FormABLine_Load(object sender, EventArgs e)
        {
            //different start based on AB line already set or not
            if (mf.ABLine.isABLineSet)
            {
                //AB line is on screen and set
                btnAPoint.Enabled = false;
                btnBPoint.Enabled = true;
                btnABLineOk.Enabled = true;
                btnDeleteAB.Enabled = true;
                btnUpABHeading.Enabled = true;
                btnDnABHeading.Enabled = true;
                btnUpABHeadingBy1.Enabled = true;
                btnDnABHeadingBy1.Enabled = true;
                upDnHeading = Math.Round(glm.toDegrees(mf.ABLine.abHeading), 1);
                nudTramRepeats.Value = mf.ABLine.tramPassEvery;
                nudBasedOnPass.Value = mf.ABLine.passBasedOn;
                tboxHeading.Text = upDnHeading.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                //no AB line
                btnAPoint.Enabled = true;
                btnBPoint.Enabled = false;
                btnDeleteAB.Enabled = true;
                btnABLineOk.Enabled = false;
                btnUpABHeading.Enabled = false;
                btnDnABHeading.Enabled = false;
                btnUpABHeadingBy1.Enabled = false;
                btnDnABHeadingBy1.Enabled = false;
                upDnHeading = Math.Round(glm.toDegrees(mf.fixHeading), 1);
                nudTramRepeats.Value = 0;
                nudBasedOnPass.Value = 0;
                mf.ABLine.tramPassEvery=0;
                mf.ABLine.passBasedOn=0;
            }

            //make sure at least a blank AB Line file exists
            string dirABLines = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString(CultureInfo.InvariantCulture) + "\\AgOpenGPS\\ABLines\\";
            string directoryName = Path.GetDirectoryName(dirABLines).ToString(CultureInfo.InvariantCulture);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }
            filename = directoryName + "\\ABLines.txt";
            if (!File.Exists(filename))
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    //writer.WriteLine(DateTime.Now.ToString("MMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                }
            }

        }

        private void btnAPoint_Click(object sender, EventArgs e)
        {
            mf.ABLine.refPoint1.easting = mf.prevFix.easting;
            mf.ABLine.refPoint1.northing = mf.prevFix.northing;
            //Console.WriteLine(mf.ABLine.refPoint1.easting);
            //Console.WriteLine(mf.ABLine.refPoint1.northing);
            btnAPoint.Enabled = false;
            btnUpABHeading.Enabled = true;
            btnDnABHeading.Enabled = true;
            btnUpABHeadingBy1.Enabled = true;
            btnDnABHeadingBy1.Enabled = true;
            upDnHeading = Math.Round(glm.toDegrees(mf.fixHeading), 1);
            tboxHeading.Text = upDnHeading.ToString(CultureInfo.InvariantCulture);
        }

        private void btnBPoint_Click(object sender, EventArgs e)
        {
            mf.ABLine.SetABLineByBPoint();
            btnABLineOk.Enabled = true;
            btnDeleteAB.Enabled = true;
            upDnHeading = Math.Round(glm.toDegrees(mf.fixHeading), 1);
            tboxHeading.Text = upDnHeading.ToString(CultureInfo.InvariantCulture);
        }

        private void btnUpABHeading_Click(object sender, EventArgs e)
        {
            if ((upDnHeading += 10) > 359.9) upDnHeading = 0;
            upDnHeading = (int)upDnHeading;
            tboxHeading.Text = Convert.ToString(upDnHeading,CultureInfo.InvariantCulture);
            mf.ABLine.abHeading = glm.toRadians(upDnHeading);
            mf.ABLine.SetABLineByHeading();
            btnABLineOk.Enabled = true;
        }

        private void btnDownABHeading_Click(object sender, EventArgs e)
        {
            if ((upDnHeading -= 10) < 0) upDnHeading = 350;
            upDnHeading = (int)upDnHeading;
            tboxHeading.Text = Convert.ToString(upDnHeading, CultureInfo.InvariantCulture);
            mf.ABLine.abHeading = glm.toRadians(upDnHeading);
            mf.ABLine.SetABLineByHeading();
            btnABLineOk.Enabled = true;
        }

        private void btnUpABHeadingBy1_Click(object sender, EventArgs e)
        {
            if ((upDnHeading++) > 358) upDnHeading = 0;
            upDnHeading = (int)upDnHeading;
            tboxHeading.Text = Convert.ToString(upDnHeading, CultureInfo.InvariantCulture);
            mf.ABLine.abHeading = glm.toRadians(upDnHeading);
            mf.ABLine.SetABLineByHeading();
            btnABLineOk.Enabled = true;
        }

        private void btnDnABHeadingBy1_Click(object sender, EventArgs e)
        {
            upDnHeading--;
            if (upDnHeading < 0 ) upDnHeading = 359;
            upDnHeading = (int)upDnHeading;
            tboxHeading.Text = Convert.ToString(upDnHeading, CultureInfo.InvariantCulture);
            mf.ABLine.abHeading = glm.toRadians(upDnHeading);
            mf.ABLine.SetABLineByHeading();
            btnABLineOk.Enabled = true;
        }

        private void btnABLineOk_Click(object sender, EventArgs e)
        {
            //save the ABLine
            mf.FileSaveABLine();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDeleteAB_Click(object sender, EventArgs e)
        {
            mf.ABLine.DeleteAB();
            btnAPoint.Enabled = true;
            btnBPoint.Enabled = false;
            btnDeleteAB.Enabled = false;
            btnABLineOk.Enabled = false;
            nudTramRepeats.Value = 0;
            nudBasedOnPass.Value = 0;
            mf.ABLine.tramPassEvery = 0;
            mf.ABLine.passBasedOn = 0;

            //save the no ABLine;
            mf.FileSaveABLine();

            DialogResult = DialogResult.Cancel;
            Close();
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFixHeading.Text = Convert.ToString( Math.Round(glm.toDegrees(mf.fixHeading), 1)) + "°";
            lblABHeading.Text = Convert.ToString(upDnHeading) + "°";
            lblKeepGoing.Text = "";

            //make sure we go at least 3 or so meters before allowing B reference point
            if (!btnAPoint.Enabled && !btnBPoint.Enabled)
            {
                double pointAToFixDistance =
                Math.Pow(mf.ABLine.refPoint1.easting - mf.pn.easting, 2)
                + Math.Pow(mf.ABLine.refPoint1.northing - mf.pn.northing, 2);

                if (pointAToFixDistance > 100) btnBPoint.Enabled = true;
                else lblKeepGoing.Text = "    Keep\r\n Going  " + Convert.ToInt16(100 - pointAToFixDistance).ToString();
            }
        }

        private void nudTramRepeats_ValueChanged(object sender, EventArgs e)
        {
            mf.ABLine.tramPassEvery = (int)nudTramRepeats.Value;
        }

        private void nudBasedOnPass_ValueChanged(object sender, EventArgs e)
        {
            mf.ABLine.passBasedOn = (int)nudBasedOnPass.Value;
        }

        private void btnLoadPrevious_Click(object sender, EventArgs e)
        {
            using (var form = new FormABPrev(mf))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    mf.FileSaveABLine();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnAddToFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filename,true))
            {
                //make it culture invariant
                string line = mf.currentFieldDirectory + ',' + (Math.Round(glm.toDegrees(mf.ABLine.abHeading), 8)).ToString(CultureInfo.InvariantCulture)
                +',' + (Math.Round(mf.ABLine.refPoint1.easting, 3)).ToString(CultureInfo.InvariantCulture)
                + ',' + (Math.Round(mf.ABLine.refPoint1.northing, 3)).ToString(CultureInfo.InvariantCulture);

                //write out to file
                writer.WriteLine(line);
            }
        }

        private void tboxHeading_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9.]", "");
            textboxSender.SelectionStart = cursorPosition;
            string line = tboxHeading.Text.Trim();
            if (line == "") line = "0";
            if (line == ".") line = "0";
            upDnHeading = double.Parse(line,CultureInfo.InvariantCulture);
            mf.ABLine.abHeading = glm.toRadians(upDnHeading);
            mf.ABLine.SetABLineByHeading();
            btnABLineOk.Enabled = true;


        }
    }
}
