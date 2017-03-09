using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using IckyBot.Model;

namespace IckyBot.Migrations
{
    [DbContext(typeof(DiscordContext))]
    partial class DiscordContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("IckyBot.Model.DiscordUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastActivity");

                    b.Property<string>("LastKnownAlias");

                    b.Property<string>("LastKnownDiscordId");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IckyBot.Model.DiscordUserMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<DateTime>("Timestamp");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
        }
    }
}
