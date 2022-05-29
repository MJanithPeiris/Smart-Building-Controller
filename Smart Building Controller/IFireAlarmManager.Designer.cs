
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
            this.background_panel = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tgbtn_alarm = new Smart_Building_Controller.New_Created_Tools.ToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_panel
            // 
            this.background_panel.BackColor = System.Drawing.Color.Black;
            this.background_panel.BorderColor = System.Drawing.Color.White;
            this.background_panel.Controls.Add(this.label5);
            this.background_panel.Controls.Add(this.label1);
            this.background_panel.Controls.Add(this.label3);
            this.background_panel.Controls.Add(this.label2);
            this.background_panel.Controls.Add(this.tgbtn_alarm);
            this.background_panel.ForeColor = System.Drawing.Color.Black;
            this.background_panel.Location = new System.Drawing.Point(278, 153);
            this.background_panel.Name = "background_panel";
            this.background_panel.Radius = 30;
            this.background_panel.Size = new System.Drawing.Size(625, 445);
            this.background_panel.TabIndex = 5;
            this.background_panel.Thickness = 5F;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(383, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fire Alarm on";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fire Alarm off";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgbtn_alarm
            // 
            this.tgbtn_alarm.Location = new System.Drawing.Point(281, 286);
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 56);
            this.label4.TabIndex = 6;
            this.label4.Text = "FIRE ALARM CONTROLER";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(927, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "FRIE ALARM STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(270, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 54);
            this.label5.TabIndex = 7;
            this.label5.Text = "OFF";
            // 
            // IFireAlarmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.background_panel);
            this.Name = "IFireAlarmManager";
            this.Text = "IFireAlarmManager";
            this.Controls.SetChildIndex(this.background_panel, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.background_panel.ResumeLayout(false);
            this.background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Smart_Building_Controller.New_Created_Tools.RoundEdgePanel background_panel;
        private New_Created_Tools.ToggleButton tgbtn_alarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}