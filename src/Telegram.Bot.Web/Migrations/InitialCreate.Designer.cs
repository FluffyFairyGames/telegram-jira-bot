﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using Telegram.Bot.Web;

namespace Telegram.Bot.Web.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20170917143944_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Telegram.Bot.Jira.JiraEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ChatId");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("JiraEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
