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
        int CreateAccount(string email, string pw, string salt, string type, string first_name, string last_name, DateTime dob, string hp, string postal, string address, string profilepic, string staff_id, int? diamonds);

        [OperationContract]
        Account GetAccountByEmail(string email);

        [OperationContract]
        List<Account> GetAllAccounts();

        [OperationContract]
        int ChangePassword(string email, string newpass);

        [OperationContract]
        bool CheckAttempts(string email, bool pass);

        [OperationContract]
        bool CheckSuspended(string email);

        [OperationContract]
        string GetStaffId();

        //Gem
        [OperationContract]
        int CreateGem(string title, string description, string type, string location, DateTime? date, string status, float rating, string partner, string image);

        [OperationContract]
        Gem GetGemByTitle(string title);

        [OperationContract]
        List<Gem> GetAllGems();


        //Trail
        [OperationContract]
        int CreateTrail(string trailId, string name, DateTime date, string description, string gem1, string gem2, string gem3, string banner, string status);

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
        Review GetReviewById(int review_id);

        [OperationContract]
        List<Review> GetAllReview();

        //Report
        [OperationContract]
        int CreateReport(DateTime date_reported, string type, string reported_by, string reason, string remarks, string status);

        [OperationContract]
        Report GetReportByStatus(string status);

        [OperationContract]
        List<Report> GetAllReport();

        //Point Shop
        [OperationContract]
        int CreatePointShopItem(string name, string partner, string description, int price, string image, string type, string qr);

        [OperationContract]
        Point_Shop_Item SelectById(string Point_Shop_Item_Id);

        [OperationContract]
        List<Point_Shop_Item> SelectAll();
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
