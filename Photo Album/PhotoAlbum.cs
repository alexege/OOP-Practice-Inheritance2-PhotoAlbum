using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Album
{
    class PhotoAlbum
    {
        public int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numPages)
        {
            numberOfPages = numPages;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }


    }
}
