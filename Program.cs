using System.Text;
using Lesson10Tasks.Models;

namespace Lesson10Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            // bool doWantExit = true;
            // while (doWantExit)
            // {
            //     Console.Write("Kəsr daxil edin (nümunə = 12/24) : ");
            //     string fraction = Console.ReadLine().Trim();
            //     Task1.Task1Main(fraction);
            //     Console.Write("Çıxmaq üçün 'true' yaz, əks halda random bir düyməyə kliklə: ");
            //     bool.TryParse(Console.ReadLine(), out doWantExit);
            // }
            #endregion
            #region  Task2
            Console.Write("Istediyiniz bir cumlə yazın: ");
            string input=Console.ReadLine();
            //string input2 = "HoW mAny MucH";
            Task2.Task2Main(input);
            #endregion
        }
    }
}