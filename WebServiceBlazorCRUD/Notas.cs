using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceBlazorCRUD
{
    public class Notas
    {
        /*RECORDAR SIEMPRE AGREGAR LOS PAQUETES CORE,CORE.(DESIGN,RELATIONAL,SQLSERVER,TOOLS) PARA LA IMPORTACION Y MIGRACION-EXPORTACION
         
         ***************************IMPORTAR DESDE SQL SERVER**************
         * para Importar de VISUAL STUDIO DESDE base de datos
         Scaffold-DbContext "data source=192.168.0.100; initial Catalog=ZEUS_POS_FE;uid=SPV;pwd=1234" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        ***************************IMPORTAR DESDE SQL SERVER**************
        Models
        *****************************MIGRAR********************************
        para exportar una tabla de visual hacia sql server
        PRIMERO se crea la clase que seran las tablas en sql server en Models

        SEGUNDO creas el :DbContext
        agregando la siguientes lineas
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
        public DbSet<zz_tablaTest> zz_tablaTest { get; set; } // se agrega todas las clases creadas para exportar

        TERCERO se agrega la siguiente linea en Startup en el metodo ConfigureServices
        //Configuracion de Cadena de conexion - migracion
        services.AddDbContext<AppDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("cn"))); 

        ir a la consola de nuget
        - AppDbContext es mi DbContext para crear la migracion
        CUARTO: add-migration MigracionInicial -Context AppDbContext --> con esto se crearan los archivos para la migracion a la base de datos carpeta Migrations
        
        QUINTO: update-datebase -Context AppDbContext
        
        *****************************MIGRAR********************************



















         */
    }
}
