﻿// <auto-generated />
using System;
using ComputerInventory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComputerInventory.Migrations
{
    [DbContext(typeof(MachineContext))]
    [Migration("20181106075500_ComputerInventory.Data.MachineContext")]
    partial class ComputerInventoryDataMachineContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35636")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComputerInventory.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MachineID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GeneralRole")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("InstalledRoles")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("MachineTypeId")
                        .HasColumnName("MachineTypeID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<int>("OperatingSysId")
                        .HasColumnName("OperatingSysID");

                    b.HasKey("MachineId");

                    b.HasIndex("MachineTypeId");

                    b.HasIndex("OperatingSysId");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("ComputerInventory.Models.MachineType", b =>
                {
                    b.Property<int>("MachineTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MachineTypeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("MachineTypeId");

                    b.ToTable("MachineType");
                });

            modelBuilder.Entity("ComputerInventory.Models.MachineWarranty", b =>
                {
                    b.Property<int>("MachineWarrantyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MachineWarrantyID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MachineId")
                        .HasColumnName("MachineID");

                    b.Property<string>("ServiceTag")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("WarrantyExpiration")
                        .HasColumnType("date");

                    b.Property<int>("WarrantyProviderId")
                        .HasColumnName("WarrantyProviderID");

                    b.HasKey("MachineWarrantyId");

                    b.HasIndex("WarrantyProviderId");

                    b.ToTable("MachineWarranty");
                });

            modelBuilder.Entity("ComputerInventory.Models.OperatingSys", b =>
                {
                    b.Property<int>("OperatingSysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OperatingSysID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .IsUnicode(false);

                    b.Property<bool>("StillSupported");

                    b.HasKey("OperatingSysId");

                    b.ToTable("OperatingSys");
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportLog", b =>
                {
                    b.Property<int>("SupportLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupportLogID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SupportLogEntry")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<DateTime>("SupportLogEntryDate")
                        .HasColumnType("date");

                    b.Property<string>("SupportLogUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("SupportTicketId")
                        .HasColumnName("SupportTicketID");

                    b.HasKey("SupportLogId");

                    b.HasIndex("SupportTicketId");

                    b.ToTable("SupportLog");
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportTicket", b =>
                {
                    b.Property<int>("SupportTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupportTicketID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateReported")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateResolved")
                        .HasColumnType("date");

                    b.Property<string>("IssueDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("IssueDetail")
                        .IsUnicode(false);

                    b.Property<int>("MachineId")
                        .HasColumnName("MachineID");

                    b.Property<string>("TicketOpenedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("SupportTicketId");

                    b.HasIndex("MachineId");

                    b.ToTable("SupportTicket");
                });

            modelBuilder.Entity("ComputerInventory.Models.WarrantyProvider", b =>
                {
                    b.Property<int>("WarrantyProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("WarrantyProviderID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("SupportExtension");

                    b.Property<string>("SupportNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("WarrantyProviderId");

                    b.ToTable("WarrantyProvider");
                });

            modelBuilder.Entity("ComputerInventory.Models.Machine", b =>
                {
                    b.HasOne("ComputerInventory.Models.MachineType", "MachineType")
                        .WithMany("Machine")
                        .HasForeignKey("MachineTypeId")
                        .HasConstraintName("FK_MachineType");

                    b.HasOne("ComputerInventory.Models.OperatingSys", "OperatingSys")
                        .WithMany("Machine")
                        .HasForeignKey("OperatingSysId")
                        .HasConstraintName("FK_OperatingSys");
                });

            modelBuilder.Entity("ComputerInventory.Models.MachineWarranty", b =>
                {
                    b.HasOne("ComputerInventory.Models.WarrantyProvider", "WarrantyProvider")
                        .WithMany("MachineWarranty")
                        .HasForeignKey("WarrantyProviderId")
                        .HasConstraintName("FK_WarrantyProvider");
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportLog", b =>
                {
                    b.HasOne("ComputerInventory.Models.SupportTicket", "SupportTicket")
                        .WithMany("SupportLog")
                        .HasForeignKey("SupportTicketId")
                        .HasConstraintName("FK_SupportTicket");
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportTicket", b =>
                {
                    b.HasOne("ComputerInventory.Models.Machine", "Machine")
                        .WithMany("SupportTicket")
                        .HasForeignKey("MachineId")
                        .HasConstraintName("FK_Machine");
                });
#pragma warning restore 612, 618
        }
    }
}
