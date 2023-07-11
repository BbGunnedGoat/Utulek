using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Utulek.Models;
//Input database first Scaffold-dbcontext 'data source=185.186.163.38;initial catalog=intranet;integrated security=false;TrustServerCertificate=True;User ID=sa;Password=Hacoba_157;Persist Security Info=True;' Microsoft.EntityFrameworkCore.SQLServer -OutputDir Models -table Kocka

public partial class Kocka
{
    public int Id { get; set; }
    [DisplayName("Jméno")]
    [StringLength(20, MinimumLength = 2)]
    [Required]
    public string Jmeno { get; set; } = null!;
    [DisplayName("Pohlaví")]
    public PohlaviClass.Pohlavi Pohlavi { get; set; }
    [StringLength(20, MinimumLength = 2)]
    [Required]
    public string Plemeno { get; set; } = null!;
    [DisplayName("Věk")]
    [Range(0, 20, ErrorMessage = "Věk zvířete musí být mezi 0 a 20")]
    public int Vek { get; set; }

    public int Hmotnost { get; set; }
    [DisplayName("Město nálezu")]
    public string? MestoNalezu { get; set; }

    public string? Foto { get; set; }
    [DisplayName("Volný")]
    public bool Volny { get; set; }
}
