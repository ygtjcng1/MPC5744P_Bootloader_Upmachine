﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;
using System.Globalization;

namespace NXP_HexParse.Styles.Converter
{
    /// <summary>
    /// 自定义字符串转换事件
    /// </summary>
    public class EnableConverter : IValueConverter
    {
        /// <summary>
        /// 当值从绑定源传播给绑定目标时，调用方法Convert
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            int index = (int)value;

            return index>=0?true:false;
        }
        /// <summary>
        /// 当值从绑定目标传播给绑定源时，调用此方法ConvertBack
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value as string;
            int txtDate = (bool)value?0:1;

            return txtDate;
        }
    }
}
