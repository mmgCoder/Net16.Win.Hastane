﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane.DAL.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HastaneEntities : DbContext
    {
        public HastaneEntities()
            : base("name=HastaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HastaGecmisi> HastaGecmisi { get; set; }
        public virtual DbSet<HastaHizmetHareketler> HastaHizmetHareketler { get; set; }
        public virtual DbSet<HastaKabul> HastaKabul { get; set; }
        public virtual DbSet<Hastalar> Hastalar { get; set; }
        public virtual DbSet<HastaSikayetleri> HastaSikayetleri { get; set; }
        public virtual DbSet<HastaTahlilSonuclari> HastaTahlilSonuclari { get; set; }
        public virtual DbSet<Hizmetler> Hizmetler { get; set; }
        public virtual DbSet<Klinikler> Klinikler { get; set; }
        public virtual DbSet<Kurumlar> Kurumlar { get; set; }
        public virtual DbSet<Odemeler> Odemeler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<Randevular> Randevular { get; set; }
        public virtual DbSet<ReceteDetay> ReceteDetay { get; set; }
        public virtual DbSet<Receteler> Receteler { get; set; }
        public virtual DbSet<SistemYoneticileri> SistemYoneticileri { get; set; }
        public virtual DbSet<TahlilIcerik> TahlilIcerik { get; set; }
        public virtual DbSet<Tahliller> Tahliller { get; set; }
        public virtual DbSet<Teshisler> Teshisler { get; set; }
        public virtual DbSet<Unvanlar> Unvanlar { get; set; }
        public virtual DbSet<ilceler> ilceler { get; set; }
        public virtual DbSet<iller> iller { get; set; }
    }
}
