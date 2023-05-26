using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;
using System.Collections.Generic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Machine[] machines = _db.Machines.OrderBy(machines => machines.MachineName).ToArray();
      Engineer[] engineers = _db.Engineers.OrderBy(engineers => engineers.EngineerName).ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("machines", machines);
      model.Add("engineers", engineers);
      return View(model);
    }

  }
}