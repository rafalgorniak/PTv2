using DataLayer.API;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.API
{

    public abstract class Service_maker
    {
        public static ServiceInterface CreateService(RepoInterface repository = default)
        {
            return new Service(repository ?? REPO_maker.CreateRepo());
        }
    }
    
    public interface ServiceInterface
    {
        Task adBook(int id, string title, string author);
        Task delBook(int id);
        Task<IEnumerable<BookModelInterface>> getAllBooks();
        Task UpParticularBook(int id, string title, string author);



        Task adEvent(int id, int state_id, int user_id, string type);
        Task delEvent(int id);
        Task<IEnumerable<EventModelInterface>> getAllEvents();
        Task UpParticularEvent(int id, int state_id, int user_id, string type);



        Task adState(int id, int book_id, string available);
        Task delState(int id);
        Task<IEnumerable<StateModelInterface>> getAllStates();
        Task UpParticularState(int id, int book_id, string available);



        Task adUser(int id, string name, string surname);
        Task delUser(int id);
        Task<IEnumerable<UserModelInterface>> getAllUsers();
        Task UpParticularUser(int id, string name, string surname);

    }

    
}
