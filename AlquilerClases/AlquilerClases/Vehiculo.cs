using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerClases
{
    public enum marcas
    {
        Toyota,
        Suzuki,
        Subaru,
        Kia,
        Hyundai,
        Ford,
        Volkswagen,
        Mitsubishi,
    }

    public class Vehiculo
    {
        public string Matricula { get; set; }
        public marcas Marca { get; set; }
        public string Modelo { get; set; }
        public string PuertasCantidad { get; set; }
        public string Plazas { get; set; }
        public DateTime Fecha_Compra { get; set; }

        public override string ToString()
        {
            return Modelo;
        }

        public static List<Vehiculo> listadoVehiculo = new List<Vehiculo>();

        public static List<Vehiculo> ObtenerVehiculo()
        {
            return listadoVehiculo;
        }
        public static void AgregarVehiculo(Vehiculo v)
        {
            listadoVehiculo.Add(v);
        }

        public static void EliminarVehiculo(Vehiculo v)
        {
            listadoVehiculo.Remove(v);
        }

        public static void EditarVehiculo(Vehiculo v, int indice)
        {

            Vehiculo.listadoVehiculo[indice] = v;
        }
    }
}
