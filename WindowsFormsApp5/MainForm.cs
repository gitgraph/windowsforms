using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    /*
   * Name: David Anderberg
   * Date: 21-12-31
   */
    public partial class MainForm : Form
    {



        private TimerManager timerManager;
        private string fileName = Application.StartupPath + "\\Timers.txt";

        private int paused = 0;


        /// <summary>
        /// Constructor for MainForm class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }


        /// <summary>
        /// Initialize the GUI of the form
        /// </summary>
        private void InitializeGUI()
        {

            this.Text = "KitchenTimer by David A.";

            timerManager = new TimerManager();

            listBox1Timers.Items.Clear();


            textBox3Description.Text = string.Empty;

            label4Timer.Text = "00:00";

            textBox1Minute.Text = "00";
            textBox2Second.Text = "00";

            paused = 0;
            button2Pause.Text = "Pause";


            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(button1Start, "Start timer");
            toolTip1.SetToolTip(button2Pause, "Pause/Resume");
            toolTip1.SetToolTip(button3Stop, "Stop timer");
            toolTip1.SetToolTip(button4Delete, "Delete timer");

            toolTip1.SetToolTip(button5Plus, "Increase minute");
            toolTip1.SetToolTip(button6Minus, "Decrease minute");




            timer1.Start();


            button3Stop.Enabled = false;
            button4Delete.Enabled = false;

        }


        /// <summary>
        /// Update the GUI listBox
        /// </summary>
        private void UpdateGUI()
        {
            listBox1Timers.Items.Clear();

            string[] infoString = timerManager.GetKitchenTimerStringsList();

            if (infoString != null && infoString.Length > 0)
                listBox1Timers.Items.AddRange(infoString);


            if (timerManager.CheckIndex(timerManager.CurrentIndex))
                listBox1Timers.SelectedIndex = timerManager.CurrentIndex;

        }




        /// <summary>
        /// Button click event for the Start timer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Start_Click(object sender, EventArgs e)
        {
            // Start/Set timer

            string minutesText = textBox1Minute.Text;
            string secondsText = textBox2Second.Text;


            int minutes;

            bool tParseMin = int.TryParse(minutesText, out minutes);

            int seconds;

            bool tParseSec = int.TryParse(secondsText, out seconds);


            string description = textBox3Description.Text;

            if (tParseMin && tParseSec)
            {

                if (minutes > 0 || seconds > 0)
                {

                    KitchenTimer kitchenTimer = new KitchenTimer();

                    kitchenTimer.SetMinutes = minutes;
                    kitchenTimer.SetSeconds = seconds;

                    kitchenTimer.StartMinute = minutes;
                    kitchenTimer.StartSecond = seconds;



                    kitchenTimer.Count = timerManager.CurrentCount;

                    kitchenTimer.Description = description;

                    kitchenTimer.TimerStatus = TimerStatus.Running;

                    timerManager.SetTimer(kitchenTimer);


                    UpdateGUI();


                }

            }

        }





        /// <summary>
        /// Timer tick event that updates every second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // tick event

            timerManager.CurrentCount += 1;

       
            timerManager.UpdateTimers();


            if (timerManager.CurrentIndex != -1)
            {
                label4Timer.Text = timerManager.GetTimerText(timerManager.CurrentIndex);

                if (timerManager.CheckIndex(timerManager.CurrentIndex))
                    listBox1Timers.SelectedIndex = timerManager.CurrentIndex;
            }
            else
            {
                label4Timer.Text = "00:00";

            }

            UpdateGUI();



            for (int index = 0; index < timerManager.GetListLength(); index++)
            {

                if (timerManager.GetTimer(index).TimerStatus == TimerStatus.Finished && timerManager.GetTimer(index).Finished)
                {
                    timerManager.GetTimer(index).Finished = false;

                    string message = String.Format("Timer {0}:{1} is finished",
                        timerManager.GetTimer(index).StartMinute.ToString("00"), timerManager.GetTimer(index).StartSecond.ToString("00"));


                    DialogResult dialogResult = MessageBox.Show(message, "Timer Finished", MessageBoxButtons.OK); 

                    if (dialogResult == DialogResult.OK)
                    {

                    }


                }

            }


        }


        /// <summary>
        /// ListBox selected index changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listBox1Timers.SelectedIndex;


            timerManager.CurrentIndex = index;


            label4Timer.Text = timerManager.GetTimerText(timerManager.CurrentIndex);


            if (index != -1 &&
                (timerManager.GetTimer(timerManager.CurrentIndex).TimerStatus != TimerStatus.Stopped
                || timerManager.GetTimer(timerManager.CurrentIndex).TimerStatus != TimerStatus.Finished))
            {
                button2Pause.Enabled = true;

            }
            else
            {
                button2Pause.Enabled = false;
            }


            if (timerManager.CurrentIndex != -1)
            {

                KitchenTimer kitchenTimer = timerManager.GetTimer(timerManager.CurrentIndex);

                if (kitchenTimer != null)
                {


                    switch (kitchenTimer.TimerStatus)
                    {
                        case TimerStatus.Running:
                            button2Pause.Text = "Pause";
                            paused = 0;

                            button3Stop.Enabled = false;
                            button4Delete.Enabled = false;
                            break;

                        case TimerStatus.Paused:
                            button2Pause.Text = "Resume";
                            paused = 1;

                            button3Stop.Enabled = true;
                            break;

                        case TimerStatus.Stopped:

                            button3Stop.Enabled = false;
                            button2Pause.Enabled = false;

                            button4Delete.Enabled = true;

                            break;

                        case TimerStatus.Finished:

                            button3Stop.Enabled = false;
                            button2Pause.Enabled = false;

                            button4Delete.Enabled = true;
                            break;

                    }

                }

            }


        }





        /// <summary>
        /// Button click event for the Pause/Resume button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2Pause_Click(object sender, EventArgs e)
        {
            // pause/resume

            if (listBox1Timers.SelectedIndex != -1)
            {

                if (paused == 0)
                {
                    timerManager.PauseTimer(timerManager.CurrentIndex);

                    button3Stop.Enabled = true;

                    button2Pause.Text = "Resume";



                    paused = 1;
                }
                else if (paused == 1)
                {
                    timerManager.ResumeTimer(timerManager.CurrentIndex);

                    button3Stop.Enabled = false;

                    button2Pause.Text = "Pause";
                    paused = 0;
                }


                UpdateGUI();

            }

        }


        /// <summary>
        /// Button click event for the Stop button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3Stop_Click(object sender, EventArgs e)
        {
            // stop

            button2Pause.Enabled = false;

            button4Delete.Enabled = true;

            timerManager.StopTimer();

            
        }

        /// <summary>
        /// Button click event for the Delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4Delete_Click(object sender, EventArgs e)
        {
            // delete
            if (timerManager.CheckIndex(timerManager.CurrentIndex))
                timerManager.DeleteTimer(timerManager.CurrentIndex);

            button4Delete.Enabled = false;

        }



        /// <summary>
        /// Button click event for the Plus button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5Plus_Click(object sender, EventArgs e)
        {
            // plus

            timerManager.PlusMinute(timerManager.CurrentIndex);

        }

        /// <summary>
        /// Button click event for the Minus button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6Minus_Click(object sender, EventArgs e)
        {
            // minus

            timerManager.MinusMinute(timerManager.CurrentIndex);

        }


        /// <summary>
        /// Menu item click event for the New button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();

        }


        /// <summary>
        /// Menu item click event for the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("All kitchen timers will be paused. Do you want to continue?", "Save", MessageBoxButtons.YesNo); ;

            if (dialogResult == DialogResult.Yes)
            {

                timerManager.PauseTimers();

                string errorMessage = "Something went wrong while saving data to file.";

                bool value = timerManager.WriteDataToFile(fileName);

                if (!value)
                    MessageBox.Show(errorMessage);
                else
                    MessageBox.Show("Data saved to file: " + Environment.NewLine + fileName);


            }
            else if (dialogResult == DialogResult.No)
            {

            }


           
        }


        /// <summary>
        /// Menu item click event for the Open button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errorMessage = "Something went wrong when opening the file.";

            bool value = timerManager.ReadDataFromFile(fileName);

            if (!value)
                MessageBox.Show(errorMessage);
            else
                UpdateGUI();

        }


        /// <summary>
        /// Menu item click event for the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit KitchenTimer. Are you sure?", "Exit", MessageBoxButtons.OKCancel); ;

            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }

        }

        /// <summary>
        /// Menu item click event for the About button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            DialogResult dialogResult = aboutBox.ShowDialog();

        }

       
    }
}
