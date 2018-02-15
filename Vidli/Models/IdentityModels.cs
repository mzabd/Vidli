using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.DataHandler;

namespace Vidli.Models
{
 

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public IDbSet<Customer> Customers { get; set;}
        //to include the movie in migration need to add DdSet<Movie> in indentity model
        public DbSet<Movie> Movies { get; set; }
        //to include membership type 
        public DbSet<MembershipType> MembershipTypes { get; set; }
        //include genre
        public DbSet<Genre> Genres { get; set; }

        //include Rental table
        public DbSet<Rental> Rentals { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}