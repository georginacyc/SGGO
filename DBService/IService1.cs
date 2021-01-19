using DBService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        int CreateAccount (string email, string password, string type, string first_name, string last_name, string hp, string address, DateTime? last_login, DateTime account_created, string staff_id, int? points, List<int> owns);

        [OperationContract]
        Account GetAccountByEmail(string email);

        [OperationContract]
        List<Account> GetAllAccounts();

        //Gem
        [OperationContract]
        int CreateGem(string title, string description, string type, string location, DateTime? date, string status, float rating, string partner, string image);

        [OperationContract]
        Gem GetGemByTitle(string title);

        [OperationContract]
        List<Gem> GetAllGems();


        //Trail
        [OperationContract]
        int CreateTrail(string trailId, string name, DateTime date, string description, string gem1, string gem2, string gem3, string banner);

        [OperationContract]
        Trail GetTrailById(string id);

        [OperationContract]
        List<Trail> GetAllTrails();


        //Review
        [OperationContract]
        int CreateReview(string status, string post, string author, string rating, string description);

        [OperationContract]
        Review GetReviewByAuthor(string author);

        [OperationContract]
        List<Review> GetAllReview();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "DBService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
