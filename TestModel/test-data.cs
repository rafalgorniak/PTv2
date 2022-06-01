using DataLayer.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModelTesting
{
    [TestClass]
    public class DataTesting
    {
        [TestMethod]
        public void ConnectionWithDatabaseTest()
        {
            RepoInterface repo = REPO_maker.CreateRepo();
            Thread.Sleep(1000);
            Assert.IsTrue(repo.gAllBooks().Result.Count() > 0);
        }
    }
}