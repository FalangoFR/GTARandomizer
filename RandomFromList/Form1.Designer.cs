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
            btnRandomWeapon = new Button();
            txtResult = new TextBox();
            btnRandomVehicle = new Button();
            btnRandomGame = new Button();
            SuspendLayout();
            // 
            // btnRandomWeapon
            // 
            btnRandomWeapon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRandomWeapon.Location = new Point(14, 73);
            btnRandomWeapon.Margin = new Padding(3, 4, 3, 4);
            btnRandomWeapon.Name = "btnRandomWeapon";
            btnRandomWeapon.Size = new Size(143, 33);
            btnRandomWeapon.TabIndex = 0;
            btnRandomWeapon.Text = "Random Weapon";
            btnRandomWeapon.UseVisualStyleBackColor = true;
            btnRandomWeapon.Click += btnRandomWeapon_Click;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Location = new Point(14, 35);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(297, 27);
            txtResult.TabIndex = 1;
            // 
            // btnRandomVehicle
            // 
            btnRandomVehicle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRandomVehicle.Location = new Point(168, 73);
            btnRandomVehicle.Margin = new Padding(3, 4, 3, 4);
            btnRandomVehicle.Name = "btnRandomVehicle";
            btnRandomVehicle.Size = new Size(143, 33);
            btnRandomVehicle.TabIndex = 2;
            btnRandomVehicle.Text = "Random Vehicle";
            btnRandomVehicle.UseVisualStyleBackColor = true;
            btnRandomVehicle.Click += btnRandomCar_Click;
            // 
            // btnRandomGame
            // 
            btnRandomGame.Location = new Point(102, 113);
            btnRandomGame.Name = "btnRandomGame";
            btnRandomGame.Size = new Size(119, 29);
            btnRandomGame.TabIndex = 3;
            btnRandomGame.Text = "Random Game";
            btnRandomGame.UseVisualStyleBackColor = true;
            btnRandomGame.Click += btnRandomGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(325, 151);
            Controls.Add(btnRandomGame);
            Controls.Add(btnRandomVehicle);
            Controls.Add(txtResult);
            Controls.Add(btnRandomWeapon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Random Weapon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRandomWeapon;
        private TextBox txtResult;
        private Button btnRandomVehicle;
        private Button btnRandomGame;
    }
}