
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
            this.background_panel.BorderColor = System.Drawing.Color.White;
            this.background_panel.Controls.Add(this.textBox2);
            this.background_panel.Controls.Add(this.textBox3);
            this.background_panel.Controls.Add(this.input_to);
            this.background_panel.Controls.Add(this.label_email_message);
            this.background_panel.Controls.Add(this.label_email_subject);
            this.background_panel.Controls.Add(this.label_email_to);
            this.background_panel.ForeColor = System.Drawing.Color.Black;
            this.background_panel.Location = new System.Drawing.Point(137, 78);
            this.background_panel.Name = "background_panel";
            this.background_panel.Radius = 30;
            this.background_panel.Size = new System.Drawing.Size(866, 570);
            this.background_panel.TabIndex = 6;
            this.background_panel.Thickness = 5F;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(177, 111);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(649, 59);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(30, 228);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(800, 316);
            this.textBox3.TabIndex = 6;
            // 
            // input_to
            // 
            this.input_to.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_to.Location = new System.Drawing.Point(104, 37);
            this.input_to.Multiline = true;
            this.input_to.Name = "input_to";
            this.input_to.Size = new System.Drawing.Size(722, 53);
            this.input_to.TabIndex = 4;
            // 
            // label_email_message
            // 
            this.label_email_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_message.ForeColor = System.Drawing.Color.White;
            this.label_email_message.Location = new System.Drawing.Point(25, 194);
            this.label_email_message.Name = "label_email_message";
            this.label_email_message.Size = new System.Drawing.Size(132, 40);
            this.label_email_message.TabIndex = 3;
            this.label_email_message.Text = "MESSAGE";
            // 
            // label_email_subject
            // 
            this.label_email_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_subject.ForeColor = System.Drawing.Color.White;
            this.label_email_subject.Location = new System.Drawing.Point(25, 121);
            this.label_email_subject.Name = "label_email_subject";
            this.label_email_subject.Size = new System.Drawing.Size(118, 40);
            this.label_email_subject.TabIndex = 2;
            this.label_email_subject.Text = "SUBJECT";
            // 
            // label_email_to
            // 
            this.label_email_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_to.ForeColor = System.Drawing.Color.White;
            this.label_email_to.Location = new System.Drawing.Point(34, 35);
            this.label_email_to.Name = "label_email_to";
            this.label_email_to.Size = new System.Drawing.Size(38, 40);
            this.label_email_to.TabIndex = 1;
            this.label_email_to.Text = "TO";
            // 
            // lable_title
            // 
            this.lable_title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_title.Location = new System.Drawing.Point(12, 13);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(562, 60);
            this.lable_title.TabIndex = 7;
            this.lable_title.Text = "MAIL SERVICE";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(1009, 615);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(134, 60);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // IEmailService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lable_title);
            this.Controls.Add(this.background_panel);
            this.Name = "IEmailService";
            this.Text = "IEmailService";
            this.background_panel.ResumeLayout(false);
            this.background_panel.PerformLayout();
            this.ResumeLayout(false);

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