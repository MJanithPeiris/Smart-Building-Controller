
namespace Smart_Building_Controller
{
    partial class IWebService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IWebService));
            this.btn_log_data = new System.Windows.Forms.Button();
            this.lable_title = new System.Windows.Forms.Label();
            this.background_panel = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.input_to = new System.Windows.Forms.TextBox();
            this.label_firealarm_log = new System.Windows.Forms.Label();
            this.label_engineerrequired_log = new System.Windows.Forms.Label();
            this.label_statechange_log = new System.Windows.Forms.Label();
            this.background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_log_data
            // 
            this.btn_log_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_data.Location = new System.Drawing.Point(753, 506);
            this.btn_log_data.Margin = new System.Windows.Forms.Padding(2);
            this.btn_log_data.Name = "btn_log_data";
            this.btn_log_data.Size = new System.Drawing.Size(107, 39);
            this.btn_log_data.TabIndex = 11;
            this.btn_log_data.Text = "LOG DATA";
            this.btn_log_data.UseVisualStyleBackColor = true;
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.BackColor = System.Drawing.Color.Transparent;
            this.lable_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_title.Location = new System.Drawing.Point(32, 19);
            this.lable_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(223, 45);
            this.lable_title.TabIndex = 10;
            this.lable_title.Text = "WEB SERVICE";
            // 
            // background_panel
            // 
            this.background_panel.BackColor = System.Drawing.Color.Black;
            this.background_panel.BorderColor = System.Drawing.Color.Black;
            this.background_panel.Controls.Add(this.textBox2);
            this.background_panel.Controls.Add(this.textBox3);
            this.background_panel.Controls.Add(this.input_to);
            this.background_panel.Controls.Add(this.label_firealarm_log);
            this.background_panel.Controls.Add(this.label_engineerrequired_log);
            this.background_panel.Controls.Add(this.label_statechange_log);
            this.background_panel.ForeColor = System.Drawing.Color.Black;
            this.background_panel.Location = new System.Drawing.Point(10, 75);
            this.background_panel.Margin = new System.Windows.Forms.Padding(2);
            this.background_panel.Name = "background_panel";
            this.background_panel.Radius = 20;
            this.background_panel.Size = new System.Drawing.Size(850, 400);
            this.background_panel.TabIndex = 9;
            this.background_panel.Thickness = 5F;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(23, 170);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(800, 60);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(23, 290);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(800, 60);
            this.textBox3.TabIndex = 6;
            // 
            // input_to
            // 
            this.input_to.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_to.Location = new System.Drawing.Point(23, 50);
            this.input_to.Margin = new System.Windows.Forms.Padding(2);
            this.input_to.Multiline = true;
            this.input_to.Name = "input_to";
            this.input_to.Size = new System.Drawing.Size(800, 60);
            this.input_to.TabIndex = 4;
            // 
            // label_firealarm_log
            // 
            this.label_firealarm_log.AutoSize = true;
            this.label_firealarm_log.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firealarm_log.ForeColor = System.Drawing.Color.White;
            this.label_firealarm_log.Location = new System.Drawing.Point(18, 263);
            this.label_firealarm_log.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_firealarm_log.Name = "label_firealarm_log";
            this.label_firealarm_log.Size = new System.Drawing.Size(142, 25);
            this.label_firealarm_log.TabIndex = 3;
            this.label_firealarm_log.Text = "Fire Alarm Log";
            // 
            // label_engineerrequired_log
            // 
            this.label_engineerrequired_log.AutoSize = true;
            this.label_engineerrequired_log.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_engineerrequired_log.ForeColor = System.Drawing.Color.White;
            this.label_engineerrequired_log.Location = new System.Drawing.Point(19, 143);
            this.label_engineerrequired_log.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_engineerrequired_log.Name = "label_engineerrequired_log";
            this.label_engineerrequired_log.Size = new System.Drawing.Size(216, 25);
            this.label_engineerrequired_log.TabIndex = 2;
            this.label_engineerrequired_log.Text = "Engineer Required Log";
            // 
            // label_statechange_log
            // 
            this.label_statechange_log.AutoSize = true;
            this.label_statechange_log.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statechange_log.ForeColor = System.Drawing.Color.White;
            this.label_statechange_log.Location = new System.Drawing.Point(19, 23);
            this.label_statechange_log.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_statechange_log.Name = "label_statechange_log";
            this.label_statechange_log.Size = new System.Drawing.Size(168, 25);
            this.label_statechange_log.TabIndex = 1;
            this.label_statechange_log.Text = "State Change Log";
            // 
            // IWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 571);
            this.Controls.Add(this.btn_log_data);
            this.Controls.Add(this.lable_title);
            this.Controls.Add(this.background_panel);
            this.Name = "IWebService";
            this.Text = "IWebService";
            this.background_panel.ResumeLayout(false);
            this.background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_log_data;
        private System.Windows.Forms.Label lable_title;
        private New_Created_Tools.RoundEdgePanel background_panel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox input_to;
        private System.Windows.Forms.Label label_firealarm_log;
        private System.Windows.Forms.Label label_engineerrequired_log;
        private System.Windows.Forms.Label label_statechange_log;
    }
}