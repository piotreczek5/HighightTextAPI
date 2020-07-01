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
        public event EventHandler<MainWindowEvents> CountOfRulesEvent;

        protected void OnCountOfRulesEvent(MainWindowEvents e)
        {
            if (this.CountOfRulesEvent != null)
                this.CountOfRulesEvent(this, e);
        }

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;

            ListOfRules.SelectionMode = SelectionMode.Single;
            //ListBox listOfRules = new ListBox();
            //int numberOfRules = ListOfRules.Items.Count;

            //test stuff so Id doesn't work rn
            /*
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "First rule" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "Rule index 1" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "YEP COCK" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "what a great app" });
            ListOfRules.Items.Add(new NewRule { Id = numberOfRules, Rule = "Text from the box"});
            */

            //ListOfTypeForRules codeListOfRulesClass = new ListOfTypeForRules();
            //List<NewRule> codeListOfRules = codeListOfRulesClass.GetListOfRules();

            int idToPutIn = codeListOfRules.Count();

            codeListOfRules.Add(new NewRule { Id = idToPutIn, Rule = "Rule from codeList" });
            idToPutIn = codeListOfRules.Count();
            codeListOfRules.Add(new NewRule { Id = idToPutIn, Rule = "Second rule from codeList" });
            idToPutIn = codeListOfRules.Count();
            codeListOfRules.Add(new NewRule { Id = idToPutIn, Rule = "Third rule from codeList" });


            int cLORLength = codeListOfRules.Count();

            for (int i = 0; i < cLORLength; i++)
            {
                ListOfRules.Items.Add(codeListOfRules[i]);
            }

        }
/*
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RuleAddWindow ruleWindow = new RuleAddWindow();
            ruleWindow.Iwent += new EventHandler(ruleWindow_Iwent);
            ruleWindow.ShowDialog();
        }
*/
        void ruleWindow_AddRuleEvent(object sender, RuleAddEvents e)
        {
            //that below works
            //MessageBox.Show(e.EventTextOfRule);
            //ListOfRules.Items.Add(new NewRule { Id = e.EventIdOfRule, Rule = e.EventTextOfRule });

            //ListOfTypeForRules listClass = new ListOfTypeForRules();
            //List<NewRule> list = listClass.GetListOfRules();

            // it messes up id when we delete one from the middle somewhere
            int y = codeListOfRules.Count();

            codeListOfRules.Add(new NewRule { Id = y, Rule = e.EventTextOfRule });
            ListOfRules.Items.Add(codeListOfRules[y]);
        }


        //it propably should be declared in the class or something :/
        public List<NewRule> codeListOfRules = new List<NewRule>();


        /*
        public class ListOfTypeForRules
        {
            //below the declaration of list I need to add rules from database to the list and than from list to the ListOfRules
            //need to make it public somehow, so i can access it from different classes / files
            


            public List<NewRule> GetListOfRules()
            {
                //return codeListOfRules;
                return null;
            }
           
        }
        */

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
            MainWindowEvents indexSendEvent = new MainWindowEvents();
            indexSendEvent.CountIdEvent = codeListOfRules.Count();
            this.OnCountOfRulesEvent(indexSendEvent);

            RuleAddWindow ruleWindow = new RuleAddWindow();
            ruleWindow.AddRuleEvent += new EventHandler<RuleAddEvents>(ruleWindow_AddRuleEvent);
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
                int indexOfSelectedRule = ListOfRules.SelectedIndex;

                codeListOfRules.Remove(codeListOfRules[indexOfSelectedRule]);

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

    public class MainWindowEvents : EventArgs
    {
        public int CountIdEvent { get; set; }
    }
}
