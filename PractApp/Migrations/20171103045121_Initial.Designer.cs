using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PractApp.Models;

namespace PractApp.Migrations
{
    [DbContext(typeof(PractAppContext))]
    [Migration("20171103045121_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PractApp.Clients.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clients");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Finish");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("Start");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });
        }
    }
}
