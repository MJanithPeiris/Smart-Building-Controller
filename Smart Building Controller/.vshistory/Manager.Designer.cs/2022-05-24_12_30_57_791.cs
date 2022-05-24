
namespace Smart_Building_Controller
{
    partial class Manager
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
            this.roundEdgePanel1 = new Test_for_tdd.NewControls.RoundEdgePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundEdgePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundEdgePanel1
            // 
            this.roundEdgePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.roundEdgePanel1.BorderColor = System.Drawing.Color.White;
            this.roundEdgePanel1.Controls.Add(this.label1);
            this.roundEdgePanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roundEdgePanel1.Location = new System.Drawing.Point(900, 12);
            this.roundEdgePanel1.Name = "roundEdgePanel1";
            this.roundEdgePanel1.Radius = 30;
            this.roundEdgePanel1.Size = new System.Drawing.Size(250, 75);
            this.roundEdgePanel1.TabIndex = 0;
            this.roundEdgePanel1.Thickness = 2F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Required Engineer\r\nNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.roundEdgePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager";
            this.Text = "Manager";
            this.roundEdgePanel1.ResumeLayout(false);
            this.roundEdgePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Test_for_tdd.NewControls.RoundEdgePanel roundEdgePanel1;
        private System.Windows.Forms.Label label1;
    }
}