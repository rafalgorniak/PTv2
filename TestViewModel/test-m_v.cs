using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentationLayer.viewmodel;
using PresentationLayer.model;

namespace V_M_Test
{
    [TestClass]
    public class V_M_Testing
    {
        [TestMethod]
        public void Test_1()
        {
            Service_nr1 srv = new();
            PresenationModel mdl = new(srv);
            ViewModel vm = new(mdl);
            Assert.AreEqual(vm.ModelBooks.Count(), 9);
            Assert.AreEqual(vm.ModelStates.Count(), 9);
            Assert.AreEqual(vm.ModelUsers.Count(), 9);
            Assert.AreEqual(vm.ModelEvents.Count(), 9);
        }

        [TestMethod]
        public void Test_2()
        {
            FillingwithExamples fill = new();
            Service_nr2 service = new()
            {
                Books = fill.Books,
                States = fill.States,
                Users = fill.Users,
                Events = fill.Events
            };
            Assert.AreEqual(service.getAllEvents().Result.Count(), 4);
            PresenationModel mdl = new(service);
            ViewModel vm = new(mdl);
            Assert.AreEqual(vm.ModelBooks.Count(), 4);
            Assert.AreEqual(vm.ModelStates.Count(), 5);
            Assert.AreEqual(vm.ModelUsers.Count(), 3);
            Assert.AreEqual(vm.ModelEvents.Count(), 4);
        }

        [TestMethod]
        public void Test_3()
        {
            Service_nr1 srv = new();
            PresenationModel mdl = new(srv);
            ViewModel vm = new(mdl);

            Assert.IsNull(vm.SelectedBook);
            Assert.IsNull(vm.SelectedState);
            Assert.IsNull(vm.SelectedUser);
            Assert.IsNull(vm.SelectedEvent);
        }

        [TestMethod]
        public void Test_4()
        {
            Service_nr1 srv = new();
            PresenationModel mdl = new(srv);
            ViewModel vm = new(mdl);

            Task.Run(() => vm.AddBook());
            Task.Run(() => vm.UpdateBook());
            Task.Run(() => vm.DeleteBook());
        }

        [TestMethod]
        public void Test_5()
        {
            Service_nr1 srv = new();
            PresenationModel mdl = new(srv);
            ViewModel vm = new(mdl);
            Assert.IsNotNull(vm.AddBookCommandProperty);
            Assert.IsNotNull(vm.UpdateBookCommandProperty);
            Assert.IsNotNull(vm.DeleteBookCommandProperty);

            Assert.IsNotNull(vm.AddStateCommandProperty);
            Assert.IsNotNull(vm.UpdateStateCommandProperty);
            Assert.IsNotNull(vm.DeleteStateCommandProperty);

            Assert.IsNotNull(vm.AddUserCommandProperty);
            Assert.IsNotNull(vm.UpdateUserCommandProperty);
            Assert.IsNotNull(vm.DeleteUserCommandProperty);

            Assert.IsNotNull(vm.AddEventCommandProperty);
            Assert.IsNotNull(vm.UpdateEventCommandProperty);
            Assert.IsNotNull(vm.DeleteEventCommandProperty);

            Assert.IsFalse(vm.AddBookCommandProperty.CanExecute(null));
        }
    }
}