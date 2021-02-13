# SubImageCreator
This is a sample Windows Forms project for .Net 5, that uses my Nuget package DataJuggler.PixelDatabase to demonstrates creating sub images from
a source image in whatever size you prefer.

This is useful for parsing icon sets or other images that you want each file to be saved as their own image.


Here is a short video:
https://youtu.be/PvgJG984vS0


If you think this product is worth the price of free, please subscribe to my YouTube channel:
https://www.youtube.com/channel/UCaw0joqvisKr3lYJ9Pd2vHA

The code that performs the Sub image creation is in the CreateSubImagesButton_Click event, located in the Events region.

    // Load a pixelDatabase
    PixelDatabase pixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(imagePath, Refresh);
    
The refresh method is called to give a status during the load.

The sub images are created with this:

     // create the subImage
     Image image = pixelDatabase.CreateSubImage(topLeft, size);
     
 The topLeft is a point, and the size is a rectangle of what area to copy.
 
 If you have any questions or feature requests, let me know.
 
 




