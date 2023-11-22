using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //base class success true ve gelen message gider
        public SuccessResult(string message) : base(true, message)
        {
        }

        //base class success true gider
        public SuccessResult() : base(true)
        {
        }
    }
}
