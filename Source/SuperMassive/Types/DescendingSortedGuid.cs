﻿namespace SuperMassive
{
    using System;

    /// A composite identifier made of a Guid and a Timestamp.
    /// Its string representation can be lexicographicaly ordered (REVERSE ORDER).
    /// Originaly implemented by : https://github.com/hatem-b
    public struct DescendingSortedGuid : IComparable, IComparable<DescendingSortedGuid>, IEquatable<DescendingSortedGuid>
    {
        /// <summary>
        /// A read-only instance of the AscendingSortedGuidDescendingSortedGuid structure whose value is all zeros.
        /// </summary>
        public readonly static DescendingSortedGuid Empty = new DescendingSortedGuid();

        /// <summary>
        /// TimeStamp
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Guid
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="DescendingSortedGuid"/>
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="guid"></param>
        public DescendingSortedGuid(DateTimeOffset timestamp, Guid guid)
        {
            Guard.ArgumentNotNull(timestamp, "timestamp");
            Guard.ArgumentNotNull(guid, "guid");
            this.Timestamp = timestamp;
            this.Guid = guid;
        }

        /// <summary>
        /// Parse a string value into a <see cref="DescendingSortedGuid"/>
        /// </summary>
        /// <param name="id">Should be in the form of 0000000000000000000_00000000000000000000000000000000</param>
        /// <returns></returns>
        public static DescendingSortedGuid Parse(string id)
        {
            Guard.ArgumentNotNullOrWhiteSpace(id, "id");
            if (!RegexHelper.IsSortedGuid(id)) { throw new ArgumentException("Not valid SortedGuid"); }

            DescendingSortedGuid result = new DescendingSortedGuid();

            var splits = id.Split(SortedGuidHelper.TokenSeparator);

            string inversedDate = splits[0];
            string guid = splits[1];
            long date = DateTime.MaxValue.Ticks - long.Parse(inversedDate);

            result.Guid = Guid.Parse(guid);
            result.Timestamp = new DateTimeOffset(date, new TimeSpan(0));

            return result;
        }

        /// <summary>
        /// Try to parse a string value into a <see cref="DescendingSortedGuid"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="result"></param>
        /// <returns>Returns true if parsing succeeded, otherwise false</returns>
        public static bool TryParse(string id, out DescendingSortedGuid result)
        {
            result = Empty;
            if (string.IsNullOrWhiteSpace(id))
                return false;

            try
            {
                result = Parse(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Creates a new empty sorted guid
        /// </summary>
        /// <returns></returns>
        public static DescendingSortedGuid NewSortedGuid()
        {
            return new DescendingSortedGuid(
                DateTimeOffset.UtcNow,
                Guid.NewGuid());
        }

        /// <summary>
        /// Returns the string representation of this sorted guid
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return SortedGuidHelper.GetFormatedString(
                DateTime.MaxValue.Ticks - Timestamp.Ticks,
                Guid);
        }

        /// <summary>
        /// Gets hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * SortedGuidHelper.HashcodeMultiplier) +
                Timestamp.GetHashCode().GetHashCode() +
                Guid.GetHashCode();
        }

        /// <summary>
        /// Checks equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is DescendingSortedGuid))
                return false;
            return Equals((DescendingSortedGuid)obj);
        }

        /// <summary>
        /// Returns true if the given <see cref="DescendingSortedGuid"/> is equal to the given instance
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(DescendingSortedGuid other)
        {
            if (this.Timestamp != other.Timestamp)
                return false;
            if (this.Guid != other.Guid)
                return false;
            return true;
        }

        /// <summary>
        /// Equality operator overloading
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool operator ==(DescendingSortedGuid value1, DescendingSortedGuid value2)
        {
            if (value1.Timestamp != value2.Timestamp)
            {
                return false;
            }
            if (value1.Guid != value2.Guid)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Equality operator overloading
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool operator !=(DescendingSortedGuid value1, DescendingSortedGuid value2)
        {
            return !(value1 == value2);
        }

        public static bool operator >(DescendingSortedGuid value1, DescendingSortedGuid value2)
        {
            return value1.CompareTo(value2) == -1;
        }

        public static bool operator >=(DescendingSortedGuid value1, DescendingSortedGuid value2)
        {
            int result = value1.CompareTo(value2);
            return (result == 0 || result == -1);
        }

        public static bool operator <(DescendingSortedGuid value1, DescendingSortedGuid value2)
        {
            return value1.CompareTo(value2) == 1;
        }

        public static bool operator <=(DescendingSortedGuid value1, DescendingSortedGuid value2)
        {
            int result = value1.CompareTo(value2);
            return (result == 0 || result == 1);
        }

        /// <summary>
        /// Compares the given value to the current structure
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int CompareTo(object value)
        {
            if (value == null)
                return 1;

            if (!(value is DescendingSortedGuid))
                return 1;

            return CompareTo((DescendingSortedGuid)value);
        }

        /// <summary>
        /// Compares the given value to the current structure
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(DescendingSortedGuid other)
        {
            if (this.Timestamp < other.Timestamp)
                return 1;
            if (this.Timestamp > other.Timestamp)
                return -1;
            // Timestamp are equal, check guid now
            return this.Guid.CompareTo(other.Guid);
        }
    }
}
