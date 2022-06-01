using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.API
{
    public interface BookModelInterface
    {
        int id { get; set; }
        string title { get; set; }
        string author { get; set; }
    }
}
