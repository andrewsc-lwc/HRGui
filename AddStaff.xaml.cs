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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for AddStaff.xaml
    /// </summary>
    public partial class AddStaff : Window
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void hideAllExtras()
        {
            playerGoals.Visibility = Visibility.Hidden;
            playerValue.Visibility = Visibility.Hidden;
            playerPosition.Visibility = Visibility.Hidden;
            coachPosition.Visibility = Visibility.Hidden;
            physioSpeciality.Visibility = Visibility.Hidden;
            goalsLabel.Visibility = Visibility.Hidden;
            valueLabel.Visibility = Visibility.Hidden;
            playerPositionLabel.Visibility = Visibility.Hidden;
            coachPositionLabel.Visibility = Visibility.Hidden;
            specialityLabel.Visibility = Visibility.Hidden;
        }
        private void showPlayerDetails()
        {
            hideAllExtras();
            playerGoals.Visibility = Visibility.Visible;
            playerValue.Visibility = Visibility.Visible;
            playerPosition.Visibility = Visibility.Visible;
            goalsLabel.Visibility = Visibility.Visible;
            valueLabel.Visibility = Visibility.Visible;
            playerPositionLabel.Visibility = Visibility.Visible;
        }
        private void showCoachDetails()
        {
            hideAllExtras();
            coachPosition.Visibility = Visibility.Visible;
            coachPositionLabel.Visibility = Visibility.Visible;
        }
        private void showPhysioDetails()
        {
            hideAllExtras();
            physioSpeciality.Visibility = Visibility.Visible;
            specialityLabel.Visibility = Visibility.Visible;
        }

        private void addJobCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice;
            choice = addJobCategory.SelectedIndex;
            switch (choice)
            {
                case 0:
                    showPlayerDetails();
                    break;
                case 1:
                    showCoachDetails();
                    break;
                case 2:
                    showPhysioDetails();
                    break;
                case 3:
                    hideAllExtras();
                    break;
            }
        }

        private void addStaffMember_Click(object sender, RoutedEventArgs e)
        {
            int choice;
            choice = addJobCategory.SelectedIndex;
            switch (choice)
            {
                case 0:
                    Player player1 = new Player(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, playerPosition.Text, Convert.ToInt32(playerGoals.Text), Convert.ToInt32(playerValue.Text));
                    MessageBox.Show(player1.DisplayInfo());
                    this.Close();
                    break;
                case 1:
                    Coach coach1 = new Coach(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, coachPosition.Text);
                    MessageBox.Show(coach1.DisplayInfo());
                    break;
                case 2:
                    Physio physio1 = new Physio(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, physioSpeciality.Text);
                    MessageBox.Show(physio1.DisplayInfo());
                    break;
                case 3:
                    Cleaner cleaner1 = new Cleaner(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text);
                    MessageBox.Show(cleaner1.DisplayInfo());
                    break;
            }
        }
    }
}
