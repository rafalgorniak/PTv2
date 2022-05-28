using Service.API;
using ServiceLayer.API;

namespace V_M_Test
{
    internal class BookTesting : BookModelInterface
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
    }

    internal class StateTesting : StateModelInterface
    {
        public int id { get; set; }
        public int book_id { get; set; }
        public string available { get; set; }
    }

    internal class UserTesting : UserModelInterface
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }

    internal class EventTesting : EventModelInterface
    {
        public int id { get; set; }
        public int state_id { get; set; }
        public int user_id { get; set; }
        public string type { get; set; }
    }

    internal class FillingwithExamples
    {
        private List<BookTesting> BookstoTest = new()
        {
            new BookTesting()
            {
                id = 1,
                title = "a",
                author = "a"
            },
            new BookTesting()
            {
                id = 2,
                title = "b",
                author = "b"
            },
            new BookTesting()
            {
                id = 3,
                title = "c",
                author = "c"
            },
            new BookTesting()
            {
                id = 4,
                title = "d",
                author = "d"
            }
        };
        private List<StateTesting> StatestoTest = new()
        {
            new StateTesting()
            {
                id = 1,
                book_id = 1,
                available = "1"
            },
            new StateTesting()
            {
                id = 2,
                book_id = 1,
                available = "1"
            },
            new StateTesting()
            {
                id = 3,
                book_id = 2,
                available = "1"
            },
             new StateTesting()
            {
                id = 4,
                book_id = 2,
                available = "1"
            },
              new StateTesting()
            {
                id = 5,
                book_id = 3,
                available = "1"
            }
        };
        private List<UserTesting> UserstoTest = new()
        {
            new UserTesting()
            {
                id = 1,
                name = "A",
                surname = "A"
            },
            new UserTesting()
            {
                id = 2,
                name = "B",
                surname = "B"
            },
            new UserTesting()
            {
                id = 3,
                name = "C",
                surname = "C"
            }

        };
        private List<EventTesting> EventstoTest = new()
        {
            new EventTesting()
            {
                id = 1,
                state_id = 1,
                user_id = 1,
                type = "Rental",
            },
            new EventTesting()
            {
                id = 2,
                state_id = 1,
                user_id = 1,
                type = "Return",
            },
            new EventTesting()
            {
                id = 3,
                state_id = 2,
                user_id = 1,
                type = "Rental",
            },
            new EventTesting()
            {
                id = 4,
                state_id = 3,
                user_id = 1,
                type = "Rental",
            }
        };
        internal List<BookTesting> Books => BookstoTest;
        internal List<StateTesting> States => StatestoTest;
        internal List<UserTesting> Users => UserstoTest;
        internal List<EventTesting> Events => EventstoTest;
    }
}
