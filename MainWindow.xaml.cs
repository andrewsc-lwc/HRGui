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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello "+firstNameText.Text);

            TestClass myClass = new TestClass();
            string message = myClass.myValue();
            //MessageBox.Show(message);
            new MainWindow().Show();
           
            
        }

        private void submitComboBoxJobs_Click(object sender, RoutedEventArgs e)
        {
            new AddStaff().Show();
            
        }

        private void oldCode()
        {
            Staff staff1 = new Staff("Bob", 1, "09/09/1999", "bob@lordwandsworth.org");
            Console.WriteLine(staff1.DisplayInfo());
            Coach coach1 = new Coach("Chris Andrews", 25000, "03 / 09 / 1984", "andrewsc@lordwandsworth.org", "Goalkeeping");
            Console.WriteLine(coach1.DisplayInfo());
            Player player1 = new Player("Cristiano Ronaldo", 40000000, "05 / 10 / 1985", "ronaldoc@lordwandsworth.org", "Forward", 78, 90000000);
            Console.WriteLine(player1.DisplayInfo());
            Cleaner cleaner1 = new Cleaner("George Jones", 8000, "13 / 03 / 1989", "jonesg@lordwandsworth.org");
            Console.WriteLine(cleaner1.DisplayInfo());
            Physio physio1 = new Physio("James Jones", 15000, "30 / 02 / 1967", "jonesj@lordwandsworth.org", "Muscle");
            Console.WriteLine(physio1.DisplayInfo());
        }

        private void Move_Rect(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {                
                var x = Canvas.GetLeft(myRectangle);
                Canvas.SetLeft(myRectangle, x + 2);
            }
            else if (e.Key == Key.Left)
            {                
                var x = Canvas.GetLeft(myRectangle);
                Canvas.SetLeft(myRectangle, x - 2);
            }
            else if (e.Key == Key.Up)
            {
                var y = Canvas.GetTop(myRectangle);
                Canvas.SetTop(myRectangle, y - 2);
            }
            else if (e.Key == Key.Down)
            {
                var y = Canvas.GetTop(myRectangle);
                Canvas.SetTop(myRectangle, y + 2);
            }

        }
    }
}
