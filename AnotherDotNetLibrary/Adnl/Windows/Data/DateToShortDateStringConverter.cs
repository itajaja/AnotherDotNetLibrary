using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion from Date to its short date representation.
    /// </summary>
    public class DateToShortDateStringConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Returns ((DateTime)value).ToShortDateString().
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToShortDateString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}