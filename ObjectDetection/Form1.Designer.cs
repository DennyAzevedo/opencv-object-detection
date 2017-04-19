namespace ObjectDetection
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
            this.pictureFrame = new System.Windows.Forms.PictureBox();
            this.cb_camera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_kc2O1 = new System.Windows.Forms.Label();
            this.lb_kc1O1 = new System.Windows.Forms.Label();
            this.lb_gocO1 = new System.Windows.Forms.Label();
            this.lb_toadoO1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdeltat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_kc2O2 = new System.Windows.Forms.Label();
            this.lb_kc1O2 = new System.Windows.Forms.Label();
            this.lb_gocO2 = new System.Windows.Forms.Label();
            this.lb_toadoO2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lb_kc2O3 = new System.Windows.Forms.Label();
            this.lb_kc1O3 = new System.Windows.Forms.Label();
            this.lb_gocO3 = new System.Windows.Forms.Label();
            this.lb_toadoO3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureFrame
            // 
            this.pictureFrame.Image = global::ObjectDetection.Properties.Resources.MAIN;
            this.pictureFrame.Location = new System.Drawing.Point(12, 12);
            this.pictureFrame.Name = "pictureFrame";
            this.pictureFrame.Size = new System.Drawing.Size(639, 479);
            this.pictureFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFrame.TabIndex = 0;
            this.pictureFrame.TabStop = false;
            // 
            // cb_camera
            // 
            this.cb_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_camera.FormattingEnabled = true;
            this.cb_camera.Location = new System.Drawing.Point(75, 506);
            this.cb_camera.Name = "cb_camera";
            this.cb_camera.Size = new System.Drawing.Size(174, 25);
            this.cb_camera.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(389, 503);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(108, 35);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(265, 503);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(108, 35);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_kc2O3);
            this.groupBox2.Controls.Add(this.lb_kc1O3);
            this.groupBox2.Controls.Add(this.lb_gocO3);
            this.groupBox2.Controls.Add(this.lb_toadoO3);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lb_kc2O2);
            this.groupBox2.Controls.Add(this.lb_kc1O2);
            this.groupBox2.Controls.Add(this.lb_gocO2);
            this.groupBox2.Controls.Add(this.lb_toadoO2);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.lb_kc2O1);
            this.groupBox2.Controls.Add(this.lb_kc1O1);
            this.groupBox2.Controls.Add(this.lb_gocO1);
            this.groupBox2.Controls.Add(this.lb_toadoO1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(658, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 478);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            // 
            // lb_kc2O1
            // 
            this.lb_kc2O1.AutoSize = true;
            this.lb_kc2O1.Location = new System.Drawing.Point(139, 150);
            this.lb_kc2O1.Name = "lb_kc2O1";
            this.lb_kc2O1.Size = new System.Drawing.Size(38, 17);
            this.lb_kc2O1.TabIndex = 23;
            this.lb_kc2O1.Text = "0 cm";
            // 
            // lb_kc1O1
            // 
            this.lb_kc1O1.AutoSize = true;
            this.lb_kc1O1.Location = new System.Drawing.Point(139, 119);
            this.lb_kc1O1.Name = "lb_kc1O1";
            this.lb_kc1O1.Size = new System.Drawing.Size(38, 17);
            this.lb_kc1O1.TabIndex = 16;
            this.lb_kc1O1.Text = "0 cm";
            // 
            // lb_gocO1
            // 
            this.lb_gocO1.AutoSize = true;
            this.lb_gocO1.Location = new System.Drawing.Point(139, 89);
            this.lb_gocO1.Name = "lb_gocO1";
            this.lb_gocO1.Size = new System.Drawing.Size(36, 17);
            this.lb_gocO1.TabIndex = 15;
            this.lb_gocO1.Text = "0 độ";
            // 
            // lb_toadoO1
            // 
            this.lb_toadoO1.AutoSize = true;
            this.lb_toadoO1.Location = new System.Drawing.Point(139, 60);
            this.lb_toadoO1.Name = "lb_toadoO1";
            this.lb_toadoO1.Size = new System.Drawing.Size(38, 17);
            this.lb_toadoO1.TabIndex = 14;
            this.lb_toadoO1.Text = "(0,0)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "Object 3:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Object 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Khoảng cách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Góc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tọa độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Object 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "delta t";
            // 
            // txtdeltat
            // 
            this.txtdeltat.Location = new System.Drawing.Point(580, 506);
            this.txtdeltat.Name = "txtdeltat";
            this.txtdeltat.Size = new System.Drawing.Size(160, 23);
            this.txtdeltat.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(883, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_kc2O2
            // 
            this.lb_kc2O2.AutoSize = true;
            this.lb_kc2O2.Location = new System.Drawing.Point(143, 315);
            this.lb_kc2O2.Name = "lb_kc2O2";
            this.lb_kc2O2.Size = new System.Drawing.Size(38, 17);
            this.lb_kc2O2.TabIndex = 32;
            this.lb_kc2O2.Text = "0 cm";
            // 
            // lb_kc1O2
            // 
            this.lb_kc1O2.AutoSize = true;
            this.lb_kc1O2.Location = new System.Drawing.Point(143, 284);
            this.lb_kc1O2.Name = "lb_kc1O2";
            this.lb_kc1O2.Size = new System.Drawing.Size(38, 17);
            this.lb_kc1O2.TabIndex = 31;
            this.lb_kc1O2.Text = "0 cm";
            // 
            // lb_gocO2
            // 
            this.lb_gocO2.AutoSize = true;
            this.lb_gocO2.Location = new System.Drawing.Point(143, 254);
            this.lb_gocO2.Name = "lb_gocO2";
            this.lb_gocO2.Size = new System.Drawing.Size(36, 17);
            this.lb_gocO2.TabIndex = 30;
            this.lb_gocO2.Text = "0 độ";
            // 
            // lb_toadoO2
            // 
            this.lb_toadoO2.AutoSize = true;
            this.lb_toadoO2.Location = new System.Drawing.Point(143, 225);
            this.lb_toadoO2.Name = "lb_toadoO2";
            this.lb_toadoO2.Size = new System.Drawing.Size(38, 17);
            this.lb_toadoO2.TabIndex = 29;
            this.lb_toadoO2.Text = "(0,0)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Khoảng cách";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "Góc";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(29, 225);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 17);
            this.label25.TabIndex = 26;
            this.label25.Text = "Tọa độ";
            // 
            // lb_kc2O3
            // 
            this.lb_kc2O3.AutoSize = true;
            this.lb_kc2O3.Location = new System.Drawing.Point(143, 448);
            this.lb_kc2O3.Name = "lb_kc2O3";
            this.lb_kc2O3.Size = new System.Drawing.Size(38, 17);
            this.lb_kc2O3.TabIndex = 39;
            this.lb_kc2O3.Text = "0 cm";
            // 
            // lb_kc1O3
            // 
            this.lb_kc1O3.AutoSize = true;
            this.lb_kc1O3.Location = new System.Drawing.Point(143, 431);
            this.lb_kc1O3.Name = "lb_kc1O3";
            this.lb_kc1O3.Size = new System.Drawing.Size(38, 17);
            this.lb_kc1O3.TabIndex = 38;
            this.lb_kc1O3.Text = "0 cm";
            // 
            // lb_gocO3
            // 
            this.lb_gocO3.AutoSize = true;
            this.lb_gocO3.Location = new System.Drawing.Point(143, 401);
            this.lb_gocO3.Name = "lb_gocO3";
            this.lb_gocO3.Size = new System.Drawing.Size(36, 17);
            this.lb_gocO3.TabIndex = 37;
            this.lb_gocO3.Text = "0 độ";
            // 
            // lb_toadoO3
            // 
            this.lb_toadoO3.AutoSize = true;
            this.lb_toadoO3.Location = new System.Drawing.Point(137, 372);
            this.lb_toadoO3.Name = "lb_toadoO3";
            this.lb_toadoO3.Size = new System.Drawing.Size(38, 17);
            this.lb_toadoO3.TabIndex = 36;
            this.lb_toadoO3.Text = "(0,0)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 431);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 17);
            this.label22.TabIndex = 35;
            this.label22.Text = "Khoảng cách";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(29, 401);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 17);
            this.label23.TabIndex = 34;
            this.label23.Text = "Góc";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(29, 372);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 17);
            this.label26.TabIndex = 33;
            this.label26.Text = "Tọa độ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 547);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdeltat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.pictureFrame);
            this.Controls.Add(this.cb_camera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_run);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ObjectDetection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFrame;
        private System.Windows.Forms.ComboBox cb_camera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdeltat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_kc1O1;
        private System.Windows.Forms.Label lb_gocO1;
        private System.Windows.Forms.Label lb_toadoO1;
        private System.Windows.Forms.Label lb_kc2O1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_kc2O3;
        private System.Windows.Forms.Label lb_kc1O3;
        private System.Windows.Forms.Label lb_gocO3;
        private System.Windows.Forms.Label lb_toadoO3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lb_kc2O2;
        private System.Windows.Forms.Label lb_kc1O2;
        private System.Windows.Forms.Label lb_gocO2;
        private System.Windows.Forms.Label lb_toadoO2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
    }
}

