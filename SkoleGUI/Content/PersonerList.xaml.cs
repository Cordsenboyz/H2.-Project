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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Skole_Libary;

namespace SkoleGUI
{
    /// <summary>
    /// Interaction logic for PersonerList.xaml
    /// </summary>
    public partial class PersonerList : UserControl
    {
        public PersonerList()
        {
            InitializeComponent();
        }

        public void searchButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Person person in PersonController.pl.Folk)
            {
                boxList.Items.Add(person);
            }
        }
    }
}