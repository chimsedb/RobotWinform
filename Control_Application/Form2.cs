using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Control_Application
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        int count = 0;
        //SerialPort serialPort;

        public Form2()
        {
            InitializeComponent();
        }

        //private void init()
        //{
        //    serialPort = new SerialPort();
        //    serialPort.PortName = "COM3";
        //    serialPort.BaudRate = 9600;


        //    try
        //    {
        //        serialPort.Open();

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);

        //    }

        //}

        private void button_save_click(object sender, EventArgs e)
        {

            exec_function_save();
        }

        private void listview_item_x2click(object sender, MouseEventArgs e)
        {
            exec_function_run();
        }

        private void btn_remove_click(object sender, EventArgs e)
        {
            listViewRadius.Items.Remove(listViewRadius.SelectedItems[0]);
            count--;
        }

        private void button_run_click(object sender, EventArgs e)
        {
            exec_function_run();
        }

        private int[] getValueRadius(string value_radius_1, string value_radius_2, string value_radius_3, string value_radius_4)
        {
            int[] value_raduis = { int.Parse(value_radius_1), int.Parse(value_radius_2), int.Parse(value_radius_3), int.Parse(value_radius_4) };
            return value_raduis;
        }


        private void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private bool checkNullValueTextbox()
        {
            if (int.TryParse(textBox1.Text, out int box1)
                && int.TryParse(textBox2.Text, out int box2)
                && int.TryParse(textBox4.Text, out int box3)
                && int.TryParse(textBox3.Text, out int box4))
            {
                return true;
            }
            return false;
        }

        private bool checkValueRadius(int value_radius_1, int value_radius_2, int value_radius_3, int value_radius_4)
        {
            if (value_radius_1 >= 0 && value_radius_1 <= 180
                    && value_radius_2 >= 0 && value_radius_2 <= 180
                    && value_radius_3 >= 0 && value_radius_3 <= 180
                    && value_radius_4 >= 0 && value_radius_4 <= 180)
            {
                return true;
            }
            return false;
        }

        private void SendServoInfo(int channel, int pos)
        {
            string message = channel.ToString() + ':' + pos.ToString() + '*';

            try
            {
                Form1.serialPort.Write(message);
                
            }
            catch
            {

            }

        }
        private void exec_function_run()
        {
            
            if (listViewRadius.SelectedItems.Count > 0)
            {
                var item = listViewRadius.SelectedItems[0];
                int[] value_raduis = getValueRadius(item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text);

                if (Form1.serialPort.IsOpen)
                {

                    for (int i = 0; i < value_raduis.Length; i++)
                    {
                        SendServoInfo(i, value_raduis[i]);
                        Thread.Sleep(500);
                    }
                }
                else
                {
                    MessageBox.Show(value_raduis[0]+ value_raduis[1] + value_raduis[2] + value_raduis[3] +"");
                }

            }
            else
            {
                MessageBox.Show("Please add value for the list to use this function @@");
            }
        }

        private void exec_function_save()
        {
            if (checkNullValueTextbox())
            {
                int value_radius_1 = int.Parse(textBox1.Text);
                int value_radius_2 = int.Parse(textBox2.Text);
                int value_radius_3 = int.Parse(textBox3.Text);
                int value_radius_4 = int.Parse(textBox4.Text);

                if (checkValueRadius(value_radius_1, value_radius_2, value_radius_3, value_radius_4))
                {
                    ListViewItem item = new ListViewItem();
                    count++;
                    item.Text = count + "";
                    item.SubItems.Add(textBoxDescription.Text);
                    item.SubItems.Add(value_radius_1 + "");
                    item.SubItems.Add(value_radius_2 + "");
                    item.SubItems.Add(value_radius_3 + "");
                    item.SubItems.Add(value_radius_4 + "");
                    listViewRadius.Items.Add(item);
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("Value input from 0 to 180 . Please try again !");
                    clearTextBox();
                }
            }
            else
            {
                MessageBox.Show("Input value must be number and not empty . Please try again !");
                clearTextBox();
            }
        }

      
    }
}
