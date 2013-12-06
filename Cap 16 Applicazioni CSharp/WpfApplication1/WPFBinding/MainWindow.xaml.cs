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

namespace WPFBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = GenerateData();
           
        }

        private List<Customer> GenerateData()
        {
            List<Customer> clienti = new List<Customer>();
            clienti.Add(new Customer() { Name = "Antonio" });
            clienti.Add(new Customer() { Name = "John" });
            clienti.Add(new Customer() { Name = "James" });
            clienti.Add(new Customer() { Name = "Bill" });
            clienti.Add(new Customer() { Name = "Matthew" });

            return clienti;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }


}
