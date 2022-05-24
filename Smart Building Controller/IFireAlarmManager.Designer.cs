
namespace Smart_Building_Controller
{
    partial class IFireAlarmManager
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
            this.background_panel = new Test_for_tdd.NewControls.RoundEdgePanel();
            this.label_display_status = new System.Windows.Forms.Label();
            this.label_alarm_on = new System.Windows.Forms.Label();
            this.label_alarm_off = new System.Windows.Forms.Label();
            this.tgbtn_alarm = new Smart_Building_Controller.New_Created_Tools.ToggleButton();
            this.label_alarm_status = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.lable_engineer_status = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_panel
            // 
            this.background_panel.BackColor = System.Drawing.Color.Black;
            this.background_panel.BorderColor = System.Drawing.Color.White;
            this.background_panel.Controls.Add(this.label_display_status);
            this.background_panel.Controls.Add(this.label_alarm_on);
            this.background_panel.Controls.Add(this.label_alarm_off);
            this.background_panel.Controls.Add(this.tgbtn_alarm);
            this.background_panel.Controls.Add(this.label_alarm_status);
            this.background_panel.ForeColor = System.Drawing.Color.Black;
            this.background_panel.Location = new System.Drawing.Point(278, 153);
            this.background_panel.Name = "background_panel";
            this.background_panel.Radius = 30;
            this.background_panel.Size = new System.Drawing.Size(625, 445);
            this.background_panel.TabIndex = 5;
            this.background_panel.Thickness = 5F;
            // 
            // label_display_status
            // 
            this.label_display_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_status.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_display_status.Location = new System.Drawing.Point(234, 155);
            this.label_display_status.Name = "label_display_status";
            this.label_display_status.Size = new System.Drawing.Size(143, 60);
            this.label_display_status.TabIndex = 6;
            this.label_display_status.Text = "OFF";
            this.label_display_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_alarm_on
            // 
            this.label_alarm_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alarm_on.ForeColor = System.Drawing.Color.White;
            this.label_alarm_on.Location = new System.Drawing.Point(414, 292);
            this.label_alarm_on.Name = "label_alarm_on";
            this.label_alarm_on.Size = new System.Drawing.Size(115, 40);
            this.label_alarm_on.TabIndex = 5;
            this.label_alarm_on.Text = "Alarm on";
            // 
            // label_alarm_off
            // 
            this.label_alarm_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alarm_off.ForeColor = System.Drawing.Color.White;
            this.label_alarm_off.Location = new System.Drawing.Point(111, 290);
            this.label_alarm_off.Name = "label_alarm_off";
            this.label_alarm_off.Size = new System.Drawing.Size(103, 40);
            this.label_alarm_off.TabIndex = 4;
            this.label_alarm_off.Text = "Alarm off";
            // 
            // tgbtn_alarm
            // 
            this.tgbtn_alarm.Location = new System.Drawing.Point(270, 286);
            this.tgbtn_alarm.MinimumSize = new System.Drawing.Size(60, 30);
            this.tgbtn_alarm.Name = "tgbtn_alarm";
            this.tgbtn_alarm.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.tgbtn_alarm.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbtn_alarm.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgbtn_alarm.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtn_alarm.Size = new System.Drawing.Size(75, 40);
            this.tgbtn_alarm.TabIndex = 3;
            this.tgbtn_alarm.UseVisualStyleBackColor = true;
            // 
            // label_alarm_status
            // 
            this.label_alarm_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alarm_status.ForeColor = System.Drawing.Color.White;
            this.label_alarm_status.Location = new System.Drawing.Point(142, 65);
            this.label_alarm_status.Name = "label_alarm_status";
            this.label_alarm_status.Size = new System.Drawing.Size(340, 47);
            this.label_alarm_status.TabIndex = 1;
            this.label_alarm_status.Text = "Fire Alarm Status";
            this.label_alarm_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(36, 36);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(562, 60);
            this.label_Title.TabIndex = 6;
            this.label_Title.Text = "FIRE ALARM CONTROLER";
            // 
            // lable_engineer_status
            // 
            this.lable_engineer_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lable_engineer_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_engineer_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable_engineer_status.Location = new System.Drawing.Point(851, 36);
            this.lable_engineer_status.Name = "lable_engineer_status";
            this.lable_engineer_status.Size = new System.Drawing.Size(250, 75);
            this.lable_engineer_status.TabIndex = 7;
            this.lable_engineer_status.Text = "  Required Engineer     Yes";
            this.lable_engineer_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(927, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 8;
            // 
            // IFireAlarmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lable_engineer_status);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.background_panel);
            this.Name = "IFireAlarmManager";
            this.Text = "IFireAlarmManager";
            this.background_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Test_for_tdd.NewControls.RoundEdgePanel background_panel;
        private New_Created_Tools.ToggleButton tgbtn_alarm;
        private System.Windows.Forms.Label label_alarm_status;
        private System.Windows.Forms.Label label_display_status;
        private System.Windows.Forms.Label label_alarm_on;
        private System.Windows.Forms.Label label_alarm_off;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label lable_engineer_status;
        private System.Windows.Forms.TextBox textBox1;
    }
}