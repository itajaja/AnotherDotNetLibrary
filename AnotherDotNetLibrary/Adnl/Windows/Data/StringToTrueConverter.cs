using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    ///     returns true if value.ToString is contained in the parameter string
    /// </summary>
    public class StringToTrueConverter : IValueConverter
    {
        #region IValueConverter Members

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