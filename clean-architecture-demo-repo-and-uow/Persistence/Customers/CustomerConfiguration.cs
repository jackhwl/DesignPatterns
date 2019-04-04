﻿using System.Data.Entity.ModelConfiguration;
using CleanArchitecture.Domain.Customers;

namespace CleanArchitecture.Persistence.Customers
{
    public class CustomerConfiguration 
        : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
