using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Numbers
    {
        public Numbers()
        {
            AddNum = 14;
        }

        public int AddNum { get; set; }

        //AddNumbers method adds user input numbers with AddNum. AddNum3 is optional.
        public int AddNumbers(int AddNum2, int AddNum3 = 0)
        {
            int addResult = AddNum + AddNum2 + AddNum3;
            return addResult;
        }        
    }
}
