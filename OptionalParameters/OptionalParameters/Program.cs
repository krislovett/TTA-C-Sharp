using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine("Enter a whole number.");
            int AddNum2 = Convert.ToInt32(Console.ReadLine());

            //collect second optional number from user and save as string
            Console.WriteLine("Enter another whole number (optional).");
            string AddNum3string = Console.ReadLine();
            
            //if AddNum3string is not empty, convert to int and pass into AddNumbers method
            if (AddNum3string != "")
            {
                int AddNum3 = Convert.ToInt32(AddNum3string);
                Console.WriteLine("{0} + {1} + {2} = " + numbers.AddNumbers(AddNum2, AddNum3), numbers.AddNum, AddNum2, AddNum3);
            }

            //if AddNum3string is empty, ignore and pass just AddNum2 into AddNumbers method
            if (AddNum3string == "")
            {
                Console.WriteLine("{0} + {1} = " + numbers.AddNumbers(AddNum2), numbers.AddNum, AddNum2);
            }

            Console.Read();
        }
    }
}
