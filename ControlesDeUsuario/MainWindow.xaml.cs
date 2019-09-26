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

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboFifura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GrindParametrosFigura.Children.Clear(); //Clear es para borrar todos los elementos por dentro a la guarderia children, children es todos los elementos contenidos 
            switch (ComboFifura.SelectedIndex)
            {
                case 0: //Circulo
                    GrindParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
                case 1: //Triangulo
                    GrindParametrosFigura.Children.Add(new ParametrosTriangulo()); //Van numerados dependiendo de la forma acomodada, en este caso el 0 es el circulo por ser el primero en el Mainwindow.xaml y luego el triangulo siendo este el 1 por ser el segundo
                    break;
                case 2: //Rectangulo
                    GrindParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3: //Pentagono 
                    GrindParametrosFigura.Children.Add(new ParametroPentagono());
                    break;
                case 4: //Cuadrado
                    GrindParametrosFigura.Children.Add(new ParametroCuadrado());
                    break;
                case 5:
                    GrindParametrosFigura.Children.Add(new ParametroTrapecio());
                    break;
                default:
                    break;
            }
        }
    }
}
