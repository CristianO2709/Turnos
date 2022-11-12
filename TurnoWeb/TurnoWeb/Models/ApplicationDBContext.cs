using Microsoft.EntityFrameworkCore;

namespace TurnoWeb.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        //Aquí van todas las tablas que se crearan en la base de datos
    }
}
