using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public interface IBuilder
    {
        virtual void BuildCar() { throw new NotImplementedException(); }
        virtual CarProduct GetResult() { throw new NotImplementedException(); }
    }
}
