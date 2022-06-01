using DataLayer.API;
using ServiceLayer.API;
using System.Collections.Generic;

namespace ServiceLayer
{
    internal abstract class Set_to_Map
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
   
}
