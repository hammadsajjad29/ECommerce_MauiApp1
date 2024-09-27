using System;
using System.Collections;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public class EmptyCollectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ICollection collection)
            {
                bool isEmpty = collection.Count == 0;
                return parameter != null && parameter.ToString().ToLower() == "inverse" ? isEmpty : !isEmpty;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
