using System.Net;
using System.Security.Cryptography.X509Certificates;
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

namespace BankAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Bank bank;
        public MainWindow()
        {
            InitializeComponent();
            bank = new Bank("60-67-80", 100);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int acc_no;
            ///
            acc_no = bank.CreateAccount(Forename.Text, Surname.Text, Address.Text);
            AccNo.Text = Convert.ToString(acc_no);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string address = bank.GetDetails(Convert.ToInt32(AccNo.Text));
            AllDetails.Text = address;
        }
    }
}