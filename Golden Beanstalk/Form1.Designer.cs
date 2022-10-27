namespace Golden_Beanstalk
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(82, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(514, 84);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "outputLabel";
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Gainsboro;
            this.option1Button.BackgroundImage = global::Golden_Beanstalk.Properties.Resources.Arrow;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(96, 446);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(52, 38);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Golden_Beanstalk.Properties.Resources.livingroom;
            this.pictureBox1.Location = new System.Drawing.Point(87, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Gainsboro;
            this.option2Button.BackgroundImage = global::Golden_Beanstalk.Properties.Resources.Arrow;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.ForeColor = System.Drawing.Color.Black;
            this.option2Button.Location = new System.Drawing.Point(96, 492);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(52, 38);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.Gainsboro;
            this.option3Button.BackgroundImage = global::Golden_Beanstalk.Properties.Resources.Arrow;
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Location = new System.Drawing.Point(96, 536);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(52, 38);
            this.option3Button.TabIndex = 4;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(170, 456);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(141, 28);
            this.option1Label.TabIndex = 5;
            this.option1Label.Text = "option1Label";
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(170, 502);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(147, 28);
            this.option2Label.TabIndex = 6;
            this.option2Label.Text = "option2Label";
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(170, 546);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(147, 28);
            this.option3Label.TabIndex = 7;
            this.option3Label.Text = "option3Label";
            this.option3Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(681, 595);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Golden Beanstalk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
    }
}

