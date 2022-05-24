
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
            this.lbl_required_engineer = new System.Windows.Forms.Label();
            this.roundEdgePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundEdgePanel1
            // 
            this.roundEdgePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.roundEdgePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.roundEdgePanel1.Controls.Add(this.lbl_required_engineer);
            this.roundEdgePanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roundEdgePanel1.Location = new System.Drawing.Point(900, 12);
            this.roundEdgePanel1.Name = "roundEdgePanel1";
            this.roundEdgePanel1.Radius = 20;
            this.roundEdgePanel1.Size = new System.Drawing.Size(250, 75);
            this.roundEdgePanel1.TabIndex = 0;
            this.roundEdgePanel1.Thickness = 5F;
            // 
            // lbl_required_engineer
            // 
            this.lbl_required_engineer.AutoSize = true;
            this.lbl_required_engineer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_required_engineer.ForeColor = System.Drawing.Color.White;
            this.lbl_required_engineer.Location = new System.Drawing.Point(28, 12);
            this.lbl_required_engineer.Name = "lbl_required_engineer";
            this.lbl_required_engineer.Size = new System.Drawing.Size(186, 56);
            this.lbl_required_engineer.TabIndex = 0;
            this.lbl_required_engineer.Text = "Required Engineer\r\nNO";
            this.lbl_required_engineer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        private System.Windows.Forms.Label lbl_required_engineer;
    }
}