using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormABPrev : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        //the txt file of saved ab lines
        string filename;

        public FormABPrev(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;


            InitializeComponent();
        }

        private void FormABPrev_Load(object sender, EventArgs e)
        {
            //get the file of previous AB Lines
            string dirABLines = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString(CultureInfo.InvariantCulture) + "\\AgOpenGPS\\ABLines\\";
            string directoryName = Path.GetDirectoryName(dirABLines).ToString(CultureInfo.InvariantCulture);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            filename = directoryName + "\\ABLines.txt";

            if (!File.Exists(filename))
            {
                mf.TimedMessageBox(2000, "File Error", "Missing AB Line File, Critical Error");
            }
            else
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    try
                    {
                        string line;

                        //read all the lines
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            //string[] words = line.Split(',');
                            listboxLines.Items.Add(line);

                            //coords.easting = double.Parse(words[0], CultureInfo.InvariantCulture);
                            //coords.northing = double.Parse(words[1], CultureInfo.InvariantCulture);
                            //youFileList.Add(coords);
                        }
                    }
                    catch (Exception er)
                    {
                        var form = new FormTimedMessage(4000, "ABLine File is Corrupt", "Please delete it!!!");
                        form.Show();
                        mf.WriteErrorLog("FieldOpen, Loading ABLine, Corrupt ABLine File" + er);
                    }
                }
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //get the file of previous AB Lines
        //    string dirABLines = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString(CultureInfo.InvariantCulture) + "\\AgOpenGPS\\ABLines\\";
        //    string directoryName = Path.GetDirectoryName(dirABLines).ToString(CultureInfo.InvariantCulture);
        //    if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
        //    { Directory.CreateDirectory(directoryName); }

        //    filename = directoryName + "\\ABLines.txt";

        //    if (!File.Exists(filename))
        //    {
        //        using (StreamWriter writer = new StreamWriter(filename))
        //        {
        //            //Write out the date
        //            //writer.WriteLine(DateTime.Now.ToString("MMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
        //            writer.WriteLine(mf.currentFieldDirectory + "," +  tboxHeading + "," + tboxEasting + "," + tboxNorthing);
        //        }
        //    }
        //    else
        //    {
        //        using (StreamWriter writer = new StreamWriter(filename, true))
        //        {
        //            //Write out the date
        //            //writer.WriteLine(DateTime.Now.ToString("MMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
        //            writer.WriteLine(mf.currentFieldDirectory + "," + tboxHeading + "," + tboxEasting + "," + tboxNorthing);
        //        }
        //    }
        //}

        private void tboxEasting_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9.]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        private void tboxNorthing_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9.]", "");
            textboxSender.SelectionStart = cursorPosition;

        }

        private void tboxHeading_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9.]", "");
            textboxSender.SelectionStart = cursorPosition;

        }

        private void btnAddManualInput_Click(object sender, EventArgs e)
        {
            listboxLines.Items.Add(mf.currentFieldDirectory + "," + tboxHeading.Text.Trim().ToString(CultureInfo.InvariantCulture) + "," 
                                        + tboxEasting.Text.Trim().ToString(CultureInfo.InvariantCulture) + "," 
                                        + tboxNorthing.Text.Trim().ToString(CultureInfo.InvariantCulture));
            int itemsTotal = listboxLines.Items.Count;
            listboxLines.SelectedIndex = itemsTotal - 1;
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            int item = listboxLines.SelectedIndex;
            if (item < 0) return;
            else listboxLines.Items.RemoveAt(item);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveItemsToFile();
        }

        private void btnUseSelected_Click(object sender, EventArgs e)
        {
            int item = listboxLines.SelectedIndex;
            if (item < 0) return;

            string line = listboxLines.SelectedItem.ToString();
            string[] words = line.Split(',');
            double temp = double.Parse(words[1], CultureInfo.InvariantCulture);
            mf.ABLine.abHeading = glm.toRadians(temp);
            temp = double.Parse(words[2], CultureInfo.InvariantCulture);
            mf.ABLine.refPoint1.easting = temp;
            temp = double.Parse(words[3], CultureInfo.InvariantCulture);
            mf.ABLine.refPoint1.northing = temp;
            mf.ABLine.SetABLineByHeading();

            //can go back to Mainform without seeing ABLine form.
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void SaveItemsToFile()
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                //make it culture invariant
                int itemsTotal = listboxLines.Items.Count;
                string line;
                for (int i = 0; i < itemsTotal; i++)
                {
                    listboxLines.SelectedIndex = i;
                    line = listboxLines.SelectedItem.ToString();

                    //write out to file
                    writer.WriteLine(line);
                }
            }
        }
    }
}
