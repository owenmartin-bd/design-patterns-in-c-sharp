using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.OpenClosedPrinciple.Interfaces;

internal interface ISpecification<T>
{
    bool IsSatisfied(T t);
}
