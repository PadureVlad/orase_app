using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problema01.Models
{
    public class OraseContext : DbContext
    {
        public DbSet<Tara> Tari { get; set; }
        public DbSet<Oras> Orase { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Orase.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tara>().HasKey(c => c.CodTara);

            modelBuilder.Entity<Oras>().HasKey(c => c.CodOras);

            modelBuilder.Entity<Oras>().HasOne(c => c.Tara).WithMany().HasForeignKey(c => c.CodTara);
        }
        public ObservableCollection<Tara> GetTari()
        {
            var tari = Tari.ToList();
            var tariObservable = new ObservableCollection<Tara>(tari);
            return tariObservable;
        }
        public ObservableCollection<Oras> GetOrase()
        {
            var orase = Orase.ToList();
            var oraseObservable = new ObservableCollection<Oras>(orase);
            return oraseObservable;
        }
        public void AdaugaTara(Tara tara)
        {
            Tari.Add(tara);
            SaveChanges();
        }
        public void ActualizeazaTara(Tara tara)
        {
            base.Entry(tara).State = EntityState.Modified;
            SaveChanges();
        }
        public void StergeTara(Tara tara)
        {
            Tari.Remove(tara);
            SaveChanges();
        }
        public void AdaugaOras(Oras oras)
        {
            Orase.Add(oras);
            SaveChanges();
        }

        internal void ActualizeazaOras(Oras oras)
        {
            base.Entry(oras).State = EntityState.Modified;
            SaveChanges();
        }

        internal void StergeOras(Oras oras)
        {
            Orase.Remove(oras);
            SaveChanges();
        }
        public List<Oras> GetListaOraseLocuitori()
        {
            using (var context = new OraseContext())
            {
                return context.Orase.Include(c => c.Tara).Where(c => c.CodOras != 0 && c.NrLocuitori > 1000000).ToList();
            }
        }
        public List<Tara> GetListaTariContinent(string continent)
        {
            using (var context = new OraseContext())
            {
                return context.Tari.Where(c => c.CodTara != 0 && c.Continent.ToLower() == continent.ToLower()).ToList();
            }
        }
        public List<OrasTara> GetListaTaraCuOrase()
        {
            var context = new OraseContext();

            var toateTarile = context.Tari.Select(tara => tara.Denumire).ToList();
            var tariCuOrase = context.Orase.Where(oras => oras.Tara != null).Select(oras => oras.Tara.Denumire).Distinct().ToList();

            var rezultat = toateTarile.Select(tara =>
                new OrasTara
                {
                    Denumire = tara,
                    NrOrase = tariCuOrase.Contains(tara) ? context.Orase.Count(oras => oras.Tara.Denumire == tara) : 0
                })
                .OrderByDescending(ot => ot.NrOrase)
                .ThenBy(ot => ot.Denumire);

            return rezultat.ToList();
        }

    }
}
