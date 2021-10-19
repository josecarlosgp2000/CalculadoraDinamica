﻿using System.Windows;
using System.Windows.Controls;

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

            int numeroCorrespondiente = 1;
            for (int fila = 1; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {

                    //Creamos y configuramos el botón
                    Button boton = new Button();
                    Grid.SetRow(boton, fila);
                    Grid.SetColumn(boton, columna);
                    boton.Margin = new Thickness(5);
                    boton.Click += Button_Click;
                    boton.Tag = numeroCorrespondiente;

                    //Creamos y configuramos el contenido del botón
                    TextBlock texto = new TextBlock();
                    texto.Text = numeroCorrespondiente.ToString();
                    Viewbox box = new Viewbox();
                    box.Child = texto;
                    boton.Content = box;

                    numeroCorrespondiente++;
                    //Introducimos el botón en el Grid
                    PrincipalGrid.Children.Add(boton);
                }
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += ((Button)sender).Tag.ToString();
        }
    }
}