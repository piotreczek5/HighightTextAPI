using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static BasicMechanism.MainWindow;

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
            //maybe do some event handler and event that will pass the data on close / open
            // so than i would be able to use RuleAddWindow for edit and add.
            //couse edit is basically add with data passed on open
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            string text = RuleText.Text;
            Window mainWindow = Application.Current.MainWindow;

            //id might be set to the number of existing rules [if that's possible]
            // don't know how to refer to the list of rules couse it's set in the xml not c#
            //mainWindow.ListOfRules.Items.Add(new NewRule { Id = 0, Rule = text });

            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            AreYouSure askingWindow = new AreYouSure();
            askingWindow.ShowDialog();
        }
    }
}
