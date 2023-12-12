namespace TiendaAPI.Conexion
{
    public class ConexionBD
    {

        private string connectionstring = string.Empty;
        public ConexionBD()
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            connectionstring = builder.GetSection("ConnectionStrings:conexionmaestra").Value;

        }
        public string CadenaSQL()
        {
            
            return connectionstring;    

        }

    }
}
