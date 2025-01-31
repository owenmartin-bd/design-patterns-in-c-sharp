using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.OpenClosedPrinciple.Interfaces;

internal interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}
