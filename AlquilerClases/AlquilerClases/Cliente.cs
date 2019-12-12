using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerClases
{
    public enum Sexo
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
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public Sexo Sexo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

        public static List<Cliente> listadoCliente = new List<Cliente>();

        public static List<Cliente> ObtenerCliente()
        {
            return listadoCliente;
        }
        public static void AgregarCliente(Cliente c)
        {
            listadoCliente.Add(c);
        }

        public static void EliminarCliente(Cliente c)
        {
            listadoCliente.Remove(c);
        }

        public static void EditarCliente(Cliente c, int indice)
        {

            Cliente.listadoCliente[indice] = c;
        }
    }
}
