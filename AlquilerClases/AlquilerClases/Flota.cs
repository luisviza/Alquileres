using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<DetalleFlota> detalleFlota = new List<DetalleFlota>();
        public static List<Flota> listaFlotas = new List<Flota>();


        public static void AgregarFlota(Flota f)
        {
            //listaFlota.Add(f);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Flota (vehiculo , precioDiario, estado) VALUES (@vehiculo , @precioDiario, @estado)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = f.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }
        public static void EliminarFlota(Flota f)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Flota where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = f.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarFlota(int index, Flota f)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                string textoCmd = @"UPDATE Flota SET vehiculo = @vehiculo , precioDiario = @precioDiario, estado = @estado where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = f.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Flota> ObtenerFlotas()
        {

            Flota flota;
            listaFlotas.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Flota";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {


                    flota = new Flota();


                    flota.Id = elLectorDeDatos.GetInt32(0);
                    flota.vehiculo = Vehiculo.ObtenerVehiculo(elLectorDeDatos.GetInt32(1));
                    flota.precioDiario = elLectorDeDatos.GetInt32(2);
                    flota.estado = (Estados)elLectorDeDatos.GetInt32(3);

                    listaFlotas.Add(flota);
                }
            }
            return listaFlotas;
        }



        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {


            SqlParameter p1 = new SqlParameter("@vehiculo", this.vehiculo.Id);
            SqlParameter p2 = new SqlParameter("@precioDiario", this.precioDiario);
            SqlParameter p3 = new SqlParameter("@estado", this.estado);

            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Float;
            p3.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);


            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }

            return cmd;
        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p4 = new SqlParameter("@id", this.Id);
            p4.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p4);

            return cmd;
        }

        public static Flota ObtenerFlota(int id)
        {
            Flota flota = null;

            if (listaFlotas.Count == 0) Flota.ObtenerFlotas();

            foreach (Flota f in listaFlotas)
            {
                if (f.Id == id)
                {
                    flota = f;
                    break;
                }

            }
            return flota;

        }



         public override string ToString()
          {
              return this.vehiculo.Modelo;
          }
    }
}
