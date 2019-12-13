using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerClases
{
    public enum Sexos
    {
        Femenino,
        Masculino
    }
    public enum Nacionalidades
    {
        afgano,
        albanés,
        Argelino,
        Andorrano,
        Angola,
        Antigua,
        Argentina,
        armenio,
        Australiano,
        austriaco,
        Azerbaiyano,
        Bahameño,
        Bahrein,
        bengalí,
        Barbados,
        Bielorruso,
        Belga,
        Beliceño,
        Beninés,
        Butanés,
        boliviano,
        Bosnio,
        Motswana,
        brasileño,
        Bruneián,
        Bulgarian,
        Burkinabé,
        birmano,
        Burundiano,
        Cabo,
        Camboyano,
        camerunés,
        canadiense,
        Centroafricano,
        Chadiano,
        Chileno,
        Chino,
        colombianas,
        Comoras,
        congoleña,
        Costa,
        Marfileño,
        croata,
        Cubano,
        Chipriota,
        Checo,
        danés,
        Djibouti,
        Dominicanas,
        Timorense,
        ecuatoriano,
        Egipcio,
        salvadoreño,
        Ecuatoguineano,
        Eritreo,
        Estonia,
        etíope,
        Fijian,
        Finnish,
        Francés,
        Gabonés,
        Gambiano,
        georgiano,
        Alemán,
        ghanés,
        Gibraltar,
        Griego,
        Granada,
        guatemalteco,
        Guineano,
        BissauGuineano,
        Guyana,
        danza,
        hondureña,
        Húngaro,
        islandés,
        indio,
        Indonesian,
        Iraní,
        iraquí,
        irlandés,
        israelí,
        Italiano,

        jamaicano,
        Japonés,
        Jordano,
        Kazajo,
        Keniano,
        Kiribati,
        Norcoreano,
        Surcoreano,
        Kuwaití,
        Kirguistán,
        Lao,
        Letón,
        libanés,
        Basotho,
        Liberiano,
        Libio,
        Liechtenstein,
        lituano,
        Luxemburgo,
        macedonio,
        madagascarí,
        Malawiano,
        Malasio,
        Maldivas,
        Maliense,
        maltés,
        Islas,
        Martiniquais,
        mauritano,
        mauriciano,
        Mexicano,
        Micronesia,
        Moldavo,
        Monégasque,
        mongol,
        montenegrino,
        marroquí,
        mozambiqueño,
        namibio,
        nauruana,
        Nepalí,
        Holandés,
        Nueva,
        nicaragüense,
        Nigeriano,

        Marianan,
        Norwegian,
        omaní,
        Paquistaní,
        Palauan,
        palestino,
        panameño,
        Papua,
        Paraguayo,
        peruano,
        Filipino,
        polaco,
        Portuguese,
        puertorriqueño,
        Qatar,
        rumano,
        Ruso,
        Ruandés,
        Kittitian,
        Saint,
        SanSamoano,
        Sammarinese,
        Arabia,
        Senegal,
        serbio,
        Seychelles,
        Sierra,
        Singapur,
        Slovak,
        Esloveno,
        Solomon,
        somalí,
        sudafricano,
        Sudán,

        sudanés,
        surinamés,
        Swazi,
        Swedish,
        suizo,
        Sirio,
        Tajikistani,
        Tanzania,
        Thai,

        Togolés,
        Tokelauan,
        Tonga,

        tunecino,
        turco,
        Turkmenistán,
        tuvaluano,
        Uganda,
        ucranio,
        Emirati,

        uruguayo,
        Uzbeko,
        NiVanuatu,
        Vaticano,
        venezolano,
        vietnamita,
        yemenita,
        Zambia,
        zimbabuo

    }
    public class Cliente
    {
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public Nacionalidades Nacionalidad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public Sexos Sexo { get; set; }
        public static List<Cliente> listaClientes = new List<Cliente>();


        public static void AgregarCliente(Cliente c)
        {
            //listaClientes.Add(c);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Cliente (NumeroDocumento , Nombre, Nacionalidad,
	Fecha_Nacimiento, Direccion, Contacto, Sexo) VALUES (@NumeroDocumento, @Nombre, @Nacionalidad,
	@Fecha_Nacimiento, @Direccion, @Contacto, @Sexo)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }
        public static void EliminarCliente(Cliente c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Cliente where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarCliente(int index, Cliente c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Cliente SET NumeroDocumento = @NumeroDocumento  , Nombre = @Nombre, Nacionalidad = @Nacionalidad,
	Fecha_Nacimiento = @Fecha_Nacimiento, Direccion = @Direccion, Contacto = @Contacto, Sexo = @Sexo where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Cliente> ObtenerClientes()
        {

            Cliente cliente;
            listaClientes.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Cliente";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {

                    
                    cliente = new Cliente();
                    cliente.Id = elLectorDeDatos.GetInt32(0);
                    cliente.NumeroDocumento = elLectorDeDatos.GetString(1);
                    cliente.Nombre = elLectorDeDatos.GetString(2);
                    cliente.Nacionalidad = (Nacionalidades)elLectorDeDatos.GetInt32(3);
                    cliente.Fecha_Nacimiento = elLectorDeDatos.GetDateTime(4);
                    cliente.Direccion = elLectorDeDatos.GetString(5);
                    cliente.Contacto = elLectorDeDatos.GetString(6);
                    cliente.Sexo = (Sexos)elLectorDeDatos.GetInt32(7);


                    listaClientes.Add(cliente);
                }
            }
            return listaClientes;
        }



        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            

            SqlParameter p1 = new SqlParameter("@NumeroDocumento", this.NumeroDocumento);
            SqlParameter p2 = new SqlParameter("@Nombre", this.Nombre);
            SqlParameter p3 = new SqlParameter("@Nacionalidad", this.Nacionalidad);
            SqlParameter p4 = new SqlParameter("@Fecha_Nacimiento", this.Fecha_Nacimiento);
            SqlParameter p5 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p6 = new SqlParameter("@Contacto", this.Contacto);
            SqlParameter p7 = new SqlParameter("@Sexo", this.Sexo);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.DateTime;
            p5.SqlDbType = SqlDbType.VarChar;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);


            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }

            return cmd;
        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p8 = new SqlParameter("@id", this.Id);
            p8.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p8);

            return cmd;
        }

        public static Cliente ObtenerCliente(int id)
        {
            Cliente cliente = null;

            if (listaClientes.Count == 0) Cliente.ObtenerClientes();

            foreach (Cliente c in listaClientes)
            {
                if (c.Id == id)
                {
                    cliente = c;
                    break;
                }

            }
            return cliente;

        }



        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
