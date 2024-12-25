using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ticketplace.Models;

namespace ticketplace.Data
{
    public class ApplicationDbContext : DbContext
    {
    public DbSet<UtilisateurModel> Utilisateurs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
    }
}