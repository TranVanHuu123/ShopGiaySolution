﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopGiaySolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate);

            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.ShipAddress).IsRequired().HasMaxLength(200);


            builder.Property(x => x.ShipName).IsRequired().HasMaxLength(200);


            builder.Property(x => x.ShipPhoneNumber).IsRequired().HasMaxLength(200);


            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);

        }
    }
}