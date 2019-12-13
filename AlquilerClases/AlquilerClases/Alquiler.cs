using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerClases
{
    public enum EstadoAlq
    {
        Finalizado,
        Vigente
    }
    public class Alquiler
    {
        public int Id { get; set; }
        public Cliente cliente { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrada { get; set; }
        public  EstadoAlq estadoAlq { get; set; }
        public double precioAlq { get; set; }
        public Flota flota { get; set; }
        
        public static List<Alquiler> listaAlquileres = new List<Alquiler>();
        public static void AgregarAlquiler(Alquiler a)
        {
            //listaAlquiler.Add(a);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Alquiler (cliente , FechaSalida, FechaEntrada, estadoAlq, precioAlq, flota) VALUES (@cliente , @FechaSalida, @FechaEntrada, @estadoAlq, @precioAlq, @flota)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = a.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }
        public static void EliminarAlquiler(Alquiler a)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Alquiler where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = a.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarCliente(int index, Alquiler a)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Alquiler SET cliente = @cliente  , FechaSalida = @FechaSalida,  FechaEntrada = @FechaEntrada, estadoAlq = @estadoAlq, precioAlq = @precioAlq, flota = @flota  where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = a.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Alquiler> ObtenerAlquileres()
        {

            Alquiler alquiler;
            listaAlquileres.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                string textoCmd = "Select * from Alquiler";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {


                    alquiler = new Alquiler();
                    alquiler.Id = elLectorDeDatos.GetInt32(0);
                    alquiler.cliente = Cliente.ObtenerCliente(elLectorDeDatos.GetInt32(1));
                    alquiler.FechaSalida = elLectorDeDatos.GetDateTime(2);
                    alquiler.FechaEntrada = elLectorDeDatos.GetDateTime(3);
                    alquiler.estadoAlq = (EstadoAlq)elLectorDeDatos.GetInt32(4);
                    alquiler.precioAlq = elLectorDeDatos.GetDouble(5);
                    alquiler.flota = Flota.ObtenerFlota(elLectorDeDatos.GetInt32(6));

                    listaAlquileres.Add(alquiler);
                }
            }
            return listaAlquileres;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {



            SqlParameter p1 = new SqlParameter("@cliente", this.cliente.Id);
            SqlParameter p2 = new SqlParameter("@FechaSalida", this.FechaSalida);
            SqlParameter p3 = new SqlParameter("@FechaEntrada", this.FechaSalida);
            SqlParameter p4 = new SqlParameter("@estadoAlq", this.estadoAlq);
            SqlParameter p5 = new SqlParameter("@precioAlq", this.precioAlq);
            SqlParameter p6 = new SqlParameter("@flota", this.flota.Id);


            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.DateTime;
            p3.SqlDbType = SqlDbType.DateTime;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.Float;
            p6.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);



            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }

            return cmd;
        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p7 = new SqlParameter("@id", this.Id);
            p7.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p7);

            return cmd;
        }

        public static Alquiler ObtenerAlquiler(int id)
        {
            Alquiler alquiler = null;

            if (listaAlquileres.Count == 0) Alquiler.ObtenerAlquileres();

            foreach (Alquiler a in listaAlquileres)
            {
                if (a.Id == id)
                {
                    alquiler = a;
                    break;
                }

            }
            return alquiler;

        }



        public override string ToString()
        {
            return this.cliente.Nombre;
        }
    }
}
