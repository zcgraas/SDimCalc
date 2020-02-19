namespace Lab3
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtSurfaceArea = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(168, 74);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(90, 13);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius of sphere:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(264, 74);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(275, 100);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(32, 221);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(52, 13);
            this.lblDiameter.TabIndex = 4;
            this.lblDiameter.Text = "Diameter:";
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.AutoSize = true;
            this.lblSurfaceArea.Location = new System.Drawing.Point(12, 277);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(72, 13);
            this.lblSurfaceArea.TabIndex = 5;
            this.lblSurfaceArea.Text = "Surface Area:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(39, 330);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume:";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(91, 221);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 7;
            // 
            // txtSurfaceArea
            // 
            this.txtSurfaceArea.Location = new System.Drawing.Point(91, 277);
            this.txtSurfaceArea.Name = "txtSurfaceArea";
            this.txtSurfaceArea.Size = new System.Drawing.Size(100, 20);
            this.txtSurfaceArea.TabIndex = 8;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(91, 330);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox2.Location = new System.Drawing.Point(222, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtSurfaceArea);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblSurfaceArea);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtSurfaceArea;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

