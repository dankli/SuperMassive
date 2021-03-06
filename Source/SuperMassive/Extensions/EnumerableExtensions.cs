﻿namespace SuperMassive.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides extension methods for the generic IEnumerable interface
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Execute an lambda expression on each items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="action"></param>
        public static void Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            Guard.ArgumentNotNull(items, nameof(items));
            Guard.ArgumentNotNull(action, nameof(action));

            foreach (T local in items)
            {
                action(local);
            }
        }

        /// <summary>
        /// Joins all items in the current collection by calling ToString() on each.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> items, string separator)
        {
            Guard.ArgumentNotNull(items, nameof(items));

            return String.Join(separator, items);
        }

        /// <summary>
        /// Picks a random element from the current collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T RandPick<T>(this IEnumerable<T> collection)
        {
            Guard.ArgumentNotNull(collection, nameof(collection));

            var items = collection.ToArray();
            return items[RandomNumberGenerator.Int(items.Length)];
        }

        /// <summary>
        /// Picks a range of random elements from the current collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="count">Number of item to pick</param>
        /// <returns></returns>
        public static IEnumerable<T> RangeRandPick<T>(this IEnumerable<T> collection, int count)
        {
            Guard.ArgumentNotNull(collection, nameof(collection));

            T[] items = collection.ToArray();
            for (int i = 0; i < count; i++)
                yield return items[RandomNumberGenerator.Int(items.Length)];
        }
    }
}
