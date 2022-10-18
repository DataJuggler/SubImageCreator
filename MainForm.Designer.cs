
namespace SubImageCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceImageControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.RowsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.ColumnsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.CreateSubImagesButton = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.HeightControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.WidthControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.ImageWidthControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ImageHeightControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.StartImage = new System.Windows.Forms.PictureBox();
            this.OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ImageNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceImageControl
            // 
            this.SourceImageControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceImageControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SourceImageControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.SourceImageControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SourceImageControl.ButtonImage")));
            this.SourceImageControl.ButtonWidth = 48;
            this.SourceImageControl.DarkMode = false;
            this.SourceImageControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SourceImageControl.Editable = false;
            this.SourceImageControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SourceImageControl.Filter = null;
            this.SourceImageControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceImageControl.HideBrowseButton = false;
            this.SourceImageControl.LabelBottomMargin = 0;
            this.SourceImageControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceImageControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SourceImageControl.LabelText = "File To Parse:";
            this.SourceImageControl.LabelTopMargin = 0;
            this.SourceImageControl.LabelWidth = 140;
            this.SourceImageControl.Location = new System.Drawing.Point(44, 21);
            this.SourceImageControl.Name = "SourceImageControl";
            this.SourceImageControl.OnTextChangedListener = null;
            this.SourceImageControl.OpenCallback = null;
            this.SourceImageControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceImageControl.SelectedPath = null;
            this.SourceImageControl.Size = new System.Drawing.Size(731, 32);
            this.SourceImageControl.StartPath = null;
            this.SourceImageControl.TabIndex = 0;
            this.SourceImageControl.TextBoxBottomMargin = 0;
            this.SourceImageControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SourceImageControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SourceImageControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceImageControl.TextBoxTopMargin = 0;
            this.SourceImageControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // RowsControl
            // 
            this.RowsControl.BackColor = System.Drawing.Color.Transparent;
            this.RowsControl.BottomMargin = 0;
            this.RowsControl.Editable = true;
            this.RowsControl.Encrypted = false;
            this.RowsControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RowsControl.Inititialized = true;
            this.RowsControl.LabelBottomMargin = 0;
            this.RowsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.RowsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RowsControl.LabelText = "Rows:";
            this.RowsControl.LabelTopMargin = 0;
            this.RowsControl.LabelWidth = 160;
            this.RowsControl.Location = new System.Drawing.Point(362, 121);
            this.RowsControl.MultiLine = false;
            this.RowsControl.Name = "RowsControl";
            this.RowsControl.OnTextChangedListener = null;
            this.RowsControl.PasswordMode = false;
            this.RowsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RowsControl.Size = new System.Drawing.Size(281, 32);
            this.RowsControl.TabIndex = 1;
            this.RowsControl.TextBoxBottomMargin = 0;
            this.RowsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.RowsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.RowsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RowsControl.TextBoxTopMargin = 0;
            this.RowsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.RowsControl.Visible = false;
            // 
            // ColumnsControl
            // 
            this.ColumnsControl.BackColor = System.Drawing.Color.Transparent;
            this.ColumnsControl.BottomMargin = 0;
            this.ColumnsControl.Editable = true;
            this.ColumnsControl.Encrypted = false;
            this.ColumnsControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnsControl.Inititialized = true;
            this.ColumnsControl.LabelBottomMargin = 0;
            this.ColumnsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ColumnsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColumnsControl.LabelText = "Columns:";
            this.ColumnsControl.LabelTopMargin = 0;
            this.ColumnsControl.LabelWidth = 160;
            this.ColumnsControl.Location = new System.Drawing.Point(362, 171);
            this.ColumnsControl.MultiLine = false;
            this.ColumnsControl.Name = "ColumnsControl";
            this.ColumnsControl.OnTextChangedListener = null;
            this.ColumnsControl.PasswordMode = false;
            this.ColumnsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ColumnsControl.Size = new System.Drawing.Size(281, 32);
            this.ColumnsControl.TabIndex = 2;
            this.ColumnsControl.TextBoxBottomMargin = 0;
            this.ColumnsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ColumnsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ColumnsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnsControl.TextBoxTopMargin = 0;
            this.ColumnsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.ColumnsControl.Visible = false;
            // 
            // CreateSubImagesButton
            // 
            this.CreateSubImagesButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateSubImagesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateSubImagesButton.BackgroundImage")));
            this.CreateSubImagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateSubImagesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateSubImagesButton.FlatAppearance.BorderSize = 0;
            this.CreateSubImagesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateSubImagesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateSubImagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSubImagesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateSubImagesButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CreateSubImagesButton.Location = new System.Drawing.Point(294, 355);
            this.CreateSubImagesButton.Name = "CreateSubImagesButton";
            this.CreateSubImagesButton.Size = new System.Drawing.Size(231, 44);
            this.CreateSubImagesButton.TabIndex = 3;
            this.CreateSubImagesButton.Text = "Create Sub Images";
            this.CreateSubImagesButton.UseVisualStyleBackColor = false;
            this.CreateSubImagesButton.Visible = false;
            this.CreateSubImagesButton.Click += new System.EventHandler(this.CreateSubImagesButton_Click);
            this.CreateSubImagesButton.MouseEnter += new System.EventHandler(this.CreateSubImagesButton_MouseEnter);
            this.CreateSubImagesButton.MouseLeave += new System.EventHandler(this.CreateSubImagesButton_MouseLeave);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(53, 422);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(712, 23);
            this.Graph.TabIndex = 4;
            this.Graph.Visible = false;
            // 
            // HeightControl
            // 
            this.HeightControl.BackColor = System.Drawing.Color.Transparent;
            this.HeightControl.BottomMargin = 0;
            this.HeightControl.Editable = true;
            this.HeightControl.Encrypted = false;
            this.HeightControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightControl.Inititialized = true;
            this.HeightControl.LabelBottomMargin = 0;
            this.HeightControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.HeightControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeightControl.LabelText = "Height:";
            this.HeightControl.LabelTopMargin = 0;
            this.HeightControl.LabelWidth = 160;
            this.HeightControl.Location = new System.Drawing.Point(30, 121);
            this.HeightControl.MultiLine = false;
            this.HeightControl.Name = "HeightControl";
            this.HeightControl.OnTextChangedListener = null;
            this.HeightControl.PasswordMode = false;
            this.HeightControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HeightControl.Size = new System.Drawing.Size(281, 32);
            this.HeightControl.TabIndex = 5;
            this.HeightControl.TextBoxBottomMargin = 0;
            this.HeightControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.HeightControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.HeightControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightControl.TextBoxTopMargin = 0;
            this.HeightControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.HeightControl.Visible = false;
            // 
            // WidthControl
            // 
            this.WidthControl.BackColor = System.Drawing.Color.Transparent;
            this.WidthControl.BottomMargin = 0;
            this.WidthControl.Editable = true;
            this.WidthControl.Encrypted = false;
            this.WidthControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthControl.Inititialized = true;
            this.WidthControl.LabelBottomMargin = 0;
            this.WidthControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.WidthControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WidthControl.LabelText = "Width:";
            this.WidthControl.LabelTopMargin = 0;
            this.WidthControl.LabelWidth = 160;
            this.WidthControl.Location = new System.Drawing.Point(30, 171);
            this.WidthControl.MultiLine = false;
            this.WidthControl.Name = "WidthControl";
            this.WidthControl.OnTextChangedListener = null;
            this.WidthControl.PasswordMode = false;
            this.WidthControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WidthControl.Size = new System.Drawing.Size(281, 32);
            this.WidthControl.TabIndex = 6;
            this.WidthControl.TextBoxBottomMargin = 0;
            this.WidthControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.WidthControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.WidthControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthControl.TextBoxTopMargin = 0;
            this.WidthControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.WidthControl.Visible = false;
            // 
            // ImageWidthControl
            // 
            this.ImageWidthControl.BackColor = System.Drawing.Color.Transparent;
            this.ImageWidthControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageWidthControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImageWidthControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ImageWidthControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImageWidthControl.LabelText = "Image Width:";
            this.ImageWidthControl.LabelWidth = 160;
            this.ImageWidthControl.Location = new System.Drawing.Point(30, 71);
            this.ImageWidthControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ImageWidthControl.Name = "ImageWidthControl";
            this.ImageWidthControl.Size = new System.Drawing.Size(281, 32);
            this.ImageWidthControl.TabIndex = 7;
            this.ImageWidthControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ImageWidthControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageWidthControl.Visible = false;
            // 
            // ImageHeightControl
            // 
            this.ImageHeightControl.BackColor = System.Drawing.Color.Transparent;
            this.ImageHeightControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageHeightControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImageHeightControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ImageHeightControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImageHeightControl.LabelText = "Image height:";
            this.ImageHeightControl.LabelWidth = 160;
            this.ImageHeightControl.Location = new System.Drawing.Point(362, 71);
            this.ImageHeightControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ImageHeightControl.Name = "ImageHeightControl";
            this.ImageHeightControl.Size = new System.Drawing.Size(281, 32);
            this.ImageHeightControl.TabIndex = 8;
            this.ImageHeightControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ImageHeightControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageHeightControl.Visible = false;
            // 
            // StartImage
            // 
            this.StartImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartImage.BackgroundImage")));
            this.StartImage.Location = new System.Drawing.Point(90, 120);
            this.StartImage.Name = "StartImage";
            this.StartImage.Size = new System.Drawing.Size(640, 160);
            this.StartImage.TabIndex = 9;
            this.StartImage.TabStop = false;
            // 
            // OutputFolderControl
            // 
            this.OutputFolderControl.BackColor = System.Drawing.Color.Transparent;
            this.OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.OutputFolderControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.OutputFolderControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("OutputFolderControl.ButtonImage")));
            this.OutputFolderControl.ButtonWidth = 48;
            this.OutputFolderControl.DarkMode = false;
            this.OutputFolderControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.Editable = false;
            this.OutputFolderControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.Filter = null;
            this.OutputFolderControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.HideBrowseButton = false;
            this.OutputFolderControl.LabelBottomMargin = 0;
            this.OutputFolderControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.OutputFolderControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.LabelText = "Output Folder:";
            this.OutputFolderControl.LabelTopMargin = 0;
            this.OutputFolderControl.LabelWidth = 140;
            this.OutputFolderControl.Location = new System.Drawing.Point(44, 221);
            this.OutputFolderControl.Name = "OutputFolderControl";
            this.OutputFolderControl.OnTextChangedListener = null;
            this.OutputFolderControl.OpenCallback = null;
            this.OutputFolderControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputFolderControl.SelectedPath = null;
            this.OutputFolderControl.Size = new System.Drawing.Size(731, 32);
            this.OutputFolderControl.StartPath = null;
            this.OutputFolderControl.TabIndex = 10;
            this.OutputFolderControl.TextBoxBottomMargin = 0;
            this.OutputFolderControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.TextBoxTopMargin = 0;
            this.OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ImageNameControl
            // 
            this.ImageNameControl.BackColor = System.Drawing.Color.Transparent;
            this.ImageNameControl.BottomMargin = 0;
            this.ImageNameControl.Editable = true;
            this.ImageNameControl.Encrypted = false;
            this.ImageNameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageNameControl.Inititialized = true;
            this.ImageNameControl.LabelBottomMargin = 0;
            this.ImageNameControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ImageNameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImageNameControl.LabelText = "* Image Name:";
            this.ImageNameControl.LabelTopMargin = 0;
            this.ImageNameControl.LabelWidth = 160;
            this.ImageNameControl.Location = new System.Drawing.Point(24, 271);
            this.ImageNameControl.MultiLine = false;
            this.ImageNameControl.Name = "ImageNameControl";
            this.ImageNameControl.OnTextChangedListener = null;
            this.ImageNameControl.PasswordMode = false;
            this.ImageNameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ImageNameControl.Size = new System.Drawing.Size(751, 32);
            this.ImageNameControl.TabIndex = 11;
            this.ImageNameControl.TextBoxBottomMargin = 0;
            this.ImageNameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ImageNameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ImageNameControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageNameControl.TextBoxTopMargin = 0;
            this.ImageNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // InfoLabel
            // 
            this.InfoLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InfoLabel.Location = new System.Drawing.Point(44, 299);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(731, 32);
            this.InfoLabel.TabIndex = 12;
            this.InfoLabel.Text = "* Files will be created as ImageName1, ImageName2, etc.";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(819, 466);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ImageNameControl);
            this.Controls.Add(this.OutputFolderControl);
            this.Controls.Add(this.StartImage);
            this.Controls.Add(this.ImageHeightControl);
            this.Controls.Add(this.ImageWidthControl);
            this.Controls.Add(this.WidthControl);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.CreateSubImagesButton);
            this.Controls.Add(this.ColumnsControl);
            this.Controls.Add(this.RowsControl);
            this.Controls.Add(this.SourceImageControl);
            this.Controls.Add(this.HeightControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Image Creator 1.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceImageControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl RowsControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl ColumnsControl;
        private System.Windows.Forms.Button CreateSubImagesButton;
        private System.Windows.Forms.ProgressBar Graph;
        private DataJuggler.Win.Controls.LabelTextBoxControl HeightControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl WidthControl;
        private DataJuggler.Win.Controls.LabelLabelControl ImageWidthControl;
        private DataJuggler.Win.Controls.LabelLabelControl ImageHeightControl;
        private System.Windows.Forms.PictureBox StartImage;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl ImageNameControl;
        private System.Windows.Forms.Label InfoLabel;
    }
}

