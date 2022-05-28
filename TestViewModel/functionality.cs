using PresentationLayer;
using Service.API;
using ServiceLayer.API;

namespace V_M_Test
{
    internal class Service_nr1 : ServiceInterface
    {
        private List<BookTesting> booksfortest = new();
        private List<StateTesting> statesfortest = new();
        private List<UserTesting> usersfortest = new();
        private List<EventTesting> eventsfortest = new();

        internal Service_nr1()
        {
            for(int i = 1; i < 10; i++)
            {
                var bk = new BookTesting()
                {
                    id = i,
                    title = "a",
                    author = "a"
                };
                booksfortest.Add(bk);
                var st = new StateTesting()
                {
                    id = i,
                    book_id = i,
                    available = "1"
                };
                statesfortest.Add(st);
                var usr = new UserTesting()
                {
                    id = i,
                    name = "a",
                    surname = "a"
                };
                usersfortest.Add(usr);
                var evnt = new EventTesting()
                {
                    id = i,
                    state_id = i,
                    user_id = i,
                    type = "Rental"
                };
                eventsfortest.Add(evnt);
            }
        }

        public Task adBook(int id, string title, string author)
        {
            var book = new BookTesting()
            {
                id = id,
                title = title,
                author = author
            };
            booksfortest.Add(book);
            return Task.CompletedTask;
        }

        public Task adEvent(int id, int state_id, int user_id, string type)
        {
            return Task.CompletedTask;
        }

        public Task adState(int id, int book_id, string available)
        {
            return Task.CompletedTask;
        }

        public Task adUser(int id, string name, string surname)
        {
            return Task.CompletedTask;
        }

        public Task delBook(int id)
        {
            return Task.CompletedTask;
        }

        public Task delEvent(int id)
        {
            return Task.CompletedTask;
        }

        public Task delState(int id)
        {
            return Task.CompletedTask;
        }

        public Task delUser(int id)
        {
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<BookModelInterface>> getAllBooks()
        {
            return booksfortest;
        }

        public async Task<IEnumerable<EventModelInterface>> getAllEvents()
        {
            return eventsfortest;
        }

        public async Task<IEnumerable<StateModelInterface>> getAllStates()
        {
            return statesfortest;
        }

        public async Task<IEnumerable<UserModelInterface>> getAllUsers()
        {
            return usersfortest;
        }

        public Task UpParticularBook(int id, string title, string author)
        {
            return Task.CompletedTask;
        }

        public Task UpParticularEvent(int id, int state_id, int user_id, string type)
        {
            return Task.CompletedTask;
        }

        public Task UpParticularState(int id, int book_id, string available)
        {
            return Task.CompletedTask;
        }

        public Task UpParticularUser(int id, string name, string surname)
        {
            return Task.CompletedTask;
        }
    }

    internal class Service_nr2 : ServiceInterface
    {
        private List<BookTesting> booksfortesting = new();
        private List<StateTesting> statesfortesting = new();
        private List<UserTesting> usersfortesting = new();
        private List<EventTesting> eventsfortesting = new();

        internal Service_nr2(){}

        internal List<BookTesting> Books { set { booksfortesting = value; } }
        internal List<StateTesting> States { set { statesfortesting = value; } }
        internal List<UserTesting> Users { set { usersfortesting = value; } }
        internal List <EventTesting> Events { set { eventsfortesting = value; } }

        public Task adBook(int id, string title, string author)
        {
            return Task.CompletedTask;
        }

        public Task adEvent(int id, int state_id, int user_id, string type)
        {
            return Task.CompletedTask;
        }

        public Task adState(int id, int book_id, string available)
        {
            return Task.CompletedTask;
        }

        public Task adUser(int id, string name, string surname)
        {
            return Task.CompletedTask;
        }

        public Task delBook(int id)
        {
            return Task.CompletedTask;
        }

        public Task delEvent(int id)
        {
            return Task.CompletedTask;
        }

        public Task delState(int id)
        {
            return Task.CompletedTask;
        }

        public Task delUser(int id)
        {
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<BookModelInterface>> getAllBooks()
        {
            return booksfortesting;
        }

        public async Task<IEnumerable<EventModelInterface>> getAllEvents()
        {
            return eventsfortesting;
        }

        public async Task<IEnumerable<StateModelInterface>> getAllStates()
        {
            return statesfortesting;
        }

        public async Task<IEnumerable<UserModelInterface>> getAllUsers()
        {
            return usersfortesting;
        }

        public Task UpParticularBook(int id, string title, string author)
        {
            return Task.CompletedTask;
        }

        public Task UpParticularEvent(int id, int state_id, int user_id, string type)
        {
            return Task.CompletedTask;
        }

        public Task UpParticularState(int id, int book_id, string available)
        {
            return Task.CompletedTask;
        }

        public Task UpParticularUser(int id, string name, string surname)
        {
            return Task.CompletedTask;
        }
    }
}
