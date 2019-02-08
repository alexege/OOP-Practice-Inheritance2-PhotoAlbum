using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Objetive
//Create a class "PhotoAlbum" with a private attribute "numberOfPages." 
//It should also have a public method "GetNumberOfPages", which will return the number of pages.
//The default constructor will create an album with 16 pages.There will be an additional constructor, with which we can specify the number of pages we want in the album. 
//Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
//Create a test class "AlbumTest" to create an album with its default constructor,one with 24 pages, a "BigPhotoAlbum" and show the number of pages that the three albums have.

//Problem Source: https://practiceexercisecsharp.blogspot.com/2017/05/exercise-c-sharp-602-photo-album-tarea.html

namespace Photo_Album
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum pa = new PhotoAlbum();
            Console.WriteLine(pa.GetNumberOfPages());

            PhotoAlbum pa2 = new PhotoAlbum(24);
            Console.WriteLine(pa2.GetNumberOfPages());

            BigPhotoAlbum bpa = new BigPhotoAlbum();
            Console.WriteLine(bpa.GetNumberOfPages());
        }
    }
}
