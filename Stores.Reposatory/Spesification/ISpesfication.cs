﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Stores.Reposatory.Spesification
{
    public interface ISpesfication<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; } 
        Expression<Func<T, object>> OrderByDescending { get; } 
        int Take { get; }
        int Skip { get; }
        bool IsPaginated { get; }
    }
}
