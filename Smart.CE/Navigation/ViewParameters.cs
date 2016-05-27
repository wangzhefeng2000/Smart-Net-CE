﻿namespace Smart.Navigation
{
    using System.Collections.Generic;

    public interface IViewParameters
    {
        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetValue<T>(string key);

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetValueOrDefault<T>(string key);

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        T GetValueOr<T>(string key, T defaultValue);
    }

    /// <summary>
    ///
    /// </summary>
    public class ViewParameters : IViewParameters
    {
        private readonly Dictionary<string, object> values = new Dictionary<string, object>();

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetValue<T>(string key)
        {
            return (T)values[key];
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetValueOrDefault<T>(string key)
        {
            object value;
            if (values.TryGetValue(key, out value))
            {
                return (T)value;
            }
            return default(T);
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public T GetValueOr<T>(string key, T defaultValue)
        {
            object value;
            if (values.TryGetValue(key, out value))
            {
                return (T)value;
            }
            return defaultValue;
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public ViewParameters SetValue<T>(string key, T value)
        {
            values[key] = value;
            return this;
        }
    }
}
