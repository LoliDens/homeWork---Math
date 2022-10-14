using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork___Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountPicture = 52;
            int pictureInRow = 3;
            int numberOfRows = amountPicture / pictureInRow;
            int picturesOutsideTheRow = amountPicture % pictureInRow;

            Console.WriteLine($"Колличество рядов заполеных картинками : {numberOfRows} \n" +
                $"Колличество кортинок сверз меры: {picturesOutsideTheRow}");
            Console.ReadKey();

        }
    }
}
