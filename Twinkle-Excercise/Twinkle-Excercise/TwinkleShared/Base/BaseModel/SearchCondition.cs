using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Store.Twinkle.BaseModel
{
    public class SearchCondition<T> : ISearchCondition<T> where T : class
    {
        #region Members
        /// <summary>
        ///  Expression<TDelegate> instance
        /// </summary>
        private readonly Expression<Func<T, bool>> _predicate;

        #endregion Members

        #region Constructor

        /// <summary>
        /// Create search condition instance
        /// </summary>
        /// <param name="predicate"></param>
        public SearchCondition(Expression<Func<T, bool>> predicate)
        {
            _predicate = predicate;
        }

        #endregion Constructor

        /// <summary>
        /// Gets the search condition Predicate
        /// </summary>
        /// <value>The search condition Predicate.</value>
        public Expression<Func<T, bool>> Predicate
        {
            get
            {
                return _predicate == null ? T => true : _predicate;
            }
        }
    }
}
