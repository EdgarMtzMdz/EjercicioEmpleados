using System.ComponentModel.DataAnnotations;

namespace EmpleadosEj;

public class Empleados
{
    public Empleados()
    {
    }
    [Key]
    public Guid IdEmpleados { get; set; } 
    public string Nombre { get; set; }
    public string Puesto { get; set; }
    public int Edad { get; set; }
    public DateTime FechaEntrada { get; set; }
    public decimal Salario { get; set; }


}