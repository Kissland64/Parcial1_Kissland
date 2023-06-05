using System.ComponentModel.DataAnnotations;

public class Registro{
    public int IngresoId{get; set;}

    [Required(ErrorMessage = "Este campo es necesario")]
    public int Fecha{get; set;}

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Concepto{get; set;} = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(1,5000)]
    public int Monto{get; set;}
}