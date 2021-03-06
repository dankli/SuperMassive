﻿namespace SuperMassive.Extensions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Extension methods for integer types : <see cref="Int16"/>, <see cref="Int32"/>, see <see cref="Int64"/>
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Returns the current <see cref="Int16"/> as a <see cref="BitwiseMask"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BitwiseMask AsMask(this Int16 value)
        {
            return new BitwiseMask(value);
        }

        /// <summary>
        /// Returns the current <see cref="Int32"/> as a <see cref="BitwiseMask"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BitwiseMask AsMask(this Int32 value)
        {
            return new BitwiseMask(value);
        }

        /// <summary>
        /// Returns the current <see cref="Int64"/> as a <see cref="BitwiseMask"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BitwiseMask AsMask(this Int64 value)
        {
            return new BitwiseMask(value);
        }

        /// <summary>
        /// Returns a sequence of number starting from the current value
        /// </summary>
        /// <param name="startingValue"></param>
        /// <param name="endingValue"></param>
        /// <returns></returns>
        public static IEnumerable<int> To(this int startingValue, int endingValue)
        {
            if (endingValue == startingValue)
                return new int[] { startingValue };
            if (startingValue == int.MinValue && endingValue == int.MaxValue)
                return new int[] { startingValue };
            if (startingValue == int.MaxValue && endingValue == int.MinValue)
                return new int[] { startingValue };

            List<int> result = new List<int>();
            if (endingValue > startingValue)
            {
                for (int i = startingValue; i <= endingValue; i++)
                {
                    result.Add(i);
                }
            }
            else
            {
                for (int i = startingValue; i >= endingValue; i--)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
