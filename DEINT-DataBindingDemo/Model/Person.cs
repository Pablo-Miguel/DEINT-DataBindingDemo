using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DEINT_DataBindingDemo.Model
{
    public class Person: INotifyPropertyChanged
    {

        private string nombre;
        private string direccion;
        private int edad;

        public string Nombre { 
            get=>nombre; 
            set { 
                nombre = value;
                OnPropertyChanged();
            } 
        }
        public string Direccion {
            get => direccion;
            set
            {
                direccion = value;
                OnPropertyChanged();
            }
        }
        public int Edad {
            get => edad;
            set
            {
                edad = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
