using System.ComponentModel;


namespace WPFValidacion
{
        public class Persona : INotifyPropertyChanged
        {
            private string nombre;

            public string Nombre
            {
                get { return nombre; }
                set
                {
                    if (nombre != value)
                    {
                        nombre = value;
                        OnPropertyChanged("Nombre");
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }




