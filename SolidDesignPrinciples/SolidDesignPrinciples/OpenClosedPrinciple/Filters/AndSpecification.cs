﻿using SolidDesignPrinciples.OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.OpenClosedPrinciple.Filters;

internal class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first, _second;

    public AndSpecification(
        ISpecification<T> first,
        ISpecification<T> second)
    {
        _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        _second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }
    public bool IsSatisfied(T t)
    {
        return _first.IsSatisfied(t) && _second.IsSatisfied(t);
    }
}
