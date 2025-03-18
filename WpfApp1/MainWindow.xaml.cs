﻿using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            fizess.Items.Add("Kártya");
            fizess.Items.Add("Készpénz");
            fizess.SelectedIndex = 0;

            masis.Visibility = Visibility.Hidden;
        }

        private void van(object sender, RoutedEventArgs e)
        {
            if (vanmasis.IsChecked == true)
            {
                masis.Visibility = Visibility.Visible;
            }
            else
            {
                masis.Visibility = Visibility.Hidden;
                szemszam.Text = "";
            }
        }

        private void ment(object sender, RoutedEventArgs e)
        {
            int szsz = 0;
            
            if (vanmasis.IsChecked == true && szemszam.Text != "")
            {
                szsz = Convert.ToInt32(szemszam.Text);
            }

            string sor = $"{nev.Text};{kezddat.Text};{vegdat.Text};{fizess.SelectedItem};{szsz}";
            
            StreamWriter adatok = new StreamWriter("../../../adatok.txt");
            adatok.WriteLine(sor);
            adatok.Close();

            MessageBox.Show(sor, "Sikeres mentés!");
        }
    }
}