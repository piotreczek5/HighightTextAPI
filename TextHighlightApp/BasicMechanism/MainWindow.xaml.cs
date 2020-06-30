using System;
using System.Collections.Generic;
using System.Data;
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
        //CHANGE LOADED TO SOMETHING LIKE BUTTON ON CLICK AND IT SHOULD BE FINE
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

            //trying to catch the get the data from the other window
            //RuleAddWindow eventFromRuleAdd = new RuleAddWindow();
            //eventFromRuleAdd.

            //second try:
            //this.Loaded += new RoutedEventHandler(ButtonAdd_Click);



            //this.ButtonAdd.Click += new RoutedEventHandler(ButtonAdd_Click);

        }
/*
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RuleAddWindow ruleWindow = new RuleAddWindow();
            ruleWindow.Iwent += new EventHandler(ruleWindow_Iwent);
            ruleWindow.ShowDialog();
        }
*/
        void ruleWindow_Iwent(object sender, RuleAddEvents e)
        {
            //RuleAddWindow ruleWindow = new RuleAddWindow();
            //string text = ruleWindow.RuleText.Text;
            //MessageBox.Show(text);

            //that below works
            //MessageBox.Show(e.EventTextOfRule);
            ListOfRules.Items.Add(new NewRule { Id = e.EventIdOfRule, Rule = e.EventTextOfRule });

        }

        //end of second try

        public class NewRule
        {
            //After removing item from the list there will be missing id and than using new rule
            //will give already existing id to the item couse of numberOfRules changed
            //(we could try to do something if id is existing already +1 till it finds free one but....
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
            RuleAddWindow ruleWindow = new RuleAddWindow();
            ruleWindow.Iwent += new EventHandler<RuleAddEvents>(ruleWindow_Iwent);
            ruleWindow.ShowDialog();

            /*
                        RuleAddWindow ruleAddWindow = new RuleAddWindow();
                        ruleAddWindow.ShowDialog();
            */
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            //ListOfRules.Items.Remove("Dogshit");
            if (ListOfRules.SelectedItem != null)
            {
                object selected = ListOfRules.SelectedItem;
                ListOfRules.Items.Remove(selected);
                TextOfRule.Text = null;
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

    // idk if this will help. for now i'm tyring to do simple add so i can pass data one way. i'll try to send data form here on edit click
    public class HandlingEventsMainWindow
    {

    }

    class MainWindowEvents : EventArgs
    {

    }
}
