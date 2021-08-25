using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            //define const and a var for shape and color
            const string shapeConst = "circle";
            var colorVar = "blue";

            //create two new objects of Class1, the second one using the chained constructor
            Class1 Object1 = new Class1(shapeConst, colorVar);
            Class1 Object2 = new Class1(shapeConst);

            //print color and shape of the two objects to console
            Console.WriteLine("A {0} {1}", Object1.color, Object1.shape);
            Console.WriteLine("A {0} {1}", Object2.color, Object2.shape);

            Console.Read();
        }
    }
}
