using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Control_Application
{
    
    public partial class Form1 : System.Windows.Forms.Form
    {
        public static SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;


            try
            {
                serialPort.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            ResetServos();

        }
        
        private void trackBarServo_0_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_0.Value;
            //openSerialPort();
            if (serialPort.IsOpen)
            {
                labelServoPos_0.Text = "Position: " + servoPos.ToString();
                SendServoInfo(0, servoPos);

            }
            

        }

        //private void openSerialPort()
        //{
        //    if (!serialPort.IsOpen)
        //    {
        //        init();
        //        MessageBox.Show("đâs");
        //    }
        //}

        private void trackBarServo_1_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_1.Value;
            //openSerialPort();
            if (serialPort.IsOpen)
            {
                labelServoPos_1.Text = "Position: " + servoPos.ToString();
                SendServoInfo(1, servoPos);

            }
            

        }

        private void trackBarServo_2_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_2.Value;
            //openSerialPort();
            if (serialPort.IsOpen)
            {
                labelServoPos_2.Text = "Position: " + servoPos.ToString();
                SendServoInfo(2, servoPos);

            }
            

        }

        private void trackBarServo_3_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_3.Value;
            //openSerialPort();
            if (serialPort.IsOpen)
            {
                labelServoPos_3.Text = "Position: " + servoPos.ToString();
                SendServoInfo(3, servoPos);

            }
            

        }

        private void SendServoInfo(int channel, int pos)
        {
            string message = channel.ToString() + ':' + pos.ToString() + '*';

            try
            {
                serialPort.Write(message);

            }
            catch
            {

            }

        }

        private void ResetServos()
        {
            int centrePosition = 90;
            trackBarServo_0.Value = centrePosition;
            trackBarServo_1.Value = centrePosition;
            trackBarServo_2.Value = centrePosition;
            trackBarServo_3.Value = centrePosition;

            labelServoPos_0.Text = "Position: " + centrePosition.ToString();
            labelServoPos_1.Text = "Position: " + centrePosition.ToString();
            labelServoPos_2.Text = "Position: " + centrePosition.ToString();
            labelServoPos_3.Text = "Position: " + centrePosition.ToString();

            for (int channel = 0; channel < 4; channel++)
            {
                SendServoInfo(channel, centrePosition);
            }

        }

        private void buttonResetServos_Click(object sender, EventArgs e)
        {
            ResetServos();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetServos();

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //serialPort.Close();
        }

    }

}
