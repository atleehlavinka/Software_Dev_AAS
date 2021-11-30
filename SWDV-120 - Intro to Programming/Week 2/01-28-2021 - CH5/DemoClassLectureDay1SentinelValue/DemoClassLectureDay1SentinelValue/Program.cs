using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoClassLectureDay2
{
    class Program
    {
        static void Main()
        {

            char letter;                                 // storage for letters read
            int counter;                                 // counts the number of letters

            // read the first letter
            WriteLine("Enter a letter: ");
            letter = Convert.ToChar(ReadLine());

            counter = 0;                                  // initialize the counter
            while (letter != 'q')                         // loop until 'q' is read
            {
                ++counter;                                // increment letter counter
                WriteLine("Enter a letter: ");
                letter = Convert.ToChar(ReadLine());      // read next letter
            }
            WriteLine("The number of letters read is: {0}", counter);

        }

    }
}

