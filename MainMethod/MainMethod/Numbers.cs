using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Numbers
    {
        public Numbers()
        {
            AddNum = 4;
            DivideNum = 1.5m;
            StringNum = 12;
        }

        public int AddNum { get; set; }
        public decimal DivideNum { get; set; }
        public int StringNum { get; set; }

        //DoMath adds two numbers together when int is passed in
        public int DoMath(int AddNum2)
        {
            int addResult = AddNum + AddNum2;
            return addResult;
        }

        //DoMath divides number by input number when decimal is passed in
        public decimal DoMath(decimal DivideNum2)
        {
            decimal divideResult = DivideNum / DivideNum2;
            return divideResult;
        }

        //DoMath converts input string to int and subtracts StringNum from it
        public int DoMath(string StringNum2)
        {
            int subtractResult = StringNum - Convert.ToInt32(StringNum2);
            return subtractResult;
        }
    }
}
