using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Bibliotecario> Bibliotecarios { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Titular> Titulares { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
