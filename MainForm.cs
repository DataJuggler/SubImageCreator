

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.PixelDatabase;
using System;
using System.Drawing;
using System.Windows.Forms;
using DataJuggler.UltimateHelper;
using System.IO;

#endregion

namespace SubImageCreator
{

    #region class MainForm
    /// <summary>
    /// This is the MainForm for this application.
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {
        
        #region Private Variables
        private PixelDatabase pixelDatabase;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
            
            // Setup the listener
            this.SourceImageControl.OnTextChangedListener = this;
            this.HeightControl.OnTextChangedListener = this;
            this.WidthControl.OnTextChangedListener = this;

            UIEnable();
        }
        #endregion

        #region Events
            
            #region CreateSubImagesButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateSubImagesButton' is clicked.
            /// </summary>
            private void CreateSubImagesButton_Click(object sender, EventArgs e)
            {
                try
                {
                    // locals
                    string imagePath = this.SourceImageControl.Text;
                    int imageNumber = 0;
                    int top = 0;
                    int left = 0;
                    string fileName = "";
                    Point topLeft;
                    Rectangle size = new Rectangle(0, 0, this.WidthControl.IntValue, this.HeightControl.IntValue);
                    PixelDatabase pixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(imagePath, Refresh);
                    int rows = RowsControl.IntValue;
                    int columns = ColumnsControl.IntValue;
                    Graph.Maximum = rows * columns;
                    int height = HeightControl.IntValue;
                    int width = WidthControl.IntValue;

                    // Get the extension
                    FileInfo fileInfo = new FileInfo(imagePath);
                
                    // iterate the rows
                    for (int row = 0; row < RowsControl.IntValue; row++)
                    {
                        // iterate the columns
                        for (int column = 0; column < HeightControl.IntValue; column++)
                        {
                            // Increment the value for imageNumber
                            imageNumber++;
                        
                            left = column * width;
                            top = row * width;
                            topLeft = new Point(left, top);
                            size = new Rectangle(left, top, width, height);

                            // create the subImage
                            Image image = pixelDatabase.CreateSubImage(topLeft, size);

                            // get the new file name without the extension
                            string imageName = this.ImageNameControl.Text.Replace(fileInfo.Extension, "");

                            // set the fileName
                            fileName = Path.Combine(this.OutputFolderControl.Text, imageName + imageNumber + fileInfo.Extension);

                            // Save the file
                            image.Save(fileName);

                            Graph.Value = imageNumber;
                            Graph.Refresh();
                            Application.DoEvents();
                        }
                    }

                    // Show the user a message
                    MessageBox.Show("The sub images have been created.", "Success");
                }
                catch (Exception error)
                {
                    // show the user a message
                    MessageBox.Show("An error occurred processing your image", "Oops. Something went wrong.");

                    // for debugging only
                    DebugHelper.WriteDebugError("CreateSubImagesButton_Click", this.Name, error);
                }
            }
            #endregion

            #region CreateSubImagesButton_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Create Sub Images Button _ Mouse Enter
            /// </summary>
            private void CreateSubImagesButton_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region CreateSubImagesButton_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Create Sub Images Button _ Mouse Leave
            /// </summary>
            private void CreateSubImagesButton_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                try
                {
                    if (sender.Name == this.SourceImageControl.Name)
                    {
                        // Load the PixelDatabase
                        this.PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(text, Refresh);

                        // if the value for HasPixelDatabase is true
                        if (HasPixelDatabase)
                        {
                            // display the height and width
                            this.ImageHeightControl.Text = PixelDatabase.Height.ToString();
                            this.ImageWidthControl.Text = PixelDatabase.Width.ToString();

                            // Display the name as a helper
                            FileInfo fileInfo = new FileInfo(text);
                            this.ImageNameControl.Text = fileInfo.Name;
                        }
                    }
                    else if (sender.Name == this.WidthControl.Name)
                    {
                        if (HasPixelDatabase)
                        {
                            // get the rows
                            double columns = PixelDatabase.Width / WidthControl.IntValue;

                            // Display the rows
                            this.ColumnsControl.Text = this.Text = Math.Floor(columns).ToString();
                        }
                    }
                    else if (sender.Name == this.HeightControl.Name)
                    {
                        // if the value for HasPixelDatabase is true
                        if (HasPixelDatabase)
                        {
                            // get the columns
                            double rows = PixelDatabase.Height / HeightControl.IntValue;

                            // Display the columns
                            this.RowsControl.Text = this.Text = Math.Floor(rows).ToString();
                        }
                    }
                }
                catch (Exception error)
                {
                    // for debugging only for now
                    DebugHelper.WriteDebugError("OnTextChanged", this.Name, error);
                }

                // Show or hide controls
                UIEnable();
            }
            #endregion
            
        #endregion

        #region Methods

            #region Refresh()
            /// <summary>
            /// This method Refresh
            /// </summary>
            public static void Refresh(string message, int pixelsUpdated)
            {
                
            }
            #endregion
    
            #region UIEnable()
            /// <summary>
            /// This method UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Show if we dnot have a pixel database
                this.StartImage.Visible = !HasPixelDatabase;
                this.ImageHeightControl.Visible = HasPixelDatabase;
                this.ImageWidthControl.Visible = HasPixelDatabase;
                this.RowsControl.Visible = HasPixelDatabase;
                this.ColumnsControl.Visible = HasPixelDatabase;
                this.HeightControl.Visible = HasPixelDatabase;
                this.WidthControl.Visible = HasPixelDatabase;
                this.CreateSubImagesButton.Visible = HasPixelDatabase;
                this.Graph.Visible = HasPixelDatabase;
                this.OutputFolderControl.Visible = HasPixelDatabase;
                this.ImageNameControl.Visible = HasPixelDatabase;
                this.InfoLabel.Visible = HasPixelDatabase;
            }
            #endregion
            
        #endregion

        #region Properties
            
            #region HasPixelDatabase
            /// <summary>
            /// This property returns true if this object has a 'PixelDatabase'.
            /// </summary>
            public bool HasPixelDatabase
            {
                get
                {
                    // initial value
                    bool hasPixelDatabase = (this.PixelDatabase != null);
                    
                    // return value
                    return hasPixelDatabase;
                }
            }
            #endregion
            
            #region PixelDatabase
            /// <summary>
            /// This property gets or sets the value for 'PixelDatabase'.
            /// </summary>
            public PixelDatabase PixelDatabase
            {
                get { return pixelDatabase; }
                set { pixelDatabase = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
