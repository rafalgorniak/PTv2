using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.API
{
    public interface StateModelInterface
    {
        int id { get; set; }
        int book_id { get; set; }
        string available { get; set; }
    }
}
