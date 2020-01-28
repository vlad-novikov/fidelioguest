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
using System.Windows.Threading;

namespace FidelioGuest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lblInfo.Content="Windows loaded!";

       
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblInfo.Content = DateTime.Now.ToLongTimeString();
         }


        private void ButCheck_Click(object sender, RoutedEventArgs e)
        {
            //butCheck.Content = txtCode.Text;
            txtCode.Text = GetClipboardData();  
        }
        public String GetClipboardData()
        {

            String returnString = "ничего нет";

            
            if (Clipboard.ContainsData("System.String"))
            {
                returnString = Clipboard.GetData("System.String").ToString();
            }           
            return returnString;
        }

        
    }
}
