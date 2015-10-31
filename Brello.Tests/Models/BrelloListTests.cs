using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models

namespace Brello.Models
{
    [TestClass]
    public class BrelloListTests
    {
        [TestMethod]
        public void BrelloListEnsurICanCreateInstance()
        {
            BrelloList brello_list = new BrelloList();
            Assert.IsNotNull(brello_list);
        }
    }
}
