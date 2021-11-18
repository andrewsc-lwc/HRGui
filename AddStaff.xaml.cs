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
                    //The object call creates an object. This is done simply to ensure that the object is going to be valid before writing.
                    try
                    {
                        new Player(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, playerPosition.Text, Convert.ToInt32(playerGoals.Text), Convert.ToInt32(playerValue.Text));
                        new WriteToData("Player", staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, playerPosition: playerPosition.Text, playerGoals: Convert.ToInt32(playerGoals.Text), playerValue: Convert.ToInt32(playerValue.Text));
                        MessageBox.Show("Player added successfully");
                    }
                    catch 
                    { 
                        MessageBox.Show("Ensure that all fields are filled and the correct data type"); //And data type! Add to message
                    }                    
                    break;
                case 1:
                    try
                    {
                        Coach coach1 = new Coach(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, coachPosition.Text);
                        MessageBox.Show(coach1.DisplayInfo());
                    }
                    catch
                    {
                        MessageBox.Show("Ensure that all fields are filled and the correct data type"); //And data type! Add to message
                    }
                    break;
                case 2:
                    try
                    {
                        Physio physio1 = new Physio(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text, physioSpeciality.Text);
                        MessageBox.Show(physio1.DisplayInfo());
                    }
                    catch
                    {
                        MessageBox.Show("Ensure that all fields are filled and the correct data type"); //And data type! Add to message
                    }
                    break;
                case 3:
                    try
                    {
                        Cleaner cleaner1 = new Cleaner(staffName.Text, Convert.ToInt32(staffWages.Text), staffDOB.Text, staffEmail.Text);
                        MessageBox.Show(cleaner1.DisplayInfo());
                    }
                    catch
                    {
                        MessageBox.Show("Ensure that all fields are filled and the correct data type"); //And data type! Add to message
                    }
                    break;
            }
        }
    }
}
