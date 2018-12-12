﻿// <auto-generated />
using System;
using MeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeetingPlanner.Migrations
{
    [DbContext(typeof(MeetingContext))]
    [Migration("20181212080105_ModelCleanUp")]
    partial class ModelCleanUp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("MeetingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Announcements");

                    b.Property<string>("Benediction")
                        .HasMaxLength(50);

                    b.Property<string>("Choirister")
                        .HasMaxLength(50);

                    b.Property<string>("Conducting")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Invocation")
                        .HasMaxLength(50);

                    b.Property<string>("Organist")
                        .HasMaxLength(50);

                    b.Property<string>("Presiding")
                        .HasMaxLength(50);

                    b.Property<string>("StakeBusiness");

                    b.Property<string>("WardBusiness");

                    b.HasKey("MeetingID");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("MeetingPlanner.Models.MusicalNumber", b =>
                {
                    b.Property<int>("MusicalNumberID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accompaniement")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("HymnNumber");

                    b.Property<int>("MeetingID");

                    b.Property<string>("Performers")
                        .HasMaxLength(50);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MusicalNumberID");

                    b.HasIndex("MeetingID");

                    b.ToTable("MusicalNumber");
                });

            modelBuilder.Entity("MeetingPlanner.Models.Talk", b =>
                {
                    b.Property<int>("TalkID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accepted");

                    b.Property<bool>("Assigned");

                    b.Property<int>("MeetingID");

                    b.Property<int>("SortOrder");

                    b.Property<string>("SpeakerFirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SpeakerLastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TalkID");

                    b.HasIndex("MeetingID");

                    b.ToTable("Talk");
                });

            modelBuilder.Entity("MeetingPlanner.Models.Testimonies", b =>
                {
                    b.Property<int>("TestimoniesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MeetingID");

                    b.HasKey("TestimoniesID");

                    b.HasIndex("MeetingID")
                        .IsUnique();

                    b.ToTable("Testimonies");
                });

            modelBuilder.Entity("MeetingPlanner.Models.MusicalNumber", b =>
                {
                    b.HasOne("MeetingPlanner.Models.Meeting", "Meeting")
                        .WithMany("MusicalNumbers")
                        .HasForeignKey("MeetingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeetingPlanner.Models.Talk", b =>
                {
                    b.HasOne("MeetingPlanner.Models.Meeting", "Meeting")
                        .WithMany("Talks")
                        .HasForeignKey("MeetingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeetingPlanner.Models.Testimonies", b =>
                {
                    b.HasOne("MeetingPlanner.Models.Meeting", "Meeting")
                        .WithOne("Testimonies")
                        .HasForeignKey("MeetingPlanner.Models.Testimonies", "MeetingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
