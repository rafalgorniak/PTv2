using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceLayer.API;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class ModelBook : BookModelInterface
    {
        internal ModelBook(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
        }
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
    }

    internal class ModelState : StateModelInterface
    {
        internal ModelState(int id, int book_id, string available)
        {
            this.id = id;
            this.book_id = book_id;
            this.available = available;
        }
        public int id { get; set; }
        public int book_id { get; set; }
        public string available { get; set; }
    }

    internal class ModelUser : UserModelInterface
    {
        internal ModelUser(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }

    internal class ModelEvent : EventModelInterface
    {
        internal ModelEvent(int id, int state_id, int user_id, string type)
        {
            this.id = id;
            this.state_id = state_id;
            this.user_id = user_id;
            this.type = type;
        }
        public int id { get; set; }
        public int state_id { get; set; }
        public int user_id { get; set; }
        public string type { get; set; }
    }
}
