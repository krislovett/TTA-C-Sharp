using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Class1
    {
        //create an object constructor that takes a shape string and a color string, and a chained constructor that takes only a shape string and defaults color to red
        public Class1(string shapeConst) : this(shapeConst, "red") { }
        public Class1(string shapeConst, string colorVar)
        {
            shape = shapeConst;
            color = colorVar;
        }

        public string shape { get; set; }
        public string color { get; set; }
    }
}
