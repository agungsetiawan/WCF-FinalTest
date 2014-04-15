using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace UnitTestProject
{
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        List<Player> GetAll();

        [OperationContract]
        Player GetByNumber(int playerNumber);

        [OperationContract]
        void Save(Player player);

        [OperationContract]
        void Delete(int playerNumber);

        [OperationContract]
        void Update(Player player);

    }
}
