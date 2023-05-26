using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "A machine's name cannot be left blank")]

    public string MachineName { get; set; }  
    public List<EngineerMachine> JoinEntities {get;}
  }
}