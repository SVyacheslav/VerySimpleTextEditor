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
using System.Windows.Controls.Primitives;

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CUT_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.SelectedText !="") {
                textBox.Cut();
            }
        }

        private void COPY_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Copy();
            }
        }

        private void PASTE_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox.Paste(); 
            }
        }
    }
}
