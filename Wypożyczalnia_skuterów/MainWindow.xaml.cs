
using System;
using System.Windows;
using Wypożyczalnia_skuterów_i_motorów.Klasy;

namespace Wypożyczalnia_skuterów_i_motorów
{
    public partial class MainWindow : Window
    {
        private Wypożyczenie wypozyczenie;
        private User currentUser;

        public MainWindow()
        {
            InitializeComponent();
            wypozyczenie = new Wypożyczenie();

            
            // Dodawanie przykładowych skuterów i motorów
            wypozyczenie.DodajPojazd(new Motor(250, 2018, 25, 2.2f, 2.5f));
            wypozyczenie.DodajPojazd(new Motor(300, 2017, 30, 2.4f, 2.7f));
            wypozyczenie.DodajPojazd(new Motor(100, 2019, 15, 1.6f, 2.0f));
            wypozyczenie.DodajPojazd(new Motor(200, 2021, 22, 2.0f, 2.3f));
            wypozyczenie.DodajPojazd(new Motor(125, 2022, 18, 1.7f, 2.1f));

            wypozyczenie.DodajPojazd(new Skuter(50, 2020, 12, true, 1.5f, 1.8f));
            wypozyczenie.DodajPojazd(new Skuter(60, 2019, 10, false, 1.6f, 1.9f));
            wypozyczenie.DodajPojazd(new Skuter(45, 2022, 14, true, 1.4f, 1.7f));
            wypozyczenie.DodajPojazd(new Skuter(55, 2021, 13, false, 1.6f, 1.8f));
            wypozyczenie.DodajPojazd(new Skuter(70, 2018, 11, true, 1.7f, 1.9f));


            // Wyświetlanie dostęnych pojazdów
            UpdateVehicleList();
        }

        

        private void UpdateVehicleList()
        {
            VehiclesListBox.Items.Clear();
            var availableVehicles = wypozyczenie.DostępnePojazdy(DateTime.Now, DateTime.Now.AddDays(1));
            foreach (var vehicle in availableVehicles)
            {
                VehiclesListBox.Items.Add(vehicle.ToString());
            }
        }

        private void RentVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            if (VehiclesListBox.SelectedItem == null || string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {
                StatusMessage.Text = "Proszę wybierz pojazd, który jest aktualnie dostępny.";
                return;
            }

            // Szukanie pojazdu wybranego przez użytkownika
            var availableVehicles = wypozyczenie.DostępnePojazdy(DateTime.Now, DateTime.Now.AddDays(1));
            var selectedVehicle = availableVehicles[VehiclesListBox.SelectedIndex];

            DateTime startDate = StartDatePicker.SelectedDate ?? DateTime.Now;
            DateTime endDate = EndDatePicker.SelectedDate ?? DateTime.Now.AddHours(1);

            if (endDate <= startDate)
            {
                StatusMessage.Text = "Data zakończenia musi być po dacie wynajęcia.";
                return;
            }

            // Tworzenie użytkownika
            currentUser = new User(UserNameTextBox.Text, "test@example.com"); // Email przykładowy
            wypozyczenie.WypożyczPojazd(currentUser, selectedVehicle, startDate, endDate);

            // Reset całego UI
            UpdateVehicleList();
            StatusMessage.Text = $"Pojazd wypożyczony przez {currentUser.Name}.";
        }
    }
}
