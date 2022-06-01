
namespace Smart_Building_Controller
{
    partial class BuildingController
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_notification = new System.Windows.Forms.Label();
            this.roundEdgePanel5 = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.tgbtn_fire_drill = new Smart_Building_Controller.New_Created_Tools.ToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundEdgePanel4 = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.tgbtn_fire_alarm = new Smart_Building_Controller.New_Created_Tools.ToggleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundEdgePanel3 = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.lbl_controllers = new System.Windows.Forms.Label();
            this.btn_fire_alarm_controller = new System.Windows.Forms.Button();
            this.btn_light_controller = new System.Windows.Forms.Button();
            this.btn_door_controller = new System.Windows.Forms.Button();
            this.roundEdgePanel2 = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.btn_power = new Smart_Building_Controller.New_Created_Tools.RoundButton();
            this.lbl_out_of_hours = new System.Windows.Forms.Label();
            this.tgbtn_out_of_hours = new Smart_Building_Controller.New_Created_Tools.ToggleButton();
            this.roundEdgePanel1 = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.btn_web_service = new System.Windows.Forms.Button();
            this.btn_email_service = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.roundEdgePanel5.SuspendLayout();
            this.roundEdgePanel4.SuspendLayout();
            this.roundEdgePanel3.SuspendLayout();
            this.roundEdgePanel2.SuspendLayout();
            this.roundEdgePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_notification);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(799, 459);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 245);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(-7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOTIFICATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_notification
            // 
            this.lbl_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notification.Location = new System.Drawing.Point(17, 74);
            this.lbl_notification.Name = "lbl_notification";
            this.lbl_notification.Size = new System.Drawing.Size(329, 153);
            this.lbl_notification.TabIndex = 8;
            // 
            // roundEdgePanel5
            // 
            this.roundEdgePanel5.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel5.BorderColor = System.Drawing.Color.Black;
            this.roundEdgePanel5.Controls.Add(this.tgbtn_fire_drill);
            this.roundEdgePanel5.Controls.Add(this.label4);
            this.roundEdgePanel5.Controls.Add(this.label5);
            this.roundEdgePanel5.Location = new System.Drawing.Point(0, 580);
            this.roundEdgePanel5.Margin = new System.Windows.Forms.Padding(4);
            this.roundEdgePanel5.Name = "roundEdgePanel5";
            this.roundEdgePanel5.Radius = 20;
            this.roundEdgePanel5.Size = new System.Drawing.Size(407, 62);
            this.roundEdgePanel5.TabIndex = 8;
            this.roundEdgePanel5.Thickness = 5F;
            // 
            // tgbtn_fire_drill
            // 
            this.tgbtn_fire_drill.AutoSize = true;
            this.tgbtn_fire_drill.Location = new System.Drawing.Point(171, 17);
            this.tgbtn_fire_drill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgbtn_fire_drill.MinimumSize = new System.Drawing.Size(60, 30);
            this.tgbtn_fire_drill.Name = "tgbtn_fire_drill";
            this.tgbtn_fire_drill.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.tgbtn_fire_drill.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbtn_fire_drill.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgbtn_fire_drill.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtn_fire_drill.Size = new System.Drawing.Size(60, 30);
            this.tgbtn_fire_drill.TabIndex = 6;
            this.tgbtn_fire_drill.UseVisualStyleBackColor = true;
            this.tgbtn_fire_drill.CheckedChanged += new System.EventHandler(this.tgbtn_fire_drill_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(257, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fire Drill On";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fire Drill Off";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundEdgePanel4
            // 
            this.roundEdgePanel4.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel4.BorderColor = System.Drawing.Color.Black;
            this.roundEdgePanel4.Controls.Add(this.tgbtn_fire_alarm);
            this.roundEdgePanel4.Controls.Add(this.label3);
            this.roundEdgePanel4.Controls.Add(this.label2);
            this.roundEdgePanel4.Location = new System.Drawing.Point(0, 641);
            this.roundEdgePanel4.Margin = new System.Windows.Forms.Padding(4);
            this.roundEdgePanel4.Name = "roundEdgePanel4";
            this.roundEdgePanel4.Radius = 20;
            this.roundEdgePanel4.Size = new System.Drawing.Size(407, 62);
            this.roundEdgePanel4.TabIndex = 5;
            this.roundEdgePanel4.Thickness = 5F;
            // 
            // tgbtn_fire_alarm
            // 
            this.tgbtn_fire_alarm.AutoSize = true;
            this.tgbtn_fire_alarm.Location = new System.Drawing.Point(171, 17);
            this.tgbtn_fire_alarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgbtn_fire_alarm.MinimumSize = new System.Drawing.Size(60, 30);
            this.tgbtn_fire_alarm.Name = "tgbtn_fire_alarm";
            this.tgbtn_fire_alarm.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.tgbtn_fire_alarm.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbtn_fire_alarm.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgbtn_fire_alarm.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtn_fire_alarm.Size = new System.Drawing.Size(60, 30);
            this.tgbtn_fire_alarm.TabIndex = 6;
            this.tgbtn_fire_alarm.UseVisualStyleBackColor = true;
            this.tgbtn_fire_alarm.CheckedChanged += new System.EventHandler(this.tgbtn_fire_alarm_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fire Alarm On";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fire Alarm Off";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundEdgePanel3
            // 
            this.roundEdgePanel3.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel3.BorderColor = System.Drawing.Color.Black;
            this.roundEdgePanel3.Controls.Add(this.lbl_controllers);
            this.roundEdgePanel3.Controls.Add(this.btn_fire_alarm_controller);
            this.roundEdgePanel3.Controls.Add(this.btn_light_controller);
            this.roundEdgePanel3.Controls.Add(this.btn_door_controller);
            this.roundEdgePanel3.Location = new System.Drawing.Point(171, 159);
            this.roundEdgePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundEdgePanel3.Name = "roundEdgePanel3";
            this.roundEdgePanel3.Radius = 20;
            this.roundEdgePanel3.Size = new System.Drawing.Size(800, 281);
            this.roundEdgePanel3.TabIndex = 3;
            this.roundEdgePanel3.Thickness = 5F;
            // 
            // lbl_controllers
            // 
            this.lbl_controllers.AutoSize = true;
            this.lbl_controllers.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_controllers.ForeColor = System.Drawing.Color.White;
            this.lbl_controllers.Location = new System.Drawing.Point(261, 12);
            this.lbl_controllers.Name = "lbl_controllers";
            this.lbl_controllers.Size = new System.Drawing.Size(295, 48);
            this.lbl_controllers.TabIndex = 6;
            this.lbl_controllers.Text = "CONTROLLERS";
            // 
            // btn_fire_alarm_controller
            // 
            this.btn_fire_alarm_controller.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fire_alarm_controller.Location = new System.Drawing.Point(547, 140);
            this.btn_fire_alarm_controller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fire_alarm_controller.Name = "btn_fire_alarm_controller";
            this.btn_fire_alarm_controller.Size = new System.Drawing.Size(200, 110);
            this.btn_fire_alarm_controller.TabIndex = 5;
            this.btn_fire_alarm_controller.Text = "FIRE ALARM CONTROLLER";
            this.btn_fire_alarm_controller.UseVisualStyleBackColor = true;
            this.btn_fire_alarm_controller.Click += new System.EventHandler(this.btn_fire_alarm_controller_Click);
            // 
            // btn_light_controller
            // 
            this.btn_light_controller.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_light_controller.Location = new System.Drawing.Point(305, 140);
            this.btn_light_controller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_light_controller.Name = "btn_light_controller";
            this.btn_light_controller.Size = new System.Drawing.Size(200, 110);
            this.btn_light_controller.TabIndex = 4;
            this.btn_light_controller.Text = "LIGHT CONTROLLER";
            this.btn_light_controller.UseVisualStyleBackColor = true;
            this.btn_light_controller.Click += new System.EventHandler(this.btn_light_controller_Click);
            // 
            // btn_door_controller
            // 
            this.btn_door_controller.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_door_controller.Location = new System.Drawing.Point(60, 140);
            this.btn_door_controller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_door_controller.Name = "btn_door_controller";
            this.btn_door_controller.Size = new System.Drawing.Size(200, 110);
            this.btn_door_controller.TabIndex = 3;
            this.btn_door_controller.Text = "DOOR CONTROLLER";
            this.btn_door_controller.UseVisualStyleBackColor = true;
            this.btn_door_controller.Click += new System.EventHandler(this.btn_door_controller_Click);
            // 
            // roundEdgePanel2
            // 
            this.roundEdgePanel2.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel2.BorderColor = System.Drawing.Color.Black;
            this.roundEdgePanel2.Controls.Add(this.btn_power);
            this.roundEdgePanel2.Controls.Add(this.lbl_out_of_hours);
            this.roundEdgePanel2.Controls.Add(this.tgbtn_out_of_hours);
            this.roundEdgePanel2.Location = new System.Drawing.Point(861, 1);
            this.roundEdgePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundEdgePanel2.Name = "roundEdgePanel2";
            this.roundEdgePanel2.Radius = 20;
            this.roundEdgePanel2.Size = new System.Drawing.Size(299, 90);
            this.roundEdgePanel2.TabIndex = 3;
            this.roundEdgePanel2.Thickness = 5F;
            // 
            // btn_power
            // 
            this.btn_power.BackColor = System.Drawing.Color.Brown;
            this.btn_power.BackgroundColor = System.Drawing.Color.Brown;
            this.btn_power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_power.BackgroundImage")));
            this.btn_power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_power.BorderColor = System.Drawing.Color.White;
            this.btn_power.BorderRadius = 24;
            this.btn_power.BorderSize = 1;
            this.btn_power.FlatAppearance.BorderSize = 0;
            this.btn_power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_power.ForeColor = System.Drawing.Color.White;
            this.btn_power.Location = new System.Drawing.Point(211, 12);
            this.btn_power.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(64, 62);
            this.btn_power.TabIndex = 5;
            this.btn_power.TextColor = System.Drawing.Color.White;
            this.btn_power.UseVisualStyleBackColor = false;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // lbl_out_of_hours
            // 
            this.lbl_out_of_hours.AutoSize = true;
            this.lbl_out_of_hours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_out_of_hours.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out_of_hours.ForeColor = System.Drawing.Color.White;
            this.lbl_out_of_hours.Location = new System.Drawing.Point(23, 26);
            this.lbl_out_of_hours.Name = "lbl_out_of_hours";
            this.lbl_out_of_hours.Size = new System.Drawing.Size(95, 38);
            this.lbl_out_of_hours.TabIndex = 2;
            this.lbl_out_of_hours.Text = "Out of Hours\r\nOFF";
            this.lbl_out_of_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgbtn_out_of_hours
            // 
            this.tgbtn_out_of_hours.AutoSize = true;
            this.tgbtn_out_of_hours.Location = new System.Drawing.Point(125, 30);
            this.tgbtn_out_of_hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgbtn_out_of_hours.MinimumSize = new System.Drawing.Size(60, 30);
            this.tgbtn_out_of_hours.Name = "tgbtn_out_of_hours";
            this.tgbtn_out_of_hours.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.tgbtn_out_of_hours.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbtn_out_of_hours.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgbtn_out_of_hours.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtn_out_of_hours.Size = new System.Drawing.Size(60, 30);
            this.tgbtn_out_of_hours.TabIndex = 1;
            this.tgbtn_out_of_hours.UseVisualStyleBackColor = true;
            this.tgbtn_out_of_hours.CheckedChanged += new System.EventHandler(this.tgbtn_out_of_hours_CheckedChanged);
            // 
            // roundEdgePanel1
            // 
            this.roundEdgePanel1.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel1.BorderColor = System.Drawing.Color.Black;
            this.roundEdgePanel1.Controls.Add(this.btn_web_service);
            this.roundEdgePanel1.Controls.Add(this.btn_email_service);
            this.roundEdgePanel1.Location = new System.Drawing.Point(0, 1);
            this.roundEdgePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundEdgePanel1.Name = "roundEdgePanel1";
            this.roundEdgePanel1.Radius = 20;
            this.roundEdgePanel1.Size = new System.Drawing.Size(400, 130);
            this.roundEdgePanel1.TabIndex = 0;
            this.roundEdgePanel1.Thickness = 5F;
            // 
            // btn_web_service
            // 
            this.btn_web_service.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_web_service.Location = new System.Drawing.Point(219, 26);
            this.btn_web_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_web_service.Name = "btn_web_service";
            this.btn_web_service.Size = new System.Drawing.Size(149, 75);
            this.btn_web_service.TabIndex = 2;
            this.btn_web_service.Text = "WEB SERVICE";
            this.btn_web_service.UseVisualStyleBackColor = true;
            this.btn_web_service.Click += new System.EventHandler(this.btn_web_service_Click);
            // 
            // btn_email_service
            // 
            this.btn_email_service.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email_service.Location = new System.Drawing.Point(35, 26);
            this.btn_email_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_email_service.Name = "btn_email_service";
            this.btn_email_service.Size = new System.Drawing.Size(149, 75);
            this.btn_email_service.TabIndex = 1;
            this.btn_email_service.Text = "EMAIL SERVICE";
            this.btn_email_service.UseVisualStyleBackColor = true;
            // 
            // BuildingController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 703);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roundEdgePanel5);
            this.Controls.Add(this.roundEdgePanel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundEdgePanel3);
            this.Controls.Add(this.roundEdgePanel2);
            this.Controls.Add(this.roundEdgePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuildingController";
            this.Text = "Building Controller";
            this.Load += new System.EventHandler(this.BuildingController_Load);
            this.panel1.ResumeLayout(false);
            this.roundEdgePanel5.ResumeLayout(false);
            this.roundEdgePanel5.PerformLayout();
            this.roundEdgePanel4.ResumeLayout(false);
            this.roundEdgePanel4.PerformLayout();
            this.roundEdgePanel3.ResumeLayout(false);
            this.roundEdgePanel3.PerformLayout();
            this.roundEdgePanel2.ResumeLayout(false);
            this.roundEdgePanel2.PerformLayout();
            this.roundEdgePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Smart_Building_Controller.New_Created_Tools.RoundEdgePanel roundEdgePanel1;
        private System.Windows.Forms.Button btn_web_service;
        private System.Windows.Forms.Button btn_email_service;
        private Smart_Building_Controller.New_Created_Tools.RoundEdgePanel roundEdgePanel2;
        private System.Windows.Forms.Label lbl_out_of_hours;
        private New_Created_Tools.ToggleButton tgbtn_out_of_hours;
        private Smart_Building_Controller.New_Created_Tools.RoundEdgePanel roundEdgePanel3;
        private System.Windows.Forms.Button btn_fire_alarm_controller;
        private System.Windows.Forms.Button btn_light_controller;
        private System.Windows.Forms.Button btn_door_controller;
        private System.Windows.Forms.Label lbl_controllers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private New_Created_Tools.RoundButton btn_power;
        private New_Created_Tools.RoundEdgePanel roundEdgePanel4;
        private New_Created_Tools.ToggleButton tgbtn_fire_alarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private New_Created_Tools.RoundEdgePanel roundEdgePanel5;
        private New_Created_Tools.ToggleButton tgbtn_fire_drill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_notification;
    }
}

