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
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class ContentArea : UserControl
    {
        public static ContentArea Instance;

        public ContentArea()
        {
            InitializeComponent();
            Instance = this;
        }

        public void Navigate(UserControl content)
        {
            Content = content;
        }
    }
}