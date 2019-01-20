using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SDI_Test.Models
{
    
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(): base()
        {
            
        }
        //Tell Entitiy framework to include the Forms table... and all that fancy stuff
        public DbSet<FormModel> Forms { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}