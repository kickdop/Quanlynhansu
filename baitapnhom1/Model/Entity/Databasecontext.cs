namespace baitapnhom1.Model.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Databasecontext : DbContext
    {
        public Databasecontext()
            : base("name=Databasecontext")
        {
        }

        public virtual DbSet<chucvu> chucvus { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<phongban> phongbans { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhanvien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<Nhanvien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<Nhanvien>()
                .Property(e => e.CMT)
                .IsFixedLength();
        }
    }
}
