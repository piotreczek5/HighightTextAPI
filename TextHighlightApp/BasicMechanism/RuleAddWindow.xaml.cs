using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BasicMechanism
{
    /// <summary>
    /// Interaction logic for RuleAddWindow.xaml
    /// </summary>
    public partial class RuleAddWindow : Window
    {
        public RuleAddWindow()
        {
            InitializeComponent();
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            string text = RuleText.Text;
            //Application.Current.MainWindow
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            AreYouSure askingWindow = new AreYouSure();
            askingWindow.ShowDialog();
        }
    }
}
