

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.PixelDatabase;
using DataJuggler.UltimateHelper.Core;

#endregion

namespace SubImageCreator
{

    #region class MainForm
    /// <summary>
    /// This is the MainForm of this application
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private PixelDatabase pixelDatabase;
        private int subImageSize;
        private List<Bitmap> subImages;
        private bool searchMode;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
            
            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region Canvas_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'Canvas' is clicked.
            /// </summary>
            private void Canvas_Click(object sender, EventArgs e)
            {
                // Cast the event args as MouseEventArgs
                MouseEventArgs e2 = (MouseEventArgs) e;
                
                // if we already have the subimages
                if (SubImagesCount >= 8)
                {
                    // set the value
                    this.StatusLabel.Text = "8 is the maximum sub images";
                }
                else
                {
                    // if the value for HasPixelDatabase is true
                    if (HasPixelDatabase)
                    {
                        // locals
                        int x = e2.X;
                        int y = e2.Y;
                        
                        // for debugging only
                        int originalX = x;
                        int originalY = y;
                        
                        // Get the current image
                        Image image = this.Canvas.BackgroundImage;
                        Bitmap bitmap = new Bitmap(image);
                        
                        // x & y must now be scaled
                        double canvasWidth = this.Canvas.Width;
                        double canvasHeight = this.Canvas.Height;
                        double bitmapWidth = bitmap.Width;
                        double bitmapHeight = bitmap.Height;
                        
                        // get the xScale and the yScale
                        double scaleX = bitmapWidth / canvasWidth;
                        double scaleY = bitmapHeight / canvasHeight;
                        double doubleX = (double) x;
                        double doubleY = (double) y;
                        
                        // reset the values
                        x = (int) (doubleX * scaleX);
                        y = (int) (doubleY * scaleY);
                        
                        // ensure x is in range
                        if (x < 0)
                        {
                            // reset x
                            x = 0;
                        }
                        
                        // ensure x is in range
                        if (x >= bitmap.Width)
                        {
                            // reset x
                            x = bitmap.Width -1;
                        }
                        
                        // ensure y is in range
                        if (y < 0)
                        {
                            // reset y
                            y = 0;
                        }
                        
                        // ensure y is in range
                        if (y >= bitmap.Height)
                        {
                            // reset y
                            y = bitmap.Height - 1;
                        }
                        
                        // Sometimes rounding makes it off a pixel or two possibly
                        // here we have (approximately) the x & y clicked.
                        
                        // SubImageSize is just an int such as 64, 256. 
                        // It must be smaller than the source image, or course.

                        // Top left point
                        Point topLeft = new Point(x, y);
                        
                        // Size of the new image
                        Rectangle size = new Rectangle(0, 0, SubImageSize, SubImageSize);
                        
                        // Create a subImage
                        Bitmap subImage = PixelDatabase.CreateSubImage(topLeft, size);
                        
                        // If the subImage object exists
                        if (subImage != null)
                        {
                            // Add
                            this.SubImages.Add(subImage);
                            
                            // Display the SubImages
                            DisplaySubImages();
                        }
                    }
                }
            }
            #endregion

            #region Canvas_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Canvas _ Mouse Enter
            /// </summary>
            private void Canvas_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Canvas_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Canvas _ Mouse Leave
            /// </summary>
            private void Canvas_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region SearchSubImages(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Search Sub Images
            /// </summary>
            private void SearchSubImages(object sender, EventArgs e)
            {
                // Toggle the value for SearchMode
                SearchMode = !SearchMode;

                // change the text of the labels
                this.InstructionsLabel.Text = "Left click a sub image to search.";

                // if the value for SearchMode is true
                if (SearchMode)
                {
                    // Show that Search Mode is On
                    StatusLabel.Text = "Search Mode: On";
                }
                else
                {
                    // Show that Search Mode is Off
                    StatusLabel.Text = "Search Mode: Off";
                }
            }
            #endregion
            
            #region SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a selection is made in the 'SizeComboBox_'.
            /// </summary>
            private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {

        }
        #endregion

            #region SubImage1_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage1' is clicked.
            /// </summary>
            private void SubImage1_Click(object sender, EventArgs e)
            {
                // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(0);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(0);
                }
            }
            #endregion
            
