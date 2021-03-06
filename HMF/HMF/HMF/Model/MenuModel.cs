﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HMF
{
    public class MenuModel:BindableBase
    {
        private string imageItemMenu;

        public string ImageItemMenu
        {
            get { return imageItemMenu; }
            set { SetProperty(ref imageItemMenu, value); }
        }
        private string titleItemMenu;

        public string TitleItemMenu
        {
            get { return titleItemMenu; }
            set { SetProperty(ref titleItemMenu, value); }
        }
        private int idMenu;
        public int IdMenu
        {
            get { return idMenu; }
            set
            {
                SetProperty(ref idMenu, value);
            }
        }
    }
}
