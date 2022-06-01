using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using DataLayer.API;
using ServiceLayer.API;

namespace ModelTesting
{
    [TestClass]
    public class ServiceTesting
    {
        private RepoInterface repo = Substitute.For<RepoInterface>();

        [TestMethod]
        public void BooksTesting()
        {
            ServiceInterface ser = Service_maker.CreateService(repo);
            repo.gAllBooks().Returns(new List<BookTesting>());
            IEnumerable<BookModelInterface> books = ser.getAllBooks().Result;
            Assert.IsNotNull(new List<int>());
            ser.adBook(1, "a", "a");
            repo.gBook(1).Returns(new BookTesting());
            ser.UpParticularBook(1, "b", "b");
            ser.delBook(1);
            ser.adBook(2, "c", "c");
            repo.gBook(2).Returns(new BookTesting());
            ser.UpParticularBook(2, "d", "d");
            ser.delBook(2);
        }
        [TestMethod]
        public void StatesTesting()
        {
            ServiceInterface ser = Service_maker.CreateService(repo);
            repo.gAllStates().Returns(new List<StateTesting>());
            IEnumerable<StateModelInterface> st = ser.getAllStates().Result;
            Assert.IsNotNull(st);
            repo.gBook(1).Returns(new BookTesting());
            repo.gBook(2).Returns(new BookTesting());
            ser.adState(3, 3, "3");
            repo.gStt(3).Returns(new StateTesting());
            ser.UpParticularState(3, 2, "3");
            ser.delState(3);
        }

        [TestMethod]
        public void UsersTesting()
        {
            ServiceInterface ser = Service_maker.CreateService(repo);
            repo.gAllUsrs().Returns(new List<UserTesting>());
            IEnumerable<UserModelInterface> usr = ser.getAllUsers().Result;
            Assert.IsNotNull(usr);
            ser.adUser(2, "b", "b");
            repo.gUsr(2).Returns(new UserTesting());
            ser.UpParticularUser(2, "d", "d");
            ser.delUser(2);
        }

        [TestMethod]
        public void EventsTesting()
        {
            ServiceInterface ser = Service_maker.CreateService(repo);
            repo.gAllEV().Returns(new List<EventTesting>());
            IEnumerable<EventModelInterface> ev = ser.getAllEvents().Result;
            Assert.IsNotNull(ev);
            repo.gStt(2).Returns(new StateTesting());
            repo.gUsr(2).Returns(new UserTesting());
            ser.adEvent(2, 2, 2, "Return");
            repo.gEv(2).Returns(new EventTesting());
            ser.UpParticularEvent(2, 2, 2, "Rental");
            ser.delEvent(2);
        }
    }
}
