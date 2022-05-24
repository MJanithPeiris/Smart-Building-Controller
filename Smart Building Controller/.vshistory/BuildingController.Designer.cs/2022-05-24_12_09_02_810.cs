
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundEdgePanel3 = new Test_for_tdd.NewControls.RoundEdgePanel();
            this.lbl_controllers = new System.Windows.Forms.Label();
            this.btn_fire_alarm_controller = new System.Windows.Forms.Button();
            this.btn_light_controller = new System.Windows.Forms.Button();
            this.btn_door_controller = new System.Windows.Forms.Button();
            this.roundEdgePanel2 = new Test_for_tdd.NewControls.RoundEdgePanel();
            this.lbl_out_of_hours = new System.Windows.Forms.Label();
            this.tgbtn_out_of_hours = new Smart_Building_Controller.New_Created_Tools.ToggleButton();
            this.btn_power = new Smart_Building_Controller.New_Created_Tools.RoundButton();
            this.roundEdgePanel1 = new Test_for_tdd.NewControls.RoundEdgePanel();
            this.btn_web_service = new System.Windows.Forms.Button();
            this.btn_email_service = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.roundEdgePanel3.SuspendLayout();
            this.roundEdgePanel2.SuspendLayout();
            this.roundEdgePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(799, 459);
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOTIFICATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundEdgePanel3
            // 
            this.roundEdgePanel3.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel3.BorderColor = System.Drawing.Color.White;
            this.roundEdgePanel3.Controls.Add(this.lbl_controllers);
            this.roundEdgePanel3.Controls.Add(this.btn_fire_alarm_controller);
            this.roundEdgePanel3.Controls.Add(this.btn_light_controller);
            this.roundEdgePanel3.Controls.Add(this.btn_door_controller);
            this.roundEdgePanel3.Location = new System.Drawing.Point(171, 159);
            this.roundEdgePanel3.Name = "roundEdgePanel3";
            this.roundEdgePanel3.Radius = 20;
            this.roundEdgePanel3.Size = new System.Drawing.Size(800, 280);
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
            this.lbl_controllers.Size = new System.Drawing.Size(300, 48);
            this.lbl_controllers.TabIndex = 6;
            this.lbl_controllers.Text = "CONTROLLERS";
            // 
            // btn_fire_alarm_controller
            // 
            this.btn_fire_alarm_controller.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fire_alarm_controller.Location = new System.Drawing.Point(546, 140);
            this.btn_fire_alarm_controller.Name = "btn_fire_alarm_controller";
            this.btn_fire_alarm_controller.Size = new System.Drawing.Size(200, 110);
            this.btn_fire_alarm_controller.TabIndex = 5;
            this.btn_fire_alarm_controller.Text = "FIRE ALARM CONTROLLER";
            this.btn_fire_alarm_controller.UseVisualStyleBackColor = true;
            // 
            // btn_light_controller
            // 
            this.btn_light_controller.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_light_controller.Location = new System.Drawing.Point(305, 140);
            this.btn_light_controller.Name = "btn_light_controller";
            this.btn_light_controller.Size = new System.Drawing.Size(200, 110);
            this.btn_light_controller.TabIndex = 4;
            this.btn_light_controller.Text = "LIGHT CONTROLLER";
            this.btn_light_controller.UseVisualStyleBackColor = true;
            // 
            // btn_door_controller
            // 
            this.btn_door_controller.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_door_controller.Location = new System.Drawing.Point(60, 140);
            this.btn_door_controller.Name = "btn_door_controller";
            this.btn_door_controller.Size = new System.Drawing.Size(200, 110);
            this.btn_door_controller.TabIndex = 3;
            this.btn_door_controller.Text = "DOOR CONTROLLER";
            this.btn_door_controller.UseVisualStyleBackColor = true;
            // 
            // roundEdgePanel2
            // 
            this.roundEdgePanel2.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel2.BorderColor = System.Drawing.Color.White;
            this.roundEdgePanel2.Controls.Add(this.lbl_out_of_hours);
            this.roundEdgePanel2.Controls.Add(this.tgbtn_out_of_hours);
            this.roundEdgePanel2.Controls.Add(this.btn_power);
            this.roundEdgePanel2.Location = new System.Drawing.Point(862, 1);
            this.roundEdgePanel2.Name = "roundEdgePanel2";
            this.roundEdgePanel2.Radius = 20;
            this.roundEdgePanel2.Size = new System.Drawing.Size(300, 80);
            this.roundEdgePanel2.TabIndex = 3;
            this.roundEdgePanel2.Thickness = 5F;
            // 
            // lbl_out_of_hours
            // 
            this.lbl_out_of_hours.AutoSize = true;
            this.lbl_out_of_hours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_out_of_hours.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out_of_hours.ForeColor = System.Drawing.Color.White;
            this.lbl_out_of_hours.Location = new System.Drawing.Point(23, 23);
            this.lbl_out_of_hours.Name = "lbl_out_of_hours";
            this.lbl_out_of_hours.Size = new System.Drawing.Size(95, 38);
            this.lbl_out_of_hours.TabIndex = 2;
            this.lbl_out_of_hours.Text = "Out of Hours\r\nOFF";
            this.lbl_out_of_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgbtn_out_of_hours
            // 
            this.tgbtn_out_of_hours.AutoSize = true;
            this.tgbtn_out_of_hours.Location = new System.Drawing.Point(126, 26);
            this.tgbtn_out_of_hours.MinimumSize = new System.Drawing.Size(60, 30);
            this.tgbtn_out_of_hours.Name = "tgbtn_out_of_hours";
            this.tgbtn_out_of_hours.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.tgbtn_out_of_hours.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbtn_out_of_hours.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgbtn_out_of_hours.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtn_out_of_hours.Size = new System.Drawing.Size(60, 30);
            this.tgbtn_out_of_hours.TabIndex = 1;
            this.tgbtn_out_of_hours.UseVisualStyleBackColor = true;
            // 
            // btn_power
            // 
            this.btn_power.BackColor = System.Drawing.Color.Brown;
            this.btn_power.BackgroundColor = System.Drawing.Color.Brown;
            this.btn_power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_power.BackgroundImage")));
            this.btn_power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_power.BorderColor = System.Drawing.Color.White;
            this.btn_power.BorderRadius = 25;
            this.btn_power.BorderSize = 1;
            this.btn_power.FlatAppearance.BorderSize = 0;
            this.btn_power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_power.ForeColor = System.Drawing.Color.White;
            this.btn_power.Location = new System.Drawing.Point(225, 14);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(50, 50);
            this.btn_power.TabIndex = 0;
            this.btn_power.TextColor = System.Drawing.Color.White;
            this.btn_power.UseVisualStyleBackColor = false;
            // 
            // roundEdgePanel1
            // 
            this.roundEdgePanel1.BackColor = System.Drawing.Color.Black;
            this.roundEdgePanel1.BorderColor = System.Drawing.Color.White;
            this.roundEdgePanel1.Controls.Add(this.btn_web_service);
            this.roundEdgePanel1.Controls.Add(this.btn_email_service);
            this.roundEdgePanel1.Location = new System.Drawing.Point(0, 1);
            this.roundEdgePanel1.Name = "roundEdgePanel1";
            this.roundEdgePanel1.Radius = 20;
            this.roundEdgePanel1.Size = new System.Drawing.Size(400, 130);
            this.roundEdgePanel1.TabIndex = 0;
            this.roundEdgePanel1.Thickness = 5F;
            // 
            // btn_web_service
            // 
            this.btn_web_service.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_web_service.Location = new System.Drawing.Point(218, 26);
            this.btn_web_service.Name = "btn_web_service";
            this.btn_web_service.Size = new System.Drawing.Size(150, 75);
            this.btn_web_service.TabIndex = 2;
            this.btn_web_service.Text = "WEB SERVICE";
            this.btn_web_service.UseVisualStyleBackColor = true;
            // 
            // btn_email_service
            // 
            this.btn_email_service.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email_service.Location = new System.Drawing.Point(34, 26);
            this.btn_email_service.Name = "btn_email_service";
            this.btn_email_service.Size = new System.Drawing.Size(150, 75);
            this.btn_email_service.TabIndex = 1;
            this.btn_email_service.Text = "EMAIL SERVICE";
            this.btn_email_service.UseVisualStyleBackColor = true;
            // 
            // BuildingController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundEdgePanel3);
            this.Controls.Add(this.roundEdgePanel2);
            this.Controls.Add(this.roundEdgePanel1);
            this.Name = "BuildingController";
            this.Text = "Building Controller";
            this.panel1.ResumeLayout(false);
            this.roundEdgePanel3.ResumeLayout(false);
            this.roundEdgePanel3.PerformLayout();
            this.roundEdgePanel2.ResumeLayout(false);
            this.roundEdgePanel2.PerformLayout();
            this.roundEdgePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Test_for_tdd.NewControls.RoundEdgePanel roundEdgePanel1;
        private System.Windows.Forms.Button btn_web_service;
        private System.Windows.Forms.Button btn_email_service;
        private Test_for_tdd.NewControls.RoundEdgePanel roundEdgePanel2;
        private System.Windows.Forms.Label lbl_out_of_hours;
        private New_Created_Tools.ToggleButton tgbtn_out_of_hours;
        private New_Created_Tools.RoundButton btn_power;
        private Test_for_tdd.NewControls.RoundEdgePanel roundEdgePanel3;
        private System.Windows.Forms.Button btn_fire_alarm_controller;
        private System.Windows.Forms.Button btn_light_controller;
        private System.Windows.Forms.Button btn_door_controller;
        private System.Windows.Forms.Label lbl_controllers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

