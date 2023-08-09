using Microsoft.EntityFrameworkCore;

namespace Livro.Data
{
    public class ApplicationDBCntext: DbContext
    {
        public ApplicationDBCntext(DbContextOptions<ApplicationDBCntext> options) : base(options) 
        {

        }
    }
}
