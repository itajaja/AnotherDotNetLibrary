﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion From a nullable type to a bool.
    /// </summary>
    public class NullToTrueConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Returns True if the value is null.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}