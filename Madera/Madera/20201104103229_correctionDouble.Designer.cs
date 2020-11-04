﻿// <auto-generated />
using System;
using Madera.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Madera.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201104103229_correctionDouble")]
    partial class correctionDouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Madera.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresseClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CpClient")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNaissanceClient")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("NomClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenomClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<string>("VilleClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Madera.Models.Commercial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailCommerce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("MdpCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenomCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Commercial");
                });

            modelBuilder.Entity("Madera.Models.Composant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaractComposant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("FamilleComposantID")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleComposant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NatureComposant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniteUsageComposant")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FamilleComposantID");

                    b.ToTable("Composant");
                });

            modelBuilder.Entity("Madera.Models.CoupePrincipale", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("LargeurCoupePrincipale")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("LibelleCoupePrincipale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LongueurCoupePrincipale")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ID");

                    b.ToTable("CoupePrincipale");
                });

            modelBuilder.Entity("Madera.Models.Couverture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("PrixHtCouverture")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("TypeCouverture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Couverture");
                });

            modelBuilder.Entity("Madera.Models.Devis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDebutDevis")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("EtatDevis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleDevis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MargeCommercialDevis")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("MargeEntrepriseDevis")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("PlanID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixTotalHtDevis")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("PrixTotalTtcDevis")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ID");

                    b.ToTable("Devis");
                });

            modelBuilder.Entity("Madera.Models.FamilleComposant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LIBELLE_FAMILLE_COMPOSANT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FamilleComposant");
                });

            modelBuilder.Entity("Madera.Models.Gamme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LibelleGamme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("QualiteHuisserieGamme")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("TypeGamme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeIsolantGamme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Gamme");
                });

            modelBuilder.Entity("Madera.Models.Modele", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LibelleModele")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Modele");
                });

            modelBuilder.Entity("Madera.Models.Module", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DdebutPointY")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("DebutPointX")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("FinPointX")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("FinPointY")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("GammeID")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleModule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixHtModule")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ID");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("Madera.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdressPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoupePrincipaleID")
                        .HasColumnType("int");

                    b.Property<int>("CouvertureID")
                        .HasColumnType("int");

                    b.Property<int>("CpPlan")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<int>("PlancherID")
                        .HasColumnType("int");

                    b.Property<string>("ReferencePlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VillePlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("libellePlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Madera.Models.Plancher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("PrixPlancher")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("TypePlancher")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Plancher");
                });

            modelBuilder.Entity("Madera.Models.Projet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("CommercialID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDebutProjet")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleNom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleProjet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleRemarque")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("CommercialID");

                    b.ToTable("Projet");
                });

            modelBuilder.Entity("Madera.Models.Slot", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LibelleSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("Madera.Models.Composant", b =>
                {
                    b.HasOne("Madera.Models.FamilleComposant", null)
                        .WithMany("Composants")
                        .HasForeignKey("FamilleComposantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Madera.Models.Projet", b =>
                {
                    b.HasOne("Madera.Models.Client", null)
                        .WithMany("Projets")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Madera.Models.Commercial", null)
                        .WithMany("Projets")
                        .HasForeignKey("CommercialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
