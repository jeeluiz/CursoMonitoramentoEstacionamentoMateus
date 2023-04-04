using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Domain.Models;

public class EstacionamentoModel
{
    public EstacionamentoModel()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public required int Capacidade { get; set; }
    public required string Estado { get; set; }
    public required string Cidade { get; set; }
    public required string Bairro { get; set; }
    public required string Lougradouro { get; set; }
    public required string Numero { get; set; }
    public string? Complemento { get; set; }
}
