using System;

namespace Control_Application
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.listViewRadius = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Radius1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Radius2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Radius3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Radius4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDescription = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Raduis5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Raduis6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_loop = new System.Windows.Forms.Button();
            this.textBoxLoop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radius 3 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Radius 4 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(325, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(325, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(303, 151);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(95, 37);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(569, 467);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(95, 37);
            this.button_run.TabIndex = 9;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_click);
            // 
            // listViewRadius
            // 
            this.listViewRadius.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Radius1,
            this.Radius2,
            this.Radius3,
            this.Radius4,
            this.Raduis5,
            this.Raduis6});
            this.listViewRadius.FullRowSelect = true;
            this.listViewRadius.HideSelection = false;
            this.listViewRadius.Location = new System.Drawing.Point(31, 203);
            this.listViewRadius.Name = "listViewRadius";
            this.listViewRadius.Size = new System.Drawing.Size(633, 223);
            this.listViewRadius.TabIndex = 10;
            this.listViewRadius.UseCompatibleStateImageBehavior = false;
            this.listViewRadius.View = System.Windows.Forms.View.Details;
            this.listViewRadius.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_item_x2click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Radius1
            // 
            this.Radius1.Text = "Value Radius 1";
            this.Radius1.Width = 100;
            // 
            // Radius2
            // 
            this.Radius2.Text = "Value Radius 2";
            this.Radius2.Width = 100;
            // 
            // Radius3
            // 
            this.Radius3.Text = "Value Radius 3";
            this.Radius3.Width = 100;
            // 
            // Radius4
            // 
            this.Radius4.Text = "Value Radius 4";
            this.Radius4.Width = 100;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(300, 20);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(150, 20);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Form Input Radius";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(440, 467);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(95, 37);
            this.button_remove.TabIndex = 13;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.btn_remove_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Radius 5 :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(541, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Radius  6 :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(541, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 17;
            // 
            // Raduis5
            // 
            this.Raduis5.Text = "Value Raduis5";
            this.Raduis5.Width = 100;
            // 
            // Raduis6
            // 
            this.Raduis6.Text = "Value Raduis6";
            this.Raduis6.Width = 100;
            // 
            // button_loop
            // 
            this.button_loop.Location = new System.Drawing.Point(164, 467);
            this.button_loop.Name = "button_loop";
            this.button_loop.Size = new System.Drawing.Size(95, 37);
            this.button_loop.TabIndex = 18;
            this.button_loop.Text = "Loop";
            this.button_loop.UseVisualStyleBackColor = true;
            this.button_loop.Click += new System.EventHandler(this.loop_click);
            // 
            // textBoxLoop
            // 
            this.textBoxLoop.Location = new System.Drawing.Point(40, 476);
            this.textBoxLoop.Name = "textBoxLoop";
            this.textBoxLoop.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoop.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.textBoxLoop);
            this.Controls.Add(this.button_loop);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.listViewRadius);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.ListView listViewRadius;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Radius1;
        private System.Windows.Forms.ColumnHeader Radius2;
        private System.Windows.Forms.ColumnHeader Radius3;
        private System.Windows.Forms.ColumnHeader Radius4;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ColumnHeader Raduis5;
        private System.Windows.Forms.ColumnHeader Raduis6;
        private System.Windows.Forms.Button button_loop;
        private System.Windows.Forms.TextBox textBoxLoop;
    }

   
}
