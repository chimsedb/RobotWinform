namespace Control_Application
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelServoPos_0 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarServo_0 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelServoPos_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarServo_1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelServoPos_2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarServo_2 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelServoPos_3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBarServo_3 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonResetServos = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_0)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servo Control Application";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelServoPos_0);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trackBarServo_0);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 126);
            this.panel1.TabIndex = 1;
            // 
            // labelServoPos_0
            // 
            this.labelServoPos_0.AutoSize = true;
            this.labelServoPos_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_0.Location = new System.Drawing.Point(240, 87);
            this.labelServoPos_0.Name = "labelServoPos_0";
            this.labelServoPos_0.Size = new System.Drawing.Size(102, 26);
            this.labelServoPos_0.TabIndex = 4;
            this.labelServoPos_0.Text = "Position: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "180";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "0";
            // 
            // trackBarServo_0
            // 
            this.trackBarServo_0.Location = new System.Drawing.Point(52, 39);
            this.trackBarServo_0.Maximum = 180;
            this.trackBarServo_0.Name = "trackBarServo_0";
            this.trackBarServo_0.Size = new System.Drawing.Size(467, 45);
            this.trackBarServo_0.TabIndex = 1;
            this.trackBarServo_0.Scroll += new System.EventHandler(this.trackBarServo_0_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servo 0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelServoPos_1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.trackBarServo_1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 126);
            this.panel2.TabIndex = 2;
            // 
            // labelServoPos_1
            // 
            this.labelServoPos_1.AutoSize = true;
            this.labelServoPos_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_1.Location = new System.Drawing.Point(240, 87);
            this.labelServoPos_1.Name = "labelServoPos_1";
            this.labelServoPos_1.Size = new System.Drawing.Size(102, 26);
            this.labelServoPos_1.TabIndex = 4;
            this.labelServoPos_1.Text = "Position: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "180";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "0";
            // 
            // trackBarServo_1
            // 
            this.trackBarServo_1.Location = new System.Drawing.Point(52, 39);
            this.trackBarServo_1.Maximum = 180;
            this.trackBarServo_1.Name = "trackBarServo_1";
            this.trackBarServo_1.Size = new System.Drawing.Size(467, 45);
            this.trackBarServo_1.TabIndex = 1;
            this.trackBarServo_1.Scroll += new System.EventHandler(this.trackBarServo_1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Servo 1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelServoPos_2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.trackBarServo_2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(13, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 126);
            this.panel3.TabIndex = 3;
            // 
            // labelServoPos_2
            // 
            this.labelServoPos_2.AutoSize = true;
            this.labelServoPos_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_2.Location = new System.Drawing.Point(240, 87);
            this.labelServoPos_2.Name = "labelServoPos_2";
            this.labelServoPos_2.Size = new System.Drawing.Size(102, 26);
            this.labelServoPos_2.TabIndex = 4;
            this.labelServoPos_2.Text = "Position: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(516, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "180";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "0";
            // 
            // trackBarServo_2
            // 
            this.trackBarServo_2.Location = new System.Drawing.Point(52, 39);
            this.trackBarServo_2.Maximum = 180;
            this.trackBarServo_2.Name = "trackBarServo_2";
            this.trackBarServo_2.Size = new System.Drawing.Size(467, 45);
            this.trackBarServo_2.TabIndex = 1;
            this.trackBarServo_2.Scroll += new System.EventHandler(this.trackBarServo_2_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(245, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Servo 2";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelServoPos_3);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.trackBarServo_3);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(13, 456);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 126);
            this.panel4.TabIndex = 4;
            // 
            // labelServoPos_3
            // 
            this.labelServoPos_3.AutoSize = true;
            this.labelServoPos_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_3.Location = new System.Drawing.Point(240, 87);
            this.labelServoPos_3.Name = "labelServoPos_3";
            this.labelServoPos_3.Size = new System.Drawing.Size(102, 26);
            this.labelServoPos_3.TabIndex = 4;
            this.labelServoPos_3.Text = "Position: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(516, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 26);
            this.label15.TabIndex = 3;
            this.label15.Text = "180";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 26);
            this.label16.TabIndex = 2;
            this.label16.Text = "0";
            // 
            // trackBarServo_3
            // 
            this.trackBarServo_3.Location = new System.Drawing.Point(52, 39);
            this.trackBarServo_3.Maximum = 180;
            this.trackBarServo_3.Name = "trackBarServo_3";
            this.trackBarServo_3.Size = new System.Drawing.Size(467, 45);
            this.trackBarServo_3.TabIndex = 1;
            this.trackBarServo_3.Scroll += new System.EventHandler(this.trackBarServo_3_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(245, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 26);
            this.label17.TabIndex = 0;
            this.label17.Text = "Servo 3";
            // 
            // buttonResetServos
            // 
            this.buttonResetServos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetServos.Location = new System.Drawing.Point(129, 617);
            this.buttonResetServos.Name = "buttonResetServos";
            this.buttonResetServos.Size = new System.Drawing.Size(136, 41);
            this.buttonResetServos.TabIndex = 5;
            this.buttonResetServos.Text = "Reset All";
            this.buttonResetServos.UseVisualStyleBackColor = true;
            this.buttonResetServos.Click += new System.EventHandler(this.buttonResetServos_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(363, 617);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(136, 41);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "Run Auto";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 670);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonResetServos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_0)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarServo_0;
        private System.Windows.Forms.Label labelServoPos_0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelServoPos_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarServo_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelServoPos_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarServo_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelServoPos_3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBarServo_3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonResetServos;
        private System.Windows.Forms.Button buttonRun;
    }
}

