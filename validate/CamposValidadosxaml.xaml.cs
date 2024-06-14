
using System.Text.RegularExpressions;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

using System.Windows.Input;

namespace WPFValidacion.validate
{
    /// <summary>
    /// Interaction logic for CamposValidadosxaml.xaml
    /// </summary>
    public partial class CamposValidadosxaml : Window
    {
        public Persona Persona { get; set; }
        public CamposValidadosxaml()
        {
            InitializeComponent();
            Persona = new Persona();
            this.DataContext = Persona;
        }

        private static readonly Regex regex = new Regex("[^0-9. -]+");
        private static bool OnlyNumberText(string Text)
        {
            return !regex.IsMatch(Text);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !OnlyNumberText(e.Text);
        }

        private void ValidateButton_Click_1(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = nombreTXT.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();

            if (Validation.GetHasError(nombreTXT))
            {
                MessageBox.Show("Existen errores de validación.");
            }
            else
            {
                MessageBox.Show("Validación exitosa.");
            }
        }

        private static readonly Regex regex1 = new Regex("[^a-zA-Z]+");
        //Secuencia de caracteres que define un patrón de búsqueda

        private static bool OnlyText(string Text)
        {
            return !regex1.IsMatch(Text);
        }
        private void nombreTXT_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !OnlyText(e.Text);
        }


    }
}
