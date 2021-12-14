﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vizsgaremek.Navigation
{
    public static class Navigate
    {
        // eltároljuk a Mainwindow elemet, hogy tudjuk váltani ablakot(pages)
        public static MainWindow mainWindow;

        /// <summary>
        /// Egy új ablakra vált
        /// </summary>
        /// <param name="userControl">Erre az oldalra váltunk</param>
        public static void Navigation(UserControl userControl)
        {
            mainWindow.PageContent.Children.Add(userControl);
        }
    }
}