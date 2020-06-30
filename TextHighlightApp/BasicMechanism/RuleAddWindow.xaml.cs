﻿using System;
using System.Collections.Generic;
using System.Data;
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
        //CHANGE LOADED TO SOMETHING LIKE BUTTON ON CLICK AND IT SHOULD BE FINE
        public event EventHandler<RuleAddEvents> Iwent;

        // i think data should be passed here where is EventArgs.Empty so it should be moved into the button click or something like that method
        // or i should somewhow do the variable to store data i want from what method i want
        protected void OnIwent(RuleAddEvents e)
        {
            EventHandler<RuleAddEvents> handler = Iwent;
            if (this.Iwent != null)
                this.Iwent(this, e);
        }

        public RuleAddWindow()
        {
            InitializeComponent();
            //maybe do some event handler and event that will pass the data on close / open
            // so than i would be able to use RuleAddWindow for edit and add.
            //couse edit is basically add with data passed on open

            /*
            //instance of an event but in main function not the button couse i was trying to get that form other window but failed for now 
            var iwent = new RuleAddEvents();
            iwent.EventIdOfRule = 69;
            iwent.EventTextOfRule = "bla bla bla";
            */


            //this.ButtonAccept.Click += new RoutedEventHandler(ButtonAccept_Click);
        }
        /*
        void RuleAddWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.OnIwent();
        }
        */
        public void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            string text = RuleText.Text;
            Window mainWindow = Application.Current.MainWindow;

            //id might be set to the number of existing rules [if that's possible]
            // don't know how to refer to the list of rules couse it's set in the xml not c#
            //mainWindow.ListOfRules.Items.Add(new NewRule { Id = 0, Rule = text });
            /*
                        var iwent = new RuleAddEvents();
                        iwent.EventIdOfRule = 69;
                        iwent.EventTextOfRule = text;
            */

            RuleAddEvents ruleEvent = new RuleAddEvents();
            ruleEvent.EventTextOfRule = text;
            ruleEvent.EventIdOfRule = 69;

            this.OnIwent(ruleEvent);
            this.Close();
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            AreYouSure askingWindow = new AreYouSure();
            askingWindow.ShowDialog();
        }
        /*
         //some weird shit. trying to set up an event
        public class RuleAddEventsHandler
        {
            public event EventHandler<RuleAddEvents> RuleAddAddRule;
            
            public void WhatTheHellIsThatRuleAdd(RuleAddEvents ev)
            {
                RuleAddAddRule?.Invoke(this, ev);
            }
        }
        */
    }
    //event template
    public class RuleAddEvents : EventArgs
    {
        public int EventIdOfRule { get; set; }
        public string EventTextOfRule { get; set; }
        //color
        // stuff that I want to pass in the event
    }
}
