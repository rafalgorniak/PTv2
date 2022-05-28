using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface EventModelInterface
    {
        int id { get; set; }
        int state_id { get; set; }
        int user_id { get; set; }
        string type { get; set; }
    }
}
