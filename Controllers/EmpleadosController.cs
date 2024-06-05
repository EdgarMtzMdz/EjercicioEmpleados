using Microsoft.AspNetCore.Mvc;

namespace EmpleadosEj;

public class EmpleadosController : Controller
{
    private readonly ApplicationDBContext _context;
    public EmpleadosController(ApplicationDBContext context)
    {
        _context = context;
    }

    public IActionResult ListaEmpleados()
    {
        
        //Empleados empleados= new Empleados();
        //empleados.IdEmpleados = new Guid();
        //empleados.Nombre = "Edgar Mtz";
        //empleados.Edad = 26;
        //empleados.Puesto = "Ayudante General";
        //empleados.FechaEntrada = DateTime.Now;
        //empleados.Salario = 1500;
        
        //this._context.Empleados.Add(empleados);
        //this._context.SaveChanges();
        
        List<EmpleadosModel> listaEmpleados = new List<EmpleadosModel>();
        listaEmpleados = _context.Empleados.Select(e => new EmpleadosModel()
        {
            IdEmpleados = e.IdEmpleados,
            Nombre = e.Nombre,
            Puesto = e.Puesto,
            Edad = e.Edad,
            FechaEntrada = e.FechaEntrada,
            Salario = e.Salario
        }).ToList();

        return View(listaEmpleados);
    }

    public IActionResult Update()
    {
        //Empleados empleadosUpdate = this._context.Empleados
        //.Where(c=>c.IdEmpleados == new Guid("0453E4F1-6B6A-40F4-0021-08DC8584B747"))
        //.First();
        //empleadosUpdate.Nombre = "Carlos";
        //this._context.Empleados.Update(empleadosUpdate);
        //this._context.SaveChanges();

        return Redirect("ListaEmpleados");
    }

    public IActionResult Delete()
    {
        return View();
    }

    public ActionResult Add()
    {
        return View();
    }
}