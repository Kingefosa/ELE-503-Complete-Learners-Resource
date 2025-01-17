using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Slide_4___Developing_a_Control_System_Interface
{

   // Step 3: Implementing Control Logic



    public partial class MainForm : Form
    {

        private MotorController motor;

        public MainForm()
        {
            InitializeComponent();
            motor = new MotorController();
        }


    

        private void btnStart_Click(object sender, EventArgs e)
        {
            motor.Start();
            lblStatus.Text = "Motor Running";
            lblStatus2.Text = "Motor Running";
        }

        //private void btnStop_Click(object sender, EventArgs e)
        //{
        //    motor.Stop();
        //    lblStatus.Text = "Motor Stopped";
        //    lblStatus2.Text = "Motor Stopped";
        //}

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            motor.Stop();
            lblStatus.Text = "Motor Stopped";
            lblStatus2.Text = "Motor Stopped";

        }
    }



    // Step 4: Creating the MotorController Class

    public class MotorController
{
    public void Start()
    {
        // Implement motor start logic
        Console.WriteLine("Motor started.");
    }

    public void Stop()
    {
        // Implement motor stop logic
        Console.WriteLine("Motor stopped.");
    }
}

}