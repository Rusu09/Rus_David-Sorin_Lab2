using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rus_David_Sorin_Lab2.Models;

namespace Rus_David_Sorin_Lab2.Data
{
    public class Rus_David_Sorin_Lab2Context : DbContext
    {
        public Rus_David_Sorin_Lab2Context (DbContextOptions<Rus_David_Sorin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rus_David_Sorin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Rus_David_Sorin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Rus_David_Sorin_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Rus_David_Sorin_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Rus_David_Sorin_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Rus_David_Sorin_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
