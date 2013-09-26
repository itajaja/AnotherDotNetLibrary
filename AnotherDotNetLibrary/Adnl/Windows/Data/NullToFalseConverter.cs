﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    public class NullToFalseConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}
