using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// author: Matt4499
// you may do whatever you want, besides claiming this code as your own, or selling this program for any amount of money.
namespace RollReminder
{
    public partial class Form1 : MaterialForm
    {
        int counter;
        int AutoRollCounter;
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance; //create a new materialskinmanager instance
            materialSkinManager.AddFormToManage(this); //add this form to the managed forms of materialskinmanager
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //set the theme to dark

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red600, Primary.Red400, Accent.Red700, TextShade.WHITE); //my special red theme
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            var TimeInMinutesText = materialSingleLineTextField1.Text;
            if(TimeInMinutesText == null)
            {
                MessageBox.Show("You did not input a valid number.");
                return;
            }
            counter = Convert.ToInt32(TimeSpan.FromMinutes(Convert.ToDouble(materialSingleLineTextField1.Text)).TotalSeconds);
            RollTimer.Interval = 1000;
            RollTimer.Start();
            TimeLeftLabel.Text = counter.ToString();

        }

        private void RollTimer_Tick(object sender, EventArgs e)
        {

            counter--;
            if(counter == 0)
            {
                RollTimer.Stop();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Roll", "Roll");
            }
            TimeLeftLabel.Text = counter.ToString() + " seconds";

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            RollTimer.Stop();
            TimeLeftLabel.Text = "NONE";
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you click start, you will have 5 seconds to go into the Discord window, and click in the text input area. It will then begin auto-rolling. The max rolls per hour is 13. It is recommended to actually set AutoRoll to 15-16 because some dont work due to lag.", "AutoRoll Help");
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            AutoRollCountdown.Enabled = true;
            AutoRollCountdown.Start();
            AutoRollCounter = 5;
        }

        private void AutoRollCountdown_Tick(object sender, EventArgs e)
        {
            AutoRollCounter--;
            if(AutoRollCounter == 0)
            {
                AutoRollCountdown.Stop();
                var AutoRollTextToType = AutoRollInputText.Text;
                int AutoRollTimesToType = Convert.ToInt32(AutoRollInputNumber.Text);
                for (var i = 0; i < AutoRollTimesToType; i += 1){
                    SendKeys.Send(AutoRollTextToType);
                    Thread.Sleep(50);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(1500);
                }
            }
        }
    }
}
