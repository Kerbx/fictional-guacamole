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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace kurwa1
{
    /// <summary>
    /// Логика взаимодействия для SingUpWindow.xaml
    /// </summary>
    public partial class SingUpWindow : Window
    {
        public SingUpWindow()
        {
            InitializeComponent();
        }
        private void CloseB_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinusB_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
