# SubImageCreator
This is a sample Windows Forms project for .Net Core, that uses my Nuget package DataJuggler.PixelDatabase to demonstrate taking a screenshot, and then click a canvas 
and creating sub images from the screenshot. 

I will update the documentation for this project more tomorrow, but here is a video I made tonight:

https://youtu.be/JKc7QtdaxWY

The screen shot code was not mine, but the person who asked the question on Stack Overflow that led to the new methods.

    // take a screenshot
    Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
    Graphics graphics = Graphics.FromImage(bitmap);
    Graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                
    // Set the Canvas (button) Background
    Canvas.BackgroundImage = bitmap;
    this.WindowState = windowState;
    
    I got some code out of helping someone, which is the best you can hope for with open source.
    
This project uses Nuget package DataJuggler.PixelDatabase

DataJuggler.PixelDatabase    Dot Net Core
https://github.com/DataJuggler/PixelDatabase

There is also a version for the .Net Framework

DataJuggler.PixelDatabase.Net
https://github.com/DataJuggler/PixelDatabase.Net

Load a PixelDatabase:

    // Load the PixelDatabase
    this.PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(bitmap, Refresh);
    
You can also pass in an image:

    // Load the PixelDatabase
    this.PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(image, Refresh);
    
And there is an override for an ImagePath

    // Load the PixelDatabase
    this.PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(imagePath, Refresh);
    
Refresh is a delegate callback, which can provide information back from PixelDatabase. 

    /// <summary>
    /// This is a callback method called by PixelDatabase
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
    
## Create Sub Image ##
After you have a PixelDatabase loaded, creating a sub image:

    // Top left point where you want to start your image
    Point topLeft = new Point(x, y);
                        
    // Size of the new image
    Rectangle size = new Rectangle(0, 0, SubImageSize, SubImageSize);
                        
    // Create a subImage
    Bitmap subImage = PixelDatabase.CreateSubImage(topLeft, size);
    
## Search Sub Image ##
You can search for a sub image inside a larger image like this:

     // get this bitMap
     bitmap = SubImages[index];

     // Set the result
     SearchResult result = PixelDatabase.SearchForSubImage(bitmap, searchDepth);
     
Search Depth is used to set how many pixels do you want to search from the sub image inside the larger image.
 
I currently take the first 'x' pixels from the sub image, but a better way would be to take samples through the image. 
For version 1, simple is always best.
 
The searchEesult instance returned will contain the Point if found, else an empty point of 0, 0 will be returned, plus the Score value.
 
## Draw A Yellow Rectangle ##
And finally, a yellow rectangle is drawn around the TopLeft point returned witgh the search result.
 
    // create a Yellow Point at the top left hand corner of the subimage

    // build a string to execute (no strings were harmed in the making of this project).
    string query = "Update" + Environment.NewLine 
    + "Set Color " + color.Name + Environment.NewLine
    + "Where" + Environment.NewLine
    + "X Between " + (result.Point.X - squareSize) + " " + (result.Point.X + squareSize) + Environment.NewLine
    + "Y Between " + (result.Point.Y - squareSize) + " " + (result.Point.Y + squareSize);

     // Set text
     StatusLabel.Text = "Showing Best Result:";

     // was found
     found = true;
                            
      // Light up the  top left pixel
      PixelQuery pixelQuery = PixelDatabase.ApplyQuery(query, null);

      // Update the BackgroundImage on the button
      Canvas.BackgroundImage = PixelDatabase.DirectBitmap.Bitmap;
 

Known Issues:
The size of the rectnalge seems to vary. I wrote this code really quickly over the last couple of days, I probably have a bug in the CreateSubImage method in this project.

I may add some new features to this over time.

    




