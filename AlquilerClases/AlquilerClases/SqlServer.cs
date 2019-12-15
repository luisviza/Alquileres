using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace AlquilerClases
{
    public class SqlServer
    {
        public static string CADENA_CONEXION = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;

        
    }
}



/*---------sqlServerLuisVIza---copiaren el App.config
 * <?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
  </startup>
  <connectionStrings>
    <add name="SqlServerVillalba"
          connectionString="Data Source = VIZABOSSLAPTOUC; 
                            Initial Catalog = Alquileres;
                            Persist Security Info=True;
                            User Id=boss; 
                            Password = 12345"
          providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
 */
/*--------sqlServerAlumno201-----
 <?xml version="1.0" encoding="utf-8" ?>
<configuration>
 <startup>
   <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
 </startup>
 <connectionStrings>
   <add name="SqlServer"
         connectionString="Data Source = M201-10; 
                           Initial Catalog = Alquileres; 
                           User Id=sa; 
                           Password = @lumno123"
         providerName="System.Data.SqlClient" />
 </connectionStrings>
</configuration>*/
