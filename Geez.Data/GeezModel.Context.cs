﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geez.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GeezEntities : DbContext
    {
        public GeezEntities()
            : base("name=GeezEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Address { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Checkin> Checkin { get; set; }
        public DbSet<Fault> Fault { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Response> Response { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceProvider> ServiceProvider { get; set; }
        public DbSet<ServiceProviderPicture> ServiceProviderPicture { get; set; }
        public DbSet<ServiceProviderRating> ServiceProviderRating { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<TransactionLog> TransactionLog { get; set; }
        public DbSet<Recommendation> Recommendation { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}
