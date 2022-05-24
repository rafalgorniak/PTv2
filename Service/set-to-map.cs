using DataLayer.API;
using ServiceLayer.API;
using System.Collections.Generic;

namespace ServiceLayer
{
    internal abstract class Mapper
    {
        internal static IEnumerable<EventModelInterface> MapEvents(IEnumerable<EventInterface> events)
        {
            List<EventModelInterface> ListofEvents = new();
            foreach (var @event in events)
            {
                ListofEvents.Add(new ModelEvent(@event.id, @event.state_id, @event.user_id, @event.type));
            }
            return ListofEvents;
        }

        internal static IEnumerable<UserModelInterface> USersMapping(IEnumerable<UserInterface> users)
        {
            List<UserModelInterface> ListofUsers = new();
            foreach (var user in users)
            {
                ListofUsers.Add(new ModelUser(user.id, user.name, user.surname));
            }
            return ListofUsers;
        }

        internal static IEnumerable<StateModelInterface> StatesMapping(IEnumerable<StateInteface> states)
        {
            List<StateModelInterface> ListofStates = new();
            foreach (var state in states)
            {
                ListofStates.Add(new ModelState(state.id, state.book_id, state.available));
            }
            return ListofStates;
        }
        
        internal static IEnumerable<BookModelInterface> BooksMapping(IEnumerable<BookInterface> books)
        {
            List<BookModelInterface> ListofBooks = new();
            foreach(var book in books)
            {
                ListofBooks.Add(new ModelBook(book.id, book.title, book.author));
            }
            return ListofBooks;
        }

    }

    #region models
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
    #endregion modelClasses
}
