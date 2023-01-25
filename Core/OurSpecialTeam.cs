using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public class OurSpecialTeam
{
    public int Id { get; set; }
  
    public string Photo { get; set; } = null!;
    
    public string Name { get; set; } = null!;
   
    public string Position { get; set; } = null!;

}
