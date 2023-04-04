using Curso.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Infra.Context;

public class AppMonitoramentoContext : DbContext
{
    public AppMonitoramentoContext(DbContextOptions<AppMonitoramentoContext> options) : base(options)
    {
    }

    public DbSet<EstacionamentoModel> Estacionamento { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppMonitoramentoContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
