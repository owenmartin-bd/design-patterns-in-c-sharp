using SolidDesignPrinciples.OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.OpenClosedPrinciple.Filters;

internal class SizeSpecfication : ISpecification<Product>
{
    private Size _size;

    public SizeSpecfication(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Size == _size;
    }
}
