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

namespace WPFValidacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Persona Persona { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Persona = new Persona();
            this.DataContext = Persona;
        }

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            // Forzar la validación
            BindingExpression binding = nombreTextBox.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();

            if (Validation.GetHasError(nombreTextBox))
            {
                MessageBox.Show("Existen errores de validación.");
            }
            else
            {
                MessageBox.Show("Validación exitosa.");
            }
        }
    }
}
