﻿namespace SuperMassive.Extensions
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides extension methods for the <see cref="List"/> class.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Adds an item to the list if and only if the item is not null
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="extended">The list which is extended</param>
        /// <param name="item">The item to add</param>
        public static void AddIfNotNull<T>(this List<T> extended, T item)
            where T : class
        {
            Guard.ArgumentNotNull(extended, nameof(extended));

            if (item == null)
                return;
            extended.Add(item);
        }

        /// <summary>
        /// Adds a collection of items to the list if and only if the collection of items is not null
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="extended">The list which is extended</param>
        /// <param name="items">The collection of items to add</param>
        public static void AddRangeIfNotNull<T>(this List<T> extended, IEnumerable<T> items)
        {
            Guard.ArgumentNotNull(extended, nameof(extended));

            if (items == null) return;
            extended.AddRange(items);
        }
    }
}
