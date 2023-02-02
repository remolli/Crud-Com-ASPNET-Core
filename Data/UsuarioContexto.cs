using CrudComASPNETCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudComASPNETCore.Data
{
    public class UsuarioContexto : DbContext
    {
        public UsuarioContexto(DbContextOptions<UsuarioContexto> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasKey(k => k.Id);
            base.OnModelCreating(builder);
        }

    }
}
