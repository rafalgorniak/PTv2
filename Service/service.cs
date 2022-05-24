using DataLayer.API;
using ServiceLayer.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class Service : ServiceInterface
    {
        private RepoInterface REPO;

        internal Service(RepoInterface repo)
        {
            REPO = repo;
        }




        public async Task<IEnumerable<EventModelInterface>> getAllEvents()
        {
            return Mapper.MapEvents(await Task.Run(() => REPO.gAllEV()));
        }
        public async Task adEvent(int id, int state_id, int user_id, string type)
        {
            if (await Task.Run(() => REPO.gEv(id)) != null)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            if (await Task.Run(() => REPO.gStt(state_id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            if (await Task.Run(() => REPO.gUsr(user_id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.adEv(id, state_id, user_id, type));
        }
        public async Task UpParticularEvent(int id, int state_id, int user_id, string type)
        {
            if (await Task.Run(() => REPO.gEv(id)) != null)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            if (await Task.Run(() => REPO.gStt(state_id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            if (await Task.Run(() => REPO.gUsr(user_id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.UpEv(id, state_id, user_id, type));
        }
        public async Task delEvent(int id)
        {
            if (await Task.Run(() => REPO.gEv(id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.delEv(id));
        }
        public async Task<IEnumerable<BookModelInterface>> getAllBooks()
        {
            return Mapper.BooksMapping(await Task.Run(() => REPO.gAllBooks()));
        }





        public async Task adBook(int id, string title, string author)
        {
            if ((await Task.Run(() => REPO.gBook(id))) != null)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            await Task.Run(() => REPO.adBook(id, title, author));
        }
        public async Task UpParticularBook(int id, string title, string author)
        {
            if (await Task.Run(() => REPO.gBook(id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.UpBook(id, title, author));
        }
        public async Task delBook(int id)
        {
            if (await Task.Run(() => REPO.gBook(id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            if ((await Task.Run(() => REPO.gBookStt(id))).Count() > 0)
            {
                throw new ArgumentException("This entity has state already!!!");
            }
            await Task.Run(() => REPO.dBook(id));
        }




        public async Task<IEnumerable<UserModelInterface>> getAllUsers()
        {
            return Mapper.USersMapping(await Task.Run(() => REPO.gAllUsrs()));
        }
        public async Task adUser(int id, string name, string surname)
        {
            if (await Task.Run(() => REPO.gUsr(id)) != null)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            await Task.Run(() => REPO.adUsr(id, name, surname));
        }
        public async Task UpParticularUser(int id, string name, string surname)
        {
            if (await Task.Run(() => REPO.gUsr(id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.UpUsr(id, name, surname));
        }
        public async Task delUser(int id)
        {
            if (await Task.Run(() => REPO.gUsr(id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            if ((await Task.Run(() => REPO.gAllUsrEv(id))).Count() > 0)
            {
                throw new ArgumentException("This User has Events already!!!");
            }
            await Task.Run(() => REPO.dUsr(id));
        }




        public async Task<IEnumerable<StateModelInterface>> getAllStates()
        {
            return Mapper.StatesMapping(await Task.Run(() => REPO.gAllStates()));
        }
        public async Task adState(int id, int book_id, string available)
        {
            if (await Task.Run(() => REPO.gStt(id)) != null)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            if (await Task.Run(() => REPO.gBook(book_id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.adStt(id, book_id, available));
        }
        public async Task UpParticularState(int id, int book_id, string available)
        {
            if (await Task.Run(() => REPO.gStt(id)) == null)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            if (await Task.Run(() => REPO.gBook(book_id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            await Task.Run(() => REPO.UpStt(id, book_id, available));
        }
        public async Task delState(int id)
        {
            if (await Task.Run(() => REPO.gStt(id)) == null)
            {
                throw new ArgumentException("No such entity as with this id!!!");
            }
            if ((await Task.Run(() => REPO.gAllSttEv(id))).Count() > 0)
            {
                throw new ArgumentException("Such entity already exists!!!");
            }
            await Task.Run(() => REPO.dStt(id));
        }

    }
}
