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
    /// Interaction logic for PersonerCreate.xaml
    /// </summary>
    public partial class PersonerCreate : UserControl
    {
        public PersonerCreate()
        {
            InitializeComponent();
        }

        public void Insert_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.Navn = nameTextBox.Text;
            person.Cpr = cprTextBox.Text;
            person.Alder = Convert.ToInt32(alderTextBox.Text);
            person.Gender = genderTextBox.Text;
            PersonController.pl.AddPerson(person);
        }
    }
}