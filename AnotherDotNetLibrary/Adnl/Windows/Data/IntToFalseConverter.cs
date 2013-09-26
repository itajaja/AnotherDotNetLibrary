using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    ///     returns false if the (int)value equals the (int)parameter
    /// </summary>
    public class IntToFalseConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (int)value;
            int par;
            bool parseResult = int.TryParse(parameter.ToString(), out par);
            return !(parseResult && val == par);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }

        #endregion
    }
}