using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Store.Twinkle.BaseModel
{
    public interface ISearchCondition<T>
    {
        /// <summary>
        /// Gets the search condition Predicate
        /// </summary>
        /// <value>The search condition Predicate.</value>
        Expression<Func<T, bool>> Predicate { get; }
    }
}
