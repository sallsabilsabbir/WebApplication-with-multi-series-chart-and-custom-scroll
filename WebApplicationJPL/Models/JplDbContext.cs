using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationJPL.Models;

public partial class JplDbContext : DbContext
{
    public JplDbContext()
    {
    }

    public JplDbContext(DbContextOptions<JplDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AmbentTemperature> AmbentTemperatures { get; set; }

    public virtual DbSet<CumulativePoaAvg> CumulativePoaAvgs { get; set; }

    public virtual DbSet<CumulatuivePr> CumulatuivePrs { get; set; }

    public virtual DbSet<InverterAcPower> InverterAcPowers { get; set; }

    public virtual DbSet<InverterDcPower> InverterDcPowers { get; set; }

    public virtual DbSet<InverterEfficiency> InverterEfficiencies { get; set; }

    public virtual DbSet<InverterTotalAcPower> InverterTotalAcPowers { get; set; }

    public virtual DbSet<InverterTotalDcPower> InverterTotalDcPowers { get; set; }

    public virtual DbSet<LifetimeGeneration> LifetimeGenerations { get; set; }

    public virtual DbSet<LivePower> LivePowers { get; set; }

    public virtual DbSet<MaxAcPower> MaxAcPowers { get; set; }

    public virtual DbSet<MaxDcPower> MaxDcPowers { get; set; }

    public virtual DbSet<ModuleTemperature> ModuleTemperatures { get; set; }

    public virtual DbSet<PlantDatum> PlantData { get; set; }

    public virtual DbSet<PoaAvg> PoaAvgs { get; set; }

    public virtual DbSet<Pr> Prs { get; set; }

    public virtual DbSet<SavingsAndProfit> SavingsAndProfits { get; set; }

    public virtual DbSet<ShedWiseGenerationGraph> ShedWiseGenerationGraphs { get; set; }

    public virtual DbSet<ShedWiseTodaysEnergy> ShedWiseTodaysEnergies { get; set; }

    public virtual DbSet<ShedWiseYesterdaysEnergy> ShedWiseYesterdaysEnergies { get; set; }

    public virtual DbSet<TodayPlantTotalEnergy> TodayPlantTotalEnergies { get; set; }

    public virtual DbSet<TodaysDatum> TodaysData { get; set; }

    public virtual DbSet<TodaysGeneration> TodaysGenerations { get; set; }

    public virtual DbSet<TotalAcPower> TotalAcPowers { get; set; }

    public virtual DbSet<TotalDcPower> TotalDcPowers { get; set; }

    public virtual DbSet<TotalGeneration> TotalGenerations { get; set; }

    public virtual DbSet<TotalGenerationForAllInverrter> TotalGenerationForAllInverrters { get; set; }

    public virtual DbSet<TotalMaxAcPower> TotalMaxAcPowers { get; set; }

    public virtual DbSet<TotalMaxDcPower> TotalMaxDcPowers { get; set; }

    public virtual DbSet<TotalPr> TotalPrs { get; set; }

    public virtual DbSet<YesterdayPlantTotalEnergy> YesterdayPlantTotalEnergies { get; set; }

    public virtual DbSet<YesterdaysDatum> YesterdaysData { get; set; }

    public virtual DbSet<YesterdaysGeneration> YesterdaysGenerations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AmbentTemperature>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ambent_Temperature");

            entity.Property(e => e.AmbentTemperature1).HasColumnName("Ambent_Temperature");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<CumulativePoaAvg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cumulative_POA_AVG");

            entity.Property(e => e.CumulativePoaAvg1).HasColumnName("Cumulative_POA_AVG");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<CumulatuivePr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cumulatuive_PR");

            entity.Property(e => e.CumulatuivePr1).HasColumnName("Cumulatuive_PR");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<InverterAcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inverter_AC_Power");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<InverterDcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inverter_DC_Power");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<InverterEfficiency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inverter_Efficiency");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<InverterTotalAcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inverter_Total_AC_Power");

            entity.Property(e => e.InverterTotalAcPower1).HasColumnName("InverterTotal_AC_Power");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<InverterTotalDcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inverter_Total_DC_Power");

            entity.Property(e => e.InverterTotalDcPower1).HasColumnName("InverterTotal_DC_Power");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<LifetimeGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Lifetime_Generation");

            entity.Property(e => e.LifetimeGeneration1).HasColumnName("Lifetime_Generation");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<LivePower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LivePower");

            entity.Property(e => e.LivePower1).HasColumnName("Live_Power");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<MaxAcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Max_AC_Power");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<MaxDcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Max_DC_Power");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<ModuleTemperature>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Module_Temperature");

            entity.Property(e => e.ModuleTemperature1).HasColumnName("Module_Temperature");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<PlantDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Plant_Data");

            entity.Property(e => e.PlantNetGeneration).HasColumnName("Plant_Net_Generation");
            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TodayExport).HasColumnName("Today_Export");
            entity.Property(e => e.TodayImport).HasColumnName("Today_Import");
            entity.Property(e => e.TodayNetGeneration).HasColumnName("Today_Net_Generation");
        });

        modelBuilder.Entity<PoaAvg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Poa_Avg");

            entity.Property(e => e.PoaAvg1).HasColumnName("Poa_Avg");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<Pr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PR");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<SavingsAndProfit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Savings_and_Profit");

            entity.Property(e => e.Co2Savings).HasColumnName("CO2_Savings");
            entity.Property(e => e.GrossProfit).HasColumnName("Gross_Profit");
            entity.Property(e => e.RobintexSavings).HasColumnName("Robintex_Savings");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShedWiseGenerationGraph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shed_Wise_Generation_Graph");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShedWiseTodaysEnergy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShedWise_TodaysEnergy");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShedWiseYesterdaysEnergy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShedWise_YesterdaysEnergy");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<TodayPlantTotalEnergy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TodayPlant_Total_Energy");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TptEnergy).HasColumnName("TPT_Energy");
        });

        modelBuilder.Entity<TodaysDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Todays_Data");

            entity.Property(e => e.AcMaxPower).HasColumnName("AC_Max_Power");
            entity.Property(e => e.DcMaxPower).HasColumnName("DC_Max_Power");
            entity.Property(e => e.Pr).HasColumnName("PR");
            entity.Property(e => e.SpecificEnergy).HasColumnName("Specific_Energy");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<TodaysGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Todays_Generation");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TodaysGeneration1).HasColumnName("Todays_Generation");
        });

        modelBuilder.Entity<TotalAcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Total_Ac_Power");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TotalAcPower1).HasColumnName("Total_Ac_Power");
        });

        modelBuilder.Entity<TotalDcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Total_Dc_Power");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TotalDcPower1).HasColumnName("Total_Dc_Power");
        });

        modelBuilder.Entity<TotalGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Total_Generation");

            entity.Property(e => e.Shed1).HasColumnName("Shed_1");
            entity.Property(e => e.Shed10).HasColumnName("Shed_10");
            entity.Property(e => e.Shed11).HasColumnName("Shed_11");
            entity.Property(e => e.Shed12).HasColumnName("Shed_12");
            entity.Property(e => e.Shed2).HasColumnName("Shed_2");
            entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");
            entity.Property(e => e.Shed5).HasColumnName("Shed_5");
            entity.Property(e => e.Shed6).HasColumnName("Shed_6");
            entity.Property(e => e.Shed7).HasColumnName("Shed_7");
            entity.Property(e => e.Shed8).HasColumnName("Shed_8");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<TotalGenerationForAllInverrter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TotalGeneration_ForAll_Inverrters");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TotalGenerationForAllInverrters).HasColumnName("TotalGeneration_ForAll_Inverrters");
        });

        modelBuilder.Entity<TotalMaxAcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Total_Max_AC_Power");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TotalMaxAcPower1).HasColumnName("Total_Max_AC_Power");
        });

        modelBuilder.Entity<TotalMaxDcPower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Total_Max_DC_Power");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TotalMaxDcPower1).HasColumnName("Total_Max_DC_Power");
        });

        modelBuilder.Entity<TotalPr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Total_PR");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.TotalPr1).HasColumnName("Total_PR");
        });

        modelBuilder.Entity<YesterdayPlantTotalEnergy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("YesterdayPlant_TotalEnergy");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.YptEnergy).HasColumnName("YPT_Energy");
        });

        modelBuilder.Entity<YesterdaysDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Yesterdays_Data");

            entity.Property(e => e.AcMaxPower).HasColumnName("AC_Max_Power");
            entity.Property(e => e.DcMaxPower).HasColumnName("DC_Max_Power");
            entity.Property(e => e.Pr).HasColumnName("PR");
            entity.Property(e => e.SpecificEnergy).HasColumnName("Specific_Energy");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<YesterdaysGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Yesterdays_Generation");

            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.YesterdaysGeneration1).HasColumnName("Yesterdays_Generation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
