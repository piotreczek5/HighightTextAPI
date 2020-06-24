using System;
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

namespace BasicMechanism
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;

            ListOfRules.SelectionMode = SelectionMode.Single;
            //ListBox listOfRules = new ListBox();
            int numberOfRules = ListOfRules.Items.Count;

            //test stuff so Id doesn't work rn
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "First rule" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "Rule index 1" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "YEP COCK" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "what a great app" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "Text from the box"});


        }

        public class NewRule
        {
            public int Id { get; set; }
            public string Rule { get; set; }
            //+color

            //override ToString() to get text in the viewBox
            public override string ToString()
            {
                return Id + ") " + Rule;
            }
        }


        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            RuleAddWindow ruleAddWindow = new RuleAddWindow();
            ruleAddWindow.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            //ListOfRules.Items.Remove("Dogshit");
            if (ListOfRules.SelectedItem != null)
            {
                object selected = ListOfRules.SelectedItem;
                ListOfRules.Items.Remove(selected);
                TextOfRule.Text = "";
                //Need to find a way to use AreYouSure window for every close without saving option
                // maybe somehow pass the windows name on open so than we can use it to close that window in areyousure
                // and not hard coded one
            }
            else
            {
                TextOfRule.Text = "Please select item from the list you want to delete.";
            }
        }

        private void ListOfRules_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selected = ListOfRules.SelectedItem;
            if(selected != null)
                TextOfRule.Text = selected.ToString();
        }
    }
}
