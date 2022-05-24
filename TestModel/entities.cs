using DataLayer.API;

namespace ModelTesting
{
    internal class BookTesting : BookInterface
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
    }

    internal class StateTesting : StateInteface
    {
        public int id { get; set; }
        public int book_id { get; set; }
        public string available { get; set; }
    }

    internal class UserTesting : UserInterface
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }

    internal class EventTesting : EventInterface
    {
        public int id { get; set; }
        public int state_id { get; set; }
        public int user_id { get; set; }
        public string type { get; set; }
    }
}
