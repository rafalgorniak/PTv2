using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.API
{
    public interface UserInterface
    {
        int id { get; set; }
        string name { get; set; }
        string surname { get; set; }
    }
}
