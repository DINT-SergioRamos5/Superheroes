using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    public class Superheroe : INotifyPropertyChanged
    {
        public string Nombre { get; set; }
        public string Enemigo { get; set; }
        public string Foto { get; set; }
        public bool Vengador { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //La interrogacion se introduce para saber si el resultado de la propiedad es nulo.
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Superheroe()
        {
        }        

        public static Superheroe GetSample()
        {
            Superheroe heroe = new Superheroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }
    }
}
