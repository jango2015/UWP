﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using VarietyHiggstGushed.ViewModel;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace VarietyHiggstGushed.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class StockPage : Page
    {
        public StockPage()
        {
            View = new StorageModel();
            this.InitializeComponent();
            DataContext = View;
        }

        private StorageModel View
        {
            set;
            get;
        }
    }

    public class StrInt:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return 0;
                }
                if (int.TryParse(str, out int temp))
                {
                    return temp;
                }
                return 0;
            }
            return 0;
        }
    }
}
