﻿using System;
using System.Collections.Generic;
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

namespace GDLauncher.Dialogs.Server.Commands
{
    /// <summary>
    /// Interaction logic for Kick.xaml
    /// </summary>
    public partial class Kick : UserControl
    {
        public Kick()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.ServerManager.singleton.process.StandardInput.WriteLine("/kick " + user.Text);
            MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand.Execute(this, this);

        }
    }
}