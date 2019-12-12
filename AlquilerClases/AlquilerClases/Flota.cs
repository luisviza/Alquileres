using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerClases
{
    public enum Estados{
        Disponible,
        Alquilado
    }
    public class Flota
    {
        
        public int Id { get; set; }
        public Vehiculo vehiculo { get; set; }
        public float precioDiario { get; set; }
        public Estados estado { get; set; }
        

        public override string ToString()
        {
            return "Flota";
        }

        public static List<Flota> listadoFlota = new List<Flota>();

        public static List<Flota> ObtenerFlota()
        {
            return listadoFlota;
        }
        public static void AgregarFlota(Flota f)
        {
            listadoFlota.Add(f);
        }

        public static void EliminarFlota(Flota f)
        {
            listadoFlota.Remove(f);
        }

        public static void EditarFlota(Flota f, int indice)
        {

            Flota.listadoFlota[indice] = f;
        }
    }
}
