using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Numbers
    {
        //create constructor for Numbers object, setting values for AddNum, SubtractNum, and MultiplyNum
        public Numbers()
        {
            AddNum = 12;
            SubtractNum = 4;
            MultiplyNum = 10;
        }

        //define properties for Numbers class
        public int AddNum { get; set; }
        public int SubtractNum { get; set; }
        public int MultiplyNum { get; set; }

        //define methods to perform various math operations with AddNum, SubtractNum, MultiplyNum, and user's input, then return results
        public int AddNumbers(int inputNum)
        {
            int addResult = inputNum + AddNum;
            return addResult;
        }

        public int SubtractNumbers(int inputNum)
        {
            int subtractResult = inputNum - SubtractNum;
            return subtractResult;
        }

        public int MultiplyNumbers(int inputNum)
        {
            int multiplyResult = inputNum * MultiplyNum;
            return multiplyResult;
        }
    }
}
