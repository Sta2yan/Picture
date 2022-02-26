using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userPictures = 52;
            int picturesInRow = 3;

            int rowPicturesField = userPictures / picturesInRow;
            int picturesLeft = userPictures % picturesInRow;

            Console.WriteLine(rowPicturesField);
            Console.WriteLine(picturesLeft);
        }
    }
}