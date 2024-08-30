using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Interface for a builder that builds a Car Product
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Builds a Car Product by setting various features
        /// </summary>
        virtual void BuildCar() { throw new NotImplementedException(); }

        /// <summary>
        /// Returns the constructed car
        /// </summary>
        virtual CarProduct GetResult() { throw new NotImplementedException(); }
    }
}
