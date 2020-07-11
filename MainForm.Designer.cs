

#region using statements


#endregion

namespace SubImageCreator
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this application.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button TakeScreenShotButton;
        private System.Windows.Forms.Button Canvas;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button CreateSubImagesButton;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TakeScreenShotButton = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CreateSubImagesButton = new System.Windows.Forms.Button();
            this.SubImage1 = new System.Windows.Forms.PictureBox();
            this.SubImage2 = new System.Windows.Forms.PictureBox();
            this.SubImage3 = new System.Windows.Forms.PictureBox();
            this.SubImage4 = new System.Windows.Forms.PictureBox();
            this.SubImage5 = new System.Windows.Forms.PictureBox();
            this.SubImage6 = new System.Windows.Forms.PictureBox();
            this.SubImage7 = new System.Windows.Forms.PictureBox();
            this.SubImage8 = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SubImagesCountLabel = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage8)).BeginInit();
            this.SuspendLayout();
            // 
            // TakeScreenShotButton
            // 
            this.TakeScreenShotButton.BackColor = System.Drawing.Color.Transparent;
            this.TakeScreenShotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TakeScreenShotButton.FlatAppearance.BorderSize = 0;
            this.TakeScreenShotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TakeScreenShotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TakeScreenShotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeScreenShotButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TakeScreenShotButton.Location = new System.Drawing.Point(13, 17);
            this.TakeScreenShotButton.Margin = new System.Windows.Forms.Padding(4);
            this.TakeScreenShotButton.Name = "TakeScreenShotButton";
            this.TakeScreenShotButton.Size = new System.Drawing.Size(212, 40);
            this.TakeScreenShotButton.TabIndex = 0;
            this.TakeScreenShotButton.Text = "Take Screenshot";
            this.TakeScreenShotButton.UseVisualStyleBackColor = false;
            this.TakeScreenShotButton.Click += new System.EventHandler(this.TakeScreenShotButton_Click);
            this.TakeScreenShotButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.TakeScreenShotButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Canvas
            // 
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Canvas.Location = new System.Drawing.Point(246, 71);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(800, 515);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.Click += new System.EventHandler(this.Canvas_Click);
            this.Canvas.MouseEnter += new System.EventHandler(this.Canvas_MouseEnter);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CountLabel.Location = new System.Drawing.Point(12, 105);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(113, 20);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "Sub Images:";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateSubImagesButton
            // 
            this.CreateSubImagesButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateSubImagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateSubImagesButton.FlatAppearance.BorderSize = 0;
            this.CreateSubImagesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateSubImagesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateSubImagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSubImagesButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateSubImagesButton.Location = new System.Drawing.Point(13, 550);
            this.CreateSubImagesButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateSubImagesButton.Name = "CreateSubImagesButton";
            this.CreateSubImagesButton.Size = new System.Drawing.Size(212, 40);
            this.CreateSubImagesButton.TabIndex = 0;
            this.CreateSubImagesButton.Text = "Search Sub Images";
            this.CreateSubImagesButton.UseVisualStyleBackColor = false;
            this.CreateSubImagesButton.Click += new System.EventHandler(this.SearchSubImages);
            this.CreateSubImagesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CreateSubImagesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage1
            // 
            this.SubImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage1.Location = new System.Drawing.Point(13, 141);
            this.SubImage1.Name = "SubImage1";
            this.SubImage1.Size = new System.Drawing.Size(96, 96);
            this.SubImage1.TabIndex = 2;
            this.SubImage1.TabStop = false;
            this.SubImage1.Visible = false;
            this.SubImage1.Click += new System.EventHandler(this.SubImage1_Click);
            this.SubImage1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage2
            // 
            this.SubImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage2.Location = new System.Drawing.Point(128, 141);
            this.SubImage2.Name = "SubImage2";
            this.SubImage2.Size = new System.Drawing.Size(96, 96);
            this.SubImage2.TabIndex = 2;
            this.SubImage2.TabStop = false;
            this.SubImage2.Visible = false;
            this.SubImage2.Click += new System.EventHandler(this.SubImage2_Click);
            this.SubImage2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage3
            // 
            this.SubImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage3.Location = new System.Drawing.Point(12, 243);
            this.SubImage3.Name = "SubImage3";
            this.SubImage3.Size = new System.Drawing.Size(96, 96);
            this.SubImage3.TabIndex = 2;
            this.SubImage3.TabStop = false;
            this.SubImage3.Visible = false;
            this.SubImage3.Click += new System.EventHandler(this.SubImage3_Click);
            this.SubImage3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage4
            // 
            this.SubImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage4.Location = new System.Drawing.Point(128, 243);
            this.SubImage4.Name = "SubImage4";
            this.SubImage4.Size = new System.Drawing.Size(96, 96);
            this.SubImage4.TabIndex = 2;
            this.SubImage4.TabStop = false;
            this.SubImage4.Visible = false;
            this.SubImage4.Click += new System.EventHandler(this.SubImage4_Click);
            this.SubImage4.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage4.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage5
            // 
            this.SubImage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage5.Location = new System.Drawing.Point(12, 345);
            this.SubImage5.Name = "SubImage5";
            this.SubImage5.Size = new System.Drawing.Size(96, 96);
            this.SubImage5.TabIndex = 2;
            this.SubImage5.TabStop = false;
            this.SubImage5.Visible = false;
            this.SubImage5.Click += new System.EventHandler(this.SubImage5_Click);
            this.SubImage5.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage5.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage6
            // 
            this.SubImage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage6.Location = new System.Drawing.Point(128, 345);
            this.SubImage6.Name = "SubImage6";
            this.SubImage6.Size = new System.Drawing.Size(96, 96);
            this.SubImage6.TabIndex = 2;
            this.SubImage6.TabStop = false;
            this.SubImage6.Visible = false;
            this.SubImage6.Click += new System.EventHandler(this.SubImage6_Click);
            this.SubImage6.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage6.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage7
            // 
            this.SubImage7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage7.Location = new System.Drawing.Point(12, 447);
            this.SubImage7.Name = "SubImage7";
            this.SubImage7.Size = new System.Drawing.Size(96, 96);
            this.SubImage7.TabIndex = 2;
            this.SubImage7.TabStop = false;
            this.SubImage7.Visible = false;
            this.SubImage7.Click += new System.EventHandler(this.SubImage7_Click);
            this.SubImage7.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage7.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SubImage8
            // 
            this.SubImage8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubImage8.Location = new System.Drawing.Point(128, 447);
            this.SubImage8.Name = "SubImage8";
            this.SubImage8.Size = new System.Drawing.Size(96, 96);
            this.SubImage8.TabIndex = 2;
            this.SubImage8.TabStop = false;
            this.SubImage8.Visible = false;
            this.SubImage8.Click += new System.EventHandler(this.SubImage8_Click);
            this.SubImage8.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SubImage8.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(246, 17);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 18);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Ready.";
            // 
            // SizeLabel
            // 
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SizeLabel.Location = new System.Drawing.Point(12, 75);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(113, 20);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Size:";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubImagesCountLabel
            // 
            this.SubImagesCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubImagesCountLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SubImagesCountLabel.Location = new System.Drawing.Point(127, 105);
            this.SubImagesCountLabel.Name = "SubImagesCountLabel";
            this.SubImagesCountLabel.Size = new System.Drawing.Size(46, 20);
            this.SubImagesCountLabel.TabIndex = 4;
            this.SubImagesCountLabel.Text = "0";
            this.SubImagesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(127, 71);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(52, 26);
            this.SizeComboBox.TabIndex = 6;
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InstructionsLabel.Location = new System.Drawing.Point(13, 601);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(294, 18);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Right click a sub image to remove.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 634);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.SubImagesCountLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SubImage8);
            this.Controls.Add(this.SubImage7);
            this.Controls.Add(this.SubImage6);
            this.Controls.Add(this.SubImage5);
            this.Controls.Add(this.SubImage4);
            this.Controls.Add(this.SubImage3);
            this.Controls.Add(this.SubImage2);
            this.Controls.Add(this.SubImage1);
            this.Controls.Add(this.CreateSubImagesButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.TakeScreenShotButton);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Image Creator";
            ((System.ComponentModel.ISupportInitialize)(this.SubImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubImage8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }
        #endregion

        #endregion

        private System.Windows.Forms.PictureBox SubImage1;
        private System.Windows.Forms.PictureBox SubImage2;
        private System.Windows.Forms.PictureBox SubImage3;
        private System.Windows.Forms.PictureBox SubImage4;
        private System.Windows.Forms.PictureBox SubImage5;
        private System.Windows.Forms.PictureBox SubImage6;
        private System.Windows.Forms.PictureBox SubImage7;
        private System.Windows.Forms.PictureBox SubImage8;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SubImagesCountLabel;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.Label InstructionsLabel;
    }
    #endregion

}
