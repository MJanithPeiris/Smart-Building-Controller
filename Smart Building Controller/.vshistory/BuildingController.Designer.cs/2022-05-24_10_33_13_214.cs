
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
            this.roundEdgePanel1 = new Test_for_tdd.NewControls.RoundEdgePanel();
            this.SuspendLayout();
            // 
            // roundEdgePanel1
            // 
            this.roundEdgePanel1.BorderColor = System.Drawing.Color.White;
            this.roundEdgePanel1.Location = new System.Drawing.Point(430, 94);
            this.roundEdgePanel1.Name = "roundEdgePanel1";
            this.roundEdgePanel1.Radius = 30;
            this.roundEdgePanel1.Size = new System.Drawing.Size(200, 100);
            this.roundEdgePanel1.TabIndex = 0;
            this.roundEdgePanel1.Thickness = 5F;
            // 
            // BuildingController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.roundEdgePanel1);
            this.Name = "BuildingController";
            this.Text = "Building Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private Test_for_tdd.NewControls.RoundEdgePanel roundEdgePanel1;
    }
}

