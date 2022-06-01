using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.API
{
    public interface BookInterface
    {
        int id { get; set; }
        string title { get; set; }
        string author { get; set; }
    }
}
