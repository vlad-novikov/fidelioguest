﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FidelioGuest
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
  
    public partial class App : Application
    {

        //[STAThread]
        // Without this attribute, Clipboard will get null
        [STAThreadAttribute]
        public static void Main()
        {
            var application = new App();
            application.InitializeComponent();
            application.Run();
        }

    }
}
