namespace RandomFromList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRandomVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandom.Location = new System.Drawing.Point(12, 55);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(125, 25);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random Weapon";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(260, 23);
            this.txtResult.TabIndex = 1;
            // 
            // btnRandomVehicle
            // 
            this.btnRandomVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandomVehicle.Location = new System.Drawing.Point(147, 55);
            this.btnRandomVehicle.Name = "btnRandomVehicle";
            this.btnRandomVehicle.Size = new System.Drawing.Size(125, 25);
            this.btnRandomVehicle.TabIndex = 2;
            this.btnRandomVehicle.Text = "Random Vehicle";
            this.btnRandomVehicle.UseVisualStyleBackColor = true;
            this.btnRandomVehicle.Click += new System.EventHandler(this.btnRandomCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.btnRandomVehicle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.Text = "Random Weapon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRandom;
        private TextBox txtResult;
        private Button btnRandomVehicle;
    }
}