            #region SubImage2_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage2' is clicked.
            /// </summary>
            private void SubImage2_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(1);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(1);
                }
            }
            #endregion
            
            #region SubImage3_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage3' is clicked.
            /// </summary>
            private void SubImage3_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(2);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(2);
                }
            }
            #endregion
            
            #region SubImage4_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage4' is clicked.
            /// </summary>
            private void SubImage4_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(3);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(3);
                }
            }
            #endregion
            
            #region SubImage5_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage5' is clicked.
            /// </summary>
            private void SubImage5_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(4);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(4);
                }
            }
            #endregion
            
            #region SubImage6_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage6' is clicked.
            /// </summary>
            private void SubImage6_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(5);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(5);
                }
            }
            #endregion
            
            #region SubImage7_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage7' is clicked.
            /// </summary>
            private void SubImage7_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(6);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(6);
                }
            }
            #endregion
            
            #region SubImage8_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SubImage8' is clicked.
            /// </summary>
            private void SubImage8_Click(object sender, EventArgs e)
            {
                 // get the mouseArgs
                MouseEventArgs mouseArgs = (MouseEventArgs) e;

                // if the right button
                if (mouseArgs.Button == MouseButtons.Right)
                {
                    // Remove the SubImage
                    RemoveSubImage(7);
                }
                else if (SearchMode)
                {
                    // Search for the SubImage at this index
                    SearchForSubImage(7);
                }
            }
            #endregion
            
            #region TakeScreenShotButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'TakeScreenShotButton' is clicked.
            /// </summary>
            private void TakeScreenShotButton_Click(object sender, EventArgs e)
            {
                // Create a new collection of 'Bitmap' objects.
                this.SubImages = new List<Bitmap>();
                
                // local
                FormWindowState windowState = this.WindowState;
                
                this.WindowState = FormWindowState.Minimized;
                
                // Give time for system to catch up
                Application.DoEvents();
                
                // Sleep for a second
                System.Threading.Thread.Sleep(1000);
                
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                
                // Set the CanvasBackground
                Canvas.BackgroundImage = bitmap;
                this.WindowState = windowState;
                
                // Give time for system to catch up
                Application.DoEvents();
                
                // Load the PixelDatabase
                this.PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(bitmap, Refresh);
            }
            #endregion
            
        #endregion
        
        #region Methods
            
            #region DisplaySubImages()
            /// <summary>
            /// This method Display Sub Images
            /// </summary>
            public void DisplaySubImages()
            {
                // local 
                int count = 0;
                
                // hide each control
                this.SubImage1.Visible = false;
                this.SubImage2.Visible = false;
                this.SubImage3.Visible = false;
                this.SubImage4.Visible = false;
                this.SubImage5.Visible = false;
                this.SubImage6.Visible = false;
                this.SubImage7.Visible = false;
                this.SubImage8.Visible = false;
                
                // Display the count
                SubImagesCountLabel.Text = SubImagesCount.ToString();
                
                // if the value for HasSubImages is true
                if (HasSubImages)
                {
                    // Iterate the collection of Bitmap objects
                    foreach (Bitmap bitmap in SubImages)
                    {
                        // Increment the value for count
                        count++;
                        
                        // Determine the action by the count
                        switch (count)
                        {
                            case 1:
                            
                                // Set the BackgroundImage
                                SubImage1.BackgroundImage = bitmap;
                                SubImage1.Visible = true;
                            
                                // required
                                break;
                            
                            case 2:
                            
                                // Set the BackgroundImage
                                SubImage2.BackgroundImage = bitmap;
                                SubImage2.Visible = true;
                            
                                // required
                                break;
                            
                            case 3:
                            
                                // Set the BackgroundImage
                                SubImage3.BackgroundImage = bitmap;
                                SubImage3.Visible = true;
                            
                                // required
                                break;
                            
                            case 4:
                            
                                // Set the BackgroundImage
                                SubImage4.BackgroundImage = bitmap;
                                SubImage4.Visible = true;
                            
                                // required
                                break;
                                
                            case 5:
                            
                                // Set the BackgroundImage
                                SubImage5.BackgroundImage = bitmap;
                                SubImage5.Visible = true;
                            
                                // required
                                break;
                            
                            case 6:
                            
                                // Set the BackgroundImage
                                SubImage6.BackgroundImage = bitmap;
                                SubImage6.Visible = true;
                            
                                // required
                                break;
                            
                        case 7:
                            
                                // Set the BackgroundImage
                                SubImage7.BackgroundImage = bitmap;
                                SubImage7.Visible = true;
                            
                                // required
                                break;
                            
                        case 8:
                            
                                // Set the BackgroundImage
                                SubImage8.BackgroundImage = bitmap;
                                SubImage8.Visible = true;
                            
                                // required
                                break;
                        }
                    }
                }
                
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the buttons
                TakeScreenShotButton.BackgroundImage = Properties.Resources.WoodButtonWidth1280;
                CreateSubImagesButton.BackgroundImage = Properties.Resources.WoodButtonWidth1280;

                // Add these chioces                
                SizeComboBox.Items.Add("16 x 16");
                SizeComboBox.Items.Add("32 x 32");
                SizeComboBox.Items.Add("48 x 48");
                SizeComboBox.Items.Add("64 x 64");
                SizeComboBox.Items.Add("96 x 96");
                SizeComboBox.Items.Add("128 x 128");
                SizeComboBox.Items.Add("256 x 256");
                
                // Default to 64 x 64
                SizeComboBox.SelectedIndex = 3;
                
                // Set the SubImageSize
                SubImageSize = 64;
                
                // Create a new collection of 'Bitmap' objects.
                this.SubImages = new List<Bitmap>();
            }
            #endregion
            
            #region Refresh(string message, int pixelsUpdated)
            /// <summary>
            /// method Refresh
            /// </summary>
            private void Refresh(string message, int pixelsUpdated)
            {
                // do not show SetMaxGraph
                if (message != "SetGraphMax")
                {
                    // Show the text
                    this.StatusLabel.Text = message;
                }
            }
            #endregion
            
            #region RemoveSubImage(int index)
            /// <summary>
            /// This method Remove Sub Image
            /// </summary>
            public void RemoveSubImage(int index)
            {
                // if the SubImages exist
                if ((HasSubImages) && (SubImagesCount > index))
                {
                    // remove this item
                    SubImages.RemoveAt(index);

                    // Redisplay
                    DisplaySubImages();
                }
            }
            #endregion
            
            #region SearchForSubImage(int index)
            /// <summary>
            /// This method Searches For A Sub Message
            /// </summary>
            public void SearchForSubImage(int index)
            {
                // local
                bool found = false;

                try
                {
                    // locals
                    Bitmap bitmap = null;

                    // set the searchDepth
                    int searchDepth = 16;

                    // set the size
                    int squareSize = 12;

                    // set the square color
                    Color color = Color.Yellow;

                    // Show text
                    StatusLabel.Text = "Searching...";
                    StatusLabel.Refresh();
                    Application.DoEvents();

                    // if the PixelDatabase exists and teh index is in range
                    if ((HasPixelDatabase) && (index >= 0) && (index < SubImagesCount))
                    {  
                        // get this bitMap
                        bitmap = SubImages[index];

                        // Set the result
                        SearchResult result = PixelDatabase.SearchForSubImage(bitmap, searchDepth);

                        // if the result was found
                        if (NullHelper.Exists(result))
                        {
                            // create a Yellow Point at the top left hand corner of the subimage

                            string query = "Update" + Environment.NewLine 
                            + "Set Color " + color.Name + Environment.NewLine
                            + "Where" + Environment.NewLine
                            + "X Between " + (result.Point.X - squareSize) + " " + (result.Point.X + squareSize) + Environment.NewLine
                            + "Y Between " + (result.Point.Y - squareSize) + " " + (result.Point.Y + squareSize);

                           // Show text
                            StatusLabel.Text = "Showing Best Result:";

                            // was found
                            found = true;
                            
                            // Light up the 
                            PixelQuery pixelQuery = PixelDatabase.ApplyQuery(query, null);

                            // Update the BackgroundImage
                            Canvas.BackgroundImage = PixelDatabase.DirectBitmap.Bitmap;
                            
                            // Force refresh
                            Canvas.Invalidate();

                            // Get the count of pixelsUpdated
                            int pixelsUpdated = pixelQuery.PixelsUpdated;
                        }                        
                    }
                }
                catch (Exception error)
                {
                    // log the errror
                    DebugHelper.WriteDebugError("SearchSubImages", "MainForm.cs", error);
                }
                finally
                {
                    // if not found
                    if (!found)
                    {
                        // Show text
                        StatusLabel.Text = "Not Found.";
                    }    
                }
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
            
            #region HasSubImages
            /// <summary>
            /// This property returns true if this object has a 'SubImages'.
            /// </summary>
            public bool HasSubImages
            {
                get
                {
                    // initial value
                    bool hasSubImages = (this.SubImages != null);
                    
                    // return value
                    return hasSubImages;
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
            
            #region SearchMode
            /// <summary>
            /// This property gets or sets the value for 'SearchMode'.
            /// </summary>
            public bool SearchMode
            {
                get { return searchMode; }
                set { searchMode = value; }
            }
            #endregion
            
            #region SubImages
            /// <summary>
            /// This property gets or sets the value for 'SubImages'.
            /// </summary>
            public List<Bitmap> SubImages
            {
                get { return subImages; }
                set { subImages = value; }
            }
            #endregion
            
            #region SubImagesCount
            /// <summary>
            /// This read only property returns the Count of subimages
            /// </summary>
            public int SubImagesCount
            {
                get
                {
                    // initial value
                    int count = 0;
                    
                    // if the value for HasSubImages is true
                    if (HasSubImages)
                    {
                        // set the return value
                        count = subImages.Count;
                    }
                    
                    // return value
                    return count;
                }
            }
            #endregion
            
            #region SubImageSize
            /// <summary>
            /// This property gets or sets the value for 'SubImageSize'.
            /// </summary>
            public int SubImageSize
            {
                get { return subImageSize; }
                set { subImageSize = value; }
            }
        #endregion

        #endregion

    }
    #endregion

}
