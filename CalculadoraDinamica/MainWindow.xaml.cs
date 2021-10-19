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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int tag = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j<= 2; j++)
                {
                    Button boton = new Button();
                    boton.Content = tag;
                    boton.Tag = tag;
                    Grid.SetColumn(boton, j);
                    Grid.SetRow(boton, i);
                    tag++;

                    
                }
            }

            Button boton0 = new Button();
            boton0.Content = 0;
            boton0.Tag = 0;
            Grid.SetColumn(boton0, 0);
            Grid.SetRow(boton0, 4);
            Grid.SetColumnSpan(boton0, 3);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text += ((Button)sender).Tag.ToString();
        }
    }
}
