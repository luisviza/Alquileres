using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public int Id { get; set; }
        public string Matricula { get; set; }
        public marcas Marca { get; set; }
        public string Modelo { get; set; }
        public int PuertasCantidad { get; set; }
        public int Plazas { get; set; }
        public DateTime Fecha_Compra { get; set; }

        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public static void AgregarVehiculo(Vehiculo v)
        {
            //listaVehiculos.Add(v);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();
                string textoCmd = @"insert into Vehiculo (Matricula, Marca, Modelo, PuertasCantidad, Plazas, Fecha_Compra ) VALUES (@Matricula, @Marca, @Modelo, @PuertasCantidad, @Plazas, @Fecha_Compra)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@Matricula", v.Matricula);
                SqlParameter p2 = new SqlParameter("@Marca", v.Marca);
                SqlParameter p3 = new SqlParameter("@Modelo", v.Modelo);
                SqlParameter p4 = new SqlParameter("@PuertasCantidad", v.PuertasCantidad);
                SqlParameter p5 = new SqlParameter("@Plazas", v.Plazas);
                SqlParameter p6 = new SqlParameter("@Fecha_Compra", v.Fecha_Compra);

                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.Int;
                p5.SqlDbType = SqlDbType.Int;
                p6.SqlDbType = SqlDbType.DateTime;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();


            }
        }
        public static void EliminarVehiculo(Vehiculo v)
        {
            //listaVehiculos.Remove(v);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Vehiculo where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p7 = new SqlParameter("@Id", v.Id);
                p7.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p7);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarVehiculo(int index, Vehiculo v)
        {
            //listaVehiculos[index] = v;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();//(Matricula, Marca, Modelo, PuertasCantidad, Plazas, Fecha_Compra ) 

                string textoCmd = @"UPDATE Vehiculo SET Matricula = @Matricula, Marca = @Marca  , Modelo = @Modelo ,  PuertasCantidad = @PuertasCantidad, Plazas = @Plazas, Fecha_Compra = @Fecha_Compra where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@Matricula", v.Matricula);
                SqlParameter p2 = new SqlParameter("@Marca", v.Marca);
                SqlParameter p3 = new SqlParameter("@Modelo", v.Modelo);
                SqlParameter p4 = new SqlParameter("@PuertasCantidad", v.PuertasCantidad);
                SqlParameter p5 = new SqlParameter("@Plazas", v.Plazas);
                SqlParameter p6 = new SqlParameter("@Fecha_Compra", v.Fecha_Compra);
                SqlParameter p7 = new SqlParameter("@Id", v.Id);

                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.Int;
                p5.SqlDbType = SqlDbType.Int;
                p6.SqlDbType = SqlDbType.DateTime;
                p7.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Vehiculo> ObtenerVehiculos()
        {
            //return listaVehiculos;
            Vehiculo vehiculo;
            listaVehiculos.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Vehiculo";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {


                    vehiculo = new Vehiculo();
                    vehiculo.Id = elLectorDeDatos.GetInt32(0);
                    vehiculo.Matricula = elLectorDeDatos.GetString(1);
                    vehiculo.Marca = (marcas)elLectorDeDatos.GetInt32(2);
                    vehiculo.Modelo = elLectorDeDatos.GetString(3);
                    vehiculo.PuertasCantidad = elLectorDeDatos.GetInt32(4);
                    vehiculo.Plazas = elLectorDeDatos.GetInt32(5);
                    vehiculo.Fecha_Compra = elLectorDeDatos.GetDateTime(6);


                    listaVehiculos.Add(vehiculo);
                }
            }
            return listaVehiculos;
        }

        public static Vehiculo ObtenerVehiculo(int id)
        {
            Vehiculo vehiculo = null;

            if (listaVehiculos.Count == 0) Vehiculo.ObtenerVehiculos();

            foreach (Vehiculo v in listaVehiculos)
            {
                if (v.Id == id)
                {
                    vehiculo = v;
                    break;
                }

            }
            return vehiculo;

            

        }



        public override string ToString()
        {
            
            return this.Modelo;
        }

    }
}
