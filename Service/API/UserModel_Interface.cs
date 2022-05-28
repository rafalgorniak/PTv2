using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.API
{
    public interface UserModelInterface
    {
        int id { get; set; }
        string name { get; set; }
        string surname { get; set; }
    }
}
