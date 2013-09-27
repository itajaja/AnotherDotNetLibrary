using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion a string and a collection of string to a bool.
    /// </summary>
    public class StringsToTrueConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Returns true if value.ToString is contained in the parameter string.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter">The list of string, the values must be separated by a comma</param>
        /// <param name="culture"></param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<String> strings = ((string)parameter).Split(',').ToList();
            return strings.Cast<object>().Contains(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}