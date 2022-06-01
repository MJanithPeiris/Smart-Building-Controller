
namespace Smart_Building_Controller
{
    partial class IEmailService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEmailService));
            this.background_panel = new Smart_Building_Controller.New_Created_Tools.RoundEdgePanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.input_to = new System.Windows.Forms.TextBox();
            this.label_email_message = new System.Windows.Forms.Label();
            this.label_email_subject = new System.Windows.Forms.Label();
            this.label_email_to = new System.Windows.Forms.Label();
            this.lable_title = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_panel
            // 
            this.background_panel.BackColor = System.Drawing.Color.Black;
            this.background_panel.BorderColor = System.Drawing.Color.Black;
            this.background_panel.Controls.Add(this.textBox2);
            this.background_panel.Controls.Add(this.textBox3);
            this.background_panel.Controls.Add(this.input_to);
            this.background_panel.Controls.Add(this.label_email_message);
            this.background_panel.Controls.Add(this.label_email_subject);
            this.background_panel.Controls.Add(this.label_email_to);
            this.background_panel.ForeColor = System.Drawing.Color.Black;
            this.background_panel.Location = new System.Drawing.Point(112, 70);
            this.background_panel.Margin = new System.Windows.Forms.Padding(2);
            this.background_panel.Name = "background_panel";
            this.background_panel.Radius = 20;
            this.background_panel.Size = new System.Drawing.Size(650, 463);
            this.background_panel.TabIndex = 6;
            this.background_panel.Thickness = 5F;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(111, 90);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(510, 35);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(22, 185);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(601, 258);
            this.textBox3.TabIndex = 6;
            // 
            // input_to
            // 
            this.input_to.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_to.Location = new System.Drawing.Point(76, 25);
            this.input_to.Margin = new System.Windows.Forms.Padding(2);
            this.input_to.Multiline = true;
            this.input_to.Name = "input_to";
            this.input_to.Size = new System.Drawing.Size(545, 35);
            this.input_to.TabIndex = 4;
            // 
            // label_email_message
            // 
            this.label_email_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_message.ForeColor = System.Drawing.Color.White;
            this.label_email_message.Location = new System.Drawing.Point(19, 157);
            this.label_email_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email_message.Name = "label_email_message";
            this.label_email_message.Size = new System.Drawing.Size(99, 32);
            this.label_email_message.TabIndex = 3;
            this.label_email_message.Text = "MESSAGE";
            // 
            // label_email_subject
            // 
            this.label_email_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_subject.ForeColor = System.Drawing.Color.White;
            this.label_email_subject.Location = new System.Drawing.Point(19, 98);
            this.label_email_subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email_subject.Name = "label_email_subject";
            this.label_email_subject.Size = new System.Drawing.Size(88, 32);
            this.label_email_subject.TabIndex = 2;
            this.label_email_subject.Text = "SUBJECT";
            // 
            // label_email_to
            // 
            this.label_email_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_to.ForeColor = System.Drawing.Color.White;
            this.label_email_to.Location = new System.Drawing.Point(20, 33);
            this.label_email_to.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email_to.Name = "label_email_to";
            this.label_email_to.Size = new System.Drawing.Size(32, 23);
            this.label_email_to.TabIndex = 1;
            this.label_email_to.Text = "TO";
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.BackColor = System.Drawing.Color.Transparent;
            this.lable_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_title.Location = new System.Drawing.Point(33, 19);
            this.lable_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(250, 45);
            this.lable_title.TabIndex = 7;
            this.lable_title.Text = "EMAIL SERVICE";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(768, 512);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(93, 39);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // IEmailService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 571);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lable_title);
            this.Controls.Add(this.background_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IEmailService";
            this.Text = "IEmailService";
            this.background_panel.ResumeLayout(false);
            this.background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Smart_Building_Controller.New_Created_Tools.RoundEdgePanel background_panel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox input_to;
        private System.Windows.Forms.Label label_email_message;
        private System.Windows.Forms.Label label_email_subject;
        private System.Windows.Forms.Label label_email_to;
        private System.Windows.Forms.Label lable_title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_send;
    }
}