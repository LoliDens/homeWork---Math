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
            int amountPictures = 52;
            int picturesInRow = 3;
            int numberOfRows = amountPictures / picturesInRow;
            int picturesOutsideTheRow = amountPictures % picturesInRow;

            Console.WriteLine($"Колличество рядов заполеных картинками : {numberOfRows} \n" +
                $"Колличество кортинок сверз меры: {picturesOutsideTheRow}");
            Console.ReadKey();

        }
    }
}
