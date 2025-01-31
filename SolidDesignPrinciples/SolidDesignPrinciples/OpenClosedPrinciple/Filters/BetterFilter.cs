using SolidDesignPrinciples.OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.OpenClosedPrinciple.Filters;

internal class BetterFilter
{
    public IEnumerable<Product> Filter(
        IEnumerable<Product> products, ISpecification<Product> spec)
    {
        foreach (var product in products)
        {
            if (spec.IsSatisfied(product))
            {
                yield return product;
            }
        }
    }
}
