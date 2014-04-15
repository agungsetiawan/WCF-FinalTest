using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using Model;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private EndpointAddress address;
        private BasicHttpBinding binding;
        private ChannelFactory<IService> factory;
        private IService service;

        [TestMethod]
        public void TestGetAllBasicBinding()
        {
            address = new EndpointAddress("http://localhost:63722/Service.svc");
            binding = new BasicHttpBinding();
            factory = new ChannelFactory<IService>(binding, address);

            service = factory.CreateChannel();
            List<Player> actual = service.GetAll();            

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("Ronaldo", actual[0].Name);
            Assert.AreEqual("Benzema", actual[1].Name);

            ((IClientChannel)service).Close();
        }

        [TestMethod]
        public void TestGetAllWsBinding()
        {
            address = new EndpointAddress("http://localhost:63722/Service.svc/secure");
            WSHttpBinding binding = new WSHttpBinding();
            factory = new ChannelFactory<IService>(binding, address);

            service = factory.CreateChannel();
            List<Player> actual = service.GetAll();

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("Ronaldo", actual[0].Name);
            Assert.AreEqual("Benzema", actual[1].Name);

            ((IClientChannel)service).Close();
        }
    }
}
