﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FiskmoMTEngine
{
    /// <summary>
    /// Interaction logic for CustomizationView.xaml
    /// </summary>
    public partial class MarianSettingsView : UserControl
    {
        public MarianSettingsView()
        {
            InitializeComponent();
        }

        private void OpenCustomSettingsInEditor_Click(object sender, RoutedEventArgs e)
        {
            var customizeYml = HelperFunctions.GetLocalAppDataPath(FiskmoMTEngineSettings.Default.CustomizationBaseConfig);
            Process.Start("notepad.exe",customizeYml);
        }
    }
}
