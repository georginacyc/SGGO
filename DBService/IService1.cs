﻿using DBService.Entity;
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
        void UpdateUserProfile(string email, string hp, string address, string postal);

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

        [OperationContract]
        void UpdateLastLogin(string email);

        [OperationContract]
        void StaffResetPassword(string email);

        //Gem
        [OperationContract]
        int CreateGem(string partner_email, string title, string description, string type, string location, DateTime? date, string status, float rating, string partner, string image);

        [OperationContract]
        Gem GetGemByTitle(string title);

        [OperationContract]
        List<Gem> GetAllGems();

        [OperationContract]
        void UpdateGemStatus(int gem_id, string status);

        //[OperationContract]
        //void UpdateGemRating(int gem_id, float rating);

        [OperationContract]
        Gem GetGemById(int id);

        [OperationContract]
        int CountPendingGems();

        [OperationContract]
        void DeleteGem(int id);

        //Trail
        [OperationContract]
        int CreateTrail(string trailId, string name, DateTime date, string description, string gem1, string gem2, string gem3, string banner, string status);

        [OperationContract]
        Trail GetTrailById(string id);

        [OperationContract]
        List<Trail> GetAllTrails();

        [OperationContract]
        List<Trail> GetTrailByStatus(string status);

        [OperationContract]
        int UpdateTrail(string trailid, string title, DateTime date, string description, string gem1, string gem2, string gem3, string banner, string status);

        [OperationContract]
        int UpdateTrailStatus(string trailid,string status);

        [OperationContract]
        void DeleteTrail(string trailid);

        //Review
        [OperationContract]
        int CreateReview(string status, string gem_id, string gem_title, string author, int rating, string description);

        [OperationContract]
        Review GetReviewByAuthor(string author);

        [OperationContract]
        Review GetReviewById(int review_id);

        [OperationContract]
        List<Review> GetAllReview();

        [OperationContract]
        void UpdateReviewStatus(int review_id, string status);

        [OperationContract]
        void DeleteReview(int review_id);


        [OperationContract]
        int CountPendingReviews();

        //Report
        [OperationContract]
        int CreateReport(DateTime date_reported, string post, string type, string reported_by, string reason, string remarks, string status);

        [OperationContract]
        Report GetReportByStatus(string status);

        [OperationContract]
        Report GetReportById(int report_id);

        [OperationContract]
        List<Report> GetAllReports();

        [OperationContract]
        void UpdateReportStatus(int review_id, string status);

        [OperationContract]
        int CountUnresolvedReports();


        //Point Shop
        [OperationContract]
        int CreatePointShopItem(string name, string partner, string partner_email, string description, int price, string image, string type);

        [OperationContract]
        Point_Shop_Item SelectById(string Point_Shop_Item_Id);

        [OperationContract]
        List<Point_Shop_Item> SelectAll();

        [OperationContract]
        void DeletePointShopItem(int id);
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
