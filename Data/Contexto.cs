﻿using Microsoft.EntityFrameworkCore;
using ProyectoFinalPA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<TipoCliente> TipoClientes { get; set; }
        public DbSet<Quejas> Quejas { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<PedidosDetalle> PedidosDetalles { get; set; }
        public DbSet<QuejasDetalle> QuejasDetalles { get; set; }

        public DbSet <CategoriaArticulos> CategoriaArticulo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=tcp:proyectofinalpa220200331111503dbserver.database.windows.net,1433;Initial Catalog=ProyectoFinalPA220200331111503_db;Persist Security Info=False;User ID=ErickGutierrez;Password=!MiContrasena123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }
    }
}
