using System.ComponentModel.DataAnnotations;

public class Ingresos
{

    [Key]
    public int IngresoId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Concepto { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(1, 25000, ErrorMessage = "El precio debe estar entre {1} y {2}")]
    public int Monto { get; set; }
}