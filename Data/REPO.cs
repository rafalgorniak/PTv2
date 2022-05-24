using DataLayer.API;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class REPO : RepoInterface
    {

        private string pathtoconnect = "Data Source=LAPTOP-7KS0JQL5;Initial Catalog=Library;Integrated Security=True";
        private CatalogDataContext catalogdatacontext;
        
        internal REPO()
        {
            try
            {
                catalogdatacontext = new CatalogDataContext(pathtoconnect);
                catalogdatacontext.books.Count();
            }
            catch(System.Data.SqlClient.SqlException)
            {
                throw ;
            }
        }

        public async Task<StateInteface> gStt(int id)
        {
            return await Task.Run<StateInteface>(() => catalogdatacontext.states.Where(s => s.id == id).FirstOrDefault());
        }
        public async Task<IEnumerable<StateInteface>> gBookStt(int id)
        {
            return await Task.Run<IEnumerable<StateInteface>>(() => catalogdatacontext.states.Where(s => s.book_id == id));
        }
        public async Task<IEnumerable<StateInteface>> gAllStates()
        {
            return await Task.Run<IEnumerable<StateInteface>>(() => catalogdatacontext.states);
        }
        public async Task adStt(int id, int book_id, string available)
        {
            state _state = new state
            {
                id = id,
                book_id = book_id,
                available = available
            };
            await Task.Run(() => catalogdatacontext.states.InsertOnSubmit(_state));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task UpStt(int id, int book_id, string available)
        {
            state _state = await Task.Run(() => catalogdatacontext.states.Where(s => s.id == id).FirstOrDefault());
            _state.book_id = book_id;
            _state.available = available;
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task dStt(int id)
        {
            await Task.Run(() => catalogdatacontext.states.DeleteOnSubmit(catalogdatacontext.states.Where(s => s.id == id).FirstOrDefault()));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task<UserInterface> gUsr(int id)
        {
            return await Task.Run<UserInterface>(() => catalogdatacontext.users.Where(u => u.id == id).FirstOrDefault());
        }
        public async Task<IEnumerable<UserInterface>> gAllUsrs()
        {
            return await Task.Run<IEnumerable<UserInterface>>(() => catalogdatacontext.users);
        }
        public async Task adUsr(int id, string name, string surname)
        {
            user _user = new user
            {
                id = id,
                name = name,
                surname = surname
            };
            await Task.Run(() => catalogdatacontext.users.InsertOnSubmit(_user));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        } 
        
        public async Task<BookInterface> gBook(int id)
        {
            return await Task.Run<BookInterface>(() => catalogdatacontext.books.Where(b => b.id == id).FirstOrDefault());
        }
        public async Task<IEnumerable<BookInterface>> gAllBooks()
        {
            return await Task.Run<IEnumerable<BookInterface>>(() => catalogdatacontext.books);
        }
        public async Task adBook(int id, string title, string author)
        {
            book _book = new book
            {
                id = id,
                title = title,
                author = author
            };
            await Task.Run(() => catalogdatacontext.books.InsertOnSubmit(_book));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task UpBook(int id, string title, string author)
        {
            book _book = await Task.Run(() => catalogdatacontext.books.Where(b => b.id == id).FirstOrDefault());
            _book.title = title;
            _book.author = author;
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task dBook(int id)
        {
            await Task.Run(() => catalogdatacontext.books.DeleteOnSubmit(catalogdatacontext.books.Where(b => b.id == id).FirstOrDefault()));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task UpUsr(int id, string name, string surname)
        {
            user _user = await Task.Run(() => catalogdatacontext.users.Where(u => u.id == id).FirstOrDefault());
            _user.name = name;
            _user.surname = surname;
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task dUsr(int id)
        {
            await Task.Run(() => catalogdatacontext.users.DeleteOnSubmit(catalogdatacontext.users.Where(u => u.id == id).FirstOrDefault()));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }

        public async Task<EventInterface> gEv(int id)
        {
            return await Task.Run<EventInterface>(() => catalogdatacontext.events.Where(e => e.id == id).FirstOrDefault());
        }
        public async Task<IEnumerable<EventInterface>> gAllSttEv(int id) 
        {
            return await Task.Run<IEnumerable<EventInterface>>(() => catalogdatacontext.events.Where(e => e.state_id == id));
        }
        public async Task<IEnumerable<EventInterface>> gAllUsrEv(int id)
        {
            return await Task.Run<IEnumerable<EventInterface>>(() => catalogdatacontext.events.Where(e => e.user_id == id));
        }
        public async Task<IEnumerable<EventInterface>> gAllEV()
        {
            return await Task.Run<IEnumerable<EventInterface>>(() => catalogdatacontext.events);
        }
        public async Task adEv(int id, int state_id, int user_id, string type)
        {
            @event _event = new @event
            {
                id = id,
                state_id = state_id,
                user_id = user_id,
                type = type
            };
            await Task.Run(() => catalogdatacontext.events.InsertOnSubmit(_event));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task UpEv(int id, int state_id, int user_id, string type)
        {
            @event _event = await Task.Run(() => catalogdatacontext.events.Where(e => e.id == id).FirstOrDefault());
            _event.state_id = state_id;
            _event.user_id = user_id;
            _event.type = type;
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
        public async Task delEv(int id)
        {
            await Task.Run(() => catalogdatacontext.events.DeleteOnSubmit(catalogdatacontext.events.Where(e => e.id == id).FirstOrDefault()));
            await Task.Run(() => catalogdatacontext.SubmitChanges());
        }
    }
}
