﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BitStamp.ViewModel
{
   public class AssBjModel:NotifyProperty
    {
        public AssBjModel()
        {
        }

        public void NavigateStamp()
        {
            //StampPage 是用户控件
            //FrameAccount.Navigate(typeof(View.StampPage));
            FrameVisibility=Visibility.Visible;
        }

        public void NavigateAccount()
        {
            FrameVisibility=Visibility.Collapsed;
            FrameAccount.Navigate(typeof(View.AccountPage));
        }

        public Frame FrameAccount
        {
            set;
            get;
        }

        public Visibility FrameVisibility
        {
            set
            {
                _frameVisibility = value;
                OnPropertyChanged();
            }
            get
            {
                return _frameVisibility;
            }
        }
        private Visibility _frameVisibility;
    }
}