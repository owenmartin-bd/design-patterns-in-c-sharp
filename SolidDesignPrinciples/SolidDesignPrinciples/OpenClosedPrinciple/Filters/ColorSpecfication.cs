using SolidDesignPrinciples.OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.OpenClosedPrinciple.Filters;

internal class ColorSpecfication : ISpecification<Product>
{
    private readonly Color _color;
    public ColorSpecfication(Color color)
    {
        _color = color;
    }
    public bool IsSatisfied(Product t)
    {
        return t.Color == _color;
    }
}