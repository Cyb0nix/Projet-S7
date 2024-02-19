using Microsoft.EntityFrameworkCore;

namespace PizzaAPI.utils;
using System;
using Npgsql;

public class dbContext : DbContext
{
    public dbContext(DbContextOptions<dbContext> options)
        :base(options)
    { 
        

    } 
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Clerk> Clerks { get; set; }
    public virtual DbSet<DeliveryMan> Deliverers { get; set; }
}