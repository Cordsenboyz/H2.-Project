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

namespace SkoleGUI
{
    /// <summary>
    /// Interaction logic for PersonContent.xaml
    /// </summary>
    public partial class PersonContent : UserControl
    {
        public PersonContent()
        {
            InitializeComponent();
        }

        private void CreatePerson_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Instance.Navigate(new PersonerCreate());
        }

        private void ListPerson_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Instance.Navigate(new PersonerList());
        }
    }
}