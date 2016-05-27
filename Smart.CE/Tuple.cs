﻿namespace Smart
{
    using System;
    using System.Globalization;

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    [Serializable]
    public sealed class Tuple<T1, T2>
    {
        private readonly T1 item1;
        private readonly T2 item2;

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public Tuple(T1 item1, T2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.CurrentCulture, "({0}, {1})", item1, item2);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = (hash * 23) + (Equals(item1, default(T1)) ? 0 : item1.GetHashCode());
            hash = (hash * 23) + (Equals(item2, default(T2)) ? 0 : item2.GetHashCode());
            return hash;
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    [Serializable]
    public sealed class Tuple<T1, T2, T3>
    {
        private readonly T1 item1;
        private readonly T2 item2;
        private readonly T3 item3;

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.CurrentCulture, "({0}, {1}, {2})", item1, item2, item3);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = (hash * 23) + (Equals(item1, default(T1)) ? 0 : item1.GetHashCode());
            hash = (hash * 23) + (Equals(item2, default(T2)) ? 0 : item2.GetHashCode());
            hash = (hash * 23) + (Equals(item3, default(T3)) ? 0 : item3.GetHashCode());
            return hash;
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    [Serializable]
    public sealed class Tuple<T1, T2, T3, T4>
    {
        private readonly T1 item1;
        private readonly T2 item2;
        private readonly T3 item3;
        private readonly T4 item4;

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public T4 Item4
        {
            get { return item4; }
        }

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.CurrentCulture, "({0}, {1}, {2}, {3})", item1, item2, item3, item4);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = (hash * 23) + (Equals(item1, default(T1)) ? 0 : item1.GetHashCode());
            hash = (hash * 23) + (Equals(item2, default(T2)) ? 0 : item2.GetHashCode());
            hash = (hash * 23) + (Equals(item3, default(T3)) ? 0 : item3.GetHashCode());
            hash = (hash * 23) + (Equals(item4, default(T4)) ? 0 : item4.GetHashCode());
            return hash;
        }
    }
}