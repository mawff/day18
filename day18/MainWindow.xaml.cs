using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace day18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Hotel> CurrentHotels { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация данных напрямую в коде
            CurrentHotels = new List<Hotel>
            {
                new Hotel { id = 1, Name = "Grand Hotel", GameOfStars = 5, CountryName = "France", HotelImage = "image1.jpg" },
                new Hotel { id = 2, Name = "Seaside Resort", GameOfStars = 4, CountryName = "Spain", HotelImage = "image2.jpg" },
                new Hotel { id = 3, Name = "Mountain View", GameOfStars = 3, CountryName = "Switzerland", HotelImage = "image3.jpg" }
            };

            DataContext = this;
        }
    }


}