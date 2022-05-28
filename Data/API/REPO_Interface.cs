using DataLayer;
using DataLayer.API;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.API
{
    public abstract class REPO_maker
    {
        public static RepoInterface CreateRepo()
        {
            return new REPO();
        }
    }

    public interface RepoInterface
    {
        Task<BookInterface> gBook(int id);
        Task<IEnumerable<BookInterface>> gAllBooks();
        Task adBook(int id, string title, string author);
        Task UpBook(int id, string title, string author);
        Task dBook(int id);
        Task<IEnumerable<StateInteface>> gBookStt(int id);



        Task<StateInteface> gStt(int id);
        Task<IEnumerable<StateInteface>> gAllStates();
        Task adStt(int id, int book_id, string available);
        Task UpStt(int id, int book_id, string available);
        Task dStt(int id);


        Task<UserInterface> gUsr(int id);
        Task<IEnumerable<UserInterface>> gAllUsrs();
        Task adUsr(int id, string name, string surname);
        Task UpUsr(int id, string name, string surname);
        Task dUsr(int id);


        Task<EventInterface> gEv(int id);
        Task<IEnumerable<EventInterface>> gAllSttEv(int id);
        Task<IEnumerable<EventInterface>> gAllUsrEv(int id);
        Task<IEnumerable<EventInterface>> gAllEV();
        Task adEv(int id, int state_id, int user_id, string type);
        Task UpEv(int id, int state_id, int user_id, string type);
        Task delEv(int id);
    }

}
