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

        public Form2()
        {
            InitializeComponent();
        }


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

        private int[] getValueRadius(string value_radius_1
            , string value_radius_2
            , string value_radius_3
            , string value_radius_4
            , string value_radius_5
            , string value_radius_6)
        {
            int[] value_raduis = { int.Parse(value_radius_1)
                    , int.Parse(value_radius_2)
                    , int.Parse(value_radius_3)
                    , int.Parse(value_radius_4)
                    , int.Parse(value_radius_5)
                    , int.Parse(value_radius_6) };
            return value_raduis;
        }


        private void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private bool checkNullValueTextbox()
        {
            if (int.TryParse(textBox1.Text, out int box1)
                && int.TryParse(textBox2.Text, out int box2)
                && int.TryParse(textBox4.Text, out int box3)
                && int.TryParse(textBox3.Text, out int box4)
                && int.TryParse(textBox5.Text, out int box5)
                && int.TryParse(textBox6.Text, out int box6))
            {
                return true;
            }
            return false;
        }

        private bool checkValueRadius(int value_radius_1, int value_radius_2, int value_radius_3, int value_radius_4, int value_radius_5, int value_radius_6)
        {
            if (value_radius_1 >= 0 && value_radius_1 <= 180
                    && value_radius_2 >= 0 && value_radius_2 <= 180
                    && value_radius_3 >= 0 && value_radius_3 <= 180
                    && value_radius_4 >= 0 && value_radius_4 <= 180
                    && value_radius_5 >= 0 && value_radius_5 <= 180
                    && value_radius_6 >= 0 && value_radius_6 <= 180)
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
                var item = listViewRadius.SelectedItems;
                List<int[]> list_value_raduis = new List<int[]>();

                for (int i = 0; i < listViewRadius.SelectedItems.Count; i++)
                {
                    int[] value_raduis = getValueRadius(item[i].SubItems[1].Text
                    , item[i].SubItems[2].Text
                    , item[i].SubItems[3].Text
                    , item[i].SubItems[4].Text
                    , item[i].SubItems[5].Text
                    , item[i].SubItems[6].Text);
                    list_value_raduis.Add(value_raduis);
                }


                if (Form1.serialPort.IsOpen)
                {

                    for (int i = 0; i < list_value_raduis.Count; i++)
                    {
                        list_value_raduis.ToArray().GetValue(0);

                        for (int j = 0; j < list_value_raduis[i].Length; j++)
                        {
                            SendServoInfo(i, list_value_raduis[i][j]);
                            Thread.Sleep(500);
                        }
                    }
                }
                else
                {
                    //for (int i = 0; i < list_value_raduis.Count; i++)
                    //{
                    //    list_value_raduis.ToArray().GetValue(0);

                    //    for (int j = 0; j < list_value_raduis[i].Length; j++)
                    //    {
                    //        MessageBox.Show(list_value_raduis[i][j] +
                        
                    //    "");
                    //    }
                    //}
                    
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
                int value_radius_5 = int.Parse(textBox5.Text);
                int value_radius_6 = int.Parse(textBox6.Text);

                if (checkValueRadius(value_radius_1, value_radius_2, value_radius_3, value_radius_4, value_radius_5, value_radius_6))
                {
                    ListViewItem item = new ListViewItem();
                    count++;
                    item.Text = count + "";
                    item.SubItems.Add(value_radius_1 + "");
                    item.SubItems.Add(value_radius_2 + "");
                    item.SubItems.Add(value_radius_3 + "");
                    item.SubItems.Add(value_radius_4 + "");
                    item.SubItems.Add(value_radius_5 + "");
                    item.SubItems.Add(value_radius_6 + "");
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

        private void loop_click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBoxLoop.Text, out int loop))
            {
                for (int i = 0; i < int.Parse(textBoxLoop.Text); i++)
                {
                    exec_function_run();
                }
            }
            
        }
    }
}
