﻿using DBService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int CreateAccount(string email, string pw, string salt, string type, string first_name, string last_name, DateTime dob, string hp, string postal, string address, string profilepic, string staff_id, int? diamonds)
        {
            Account user = new Account(email, pw, salt, type, first_name, last_name, dob, hp, postal, address, profilepic, staff_id, diamonds);
            return user.Insert();
        }

        public Account GetAccountByEmail(string email)
        {
            Account accounts = new Account();
            return accounts.SelectByEmail(email);
        }

        public void UpdateUserProfile(string email, string hp, string address, string postal)
        {
            Account user = new Account();
            user.UpdateUserProfile(email, hp, address, postal);
        }

        public List<Account> GetAllAccounts()
        {
            Account accounts = new Account();
            return accounts.SelectAll();
        }
        public int ChangePassword(string email, string newpass)
        {
            Account user = new Account();
            return user.ChangePassword(email, newpass);
        }

        public bool CheckAttempts(string email, bool pass)
        {
            Account user = new Account();
            return user.CheckAttempts(email, pass);
        }

        public bool CheckSuspended(string email)
        {
            Account user = new Account();
            return user.CheckSuspended(email);
        }

        public string GetStaffId()
        {
            Account user = new Account();
            return user.GetStaffId();
        }

        public void UpdateLastLogin(string email)
        {
            Account user = new Account();
            user.UpdateLogin(email);
        }

        public void StaffResetPassword(string email)
        {
            Account user = new Account();
            user.ResetPassword(email);
        }

        // Gems
        public List<Gem> GetAllGems()
        {
            Gem gem = new Gem();
            return gem.SelectAll();
        }

        public Gem GetGemByTitle (string title)
        {
            Gem gem = new Gem();
            return gem.SelectByTitle(title);
        }

        public int CreateGem(string partner_email, string title, string description, string type, string location, DateTime? date, string status, float rating, string partner, string image)
        {
            Gem gem = new Gem(partner_email, title, description, type, location, date, status, rating, partner, image);
            return gem.Insert();
        }

        public void UpdateGemStatus(int gem_id, string status)
        {
            Gem gem = new Gem();
            gem.UpdateStatus(gem_id, status);
        }

        //public void UpdateGemRating(int gem_id)
        //{
        //    Gem gem = new Gem();
        //    gem.UpdateRating(gem_id);
        //}

        public Gem GetGemById(int id)
        {
            Gem gem = new Gem();
            return gem.SelectById(id);
        }

        public int CountPendingGems()
        {
            Gem gem = new Gem();
            return gem.CountPending();
        }

        public void DeleteGem(int Id)
        {
            Gem gem = new Gem();
            gem.DeleteGem(Id);
        }

        // Monthly Trail
        public List<Trail> GetAllTrails()
        {
            Trail tr = new Trail();
            return tr.SelectAll();
        }
        
        public Trail GetTrailById(string id)
        {
            Trail tr = new Trail();
            return tr.SelectById(id);
        }

        public int CreateTrail(string trailId, string name, DateTime date, string description, string gem1, string gem2, string gem3, string banner, string status)
        {
            Trail tr = new Trail(trailId, name, date, description, gem1, gem2, gem3, banner,status);
            return tr.Insert();
        }

        public List<Trail> GetTrailByStatus(string status)
        {
            Trail tr = new Trail();
            return tr.SelectByStatus(status);
        }

        public int UpdateTrail(string trailid, string title, DateTime date, string description, string gem1, string gem2, string gem3, string banner, string status)
        {
            Trail tr = new Trail(); 
            return tr.UpdateTrail(trailid,title,date,description,gem1,gem2,gem3,banner,status);
        }

        public int UpdateTrailStatus(string trailid, string status)
        {
            Trail tr = new Trail();
            return tr.UpdateTrailStatus(trailid, status);
        }

        public void DeleteTrail(string trailid)
        {
            Trail tr = new Trail();
            var trail = tr.SelectById(trailid);
            trail.DeleteTrail(trailid);
        }

        //Reviews
        public List<Review> GetAllReview()
        {
            Review review = new Review();
            return review.SelectAll();
        }

        public Review GetReviewByAuthor(string author)
        {
            Review review = new Review();
            return review.SelectByAuthor(author);
        }

        public Review GetReviewById(int review_id)
        {
            Review review = new Review();
            return review.SelectById(review_id);
        }

        public int CreateReview(string status, string gem_id, string gem_title, string author, int rating, string description)
        {
            Review review = new Review(status, gem_id, gem_title, author, rating, description);
            return review.Insert();
        }

        public void UpdateReviewStatus(int review_id, string status)
        {
            Review review = new Review();
            review.UpdateStatus(review_id, status);
            var rev = review.SelectById(review_id);
            Gem gem = new Gem();
            gem.UpdateRating(Convert.ToInt32(rev.Gem_Id));
            if (status == "Approved")
            {
                Account user = new Account();
                user.AddPoints(rev.Author);
            }
        }

        public int CountPendingReviews()
        {
            Review review = new Review();
            return review.CountPending();
        }

        public void DeleteReview(int review_id)
        {
            Review review = new Review();
            var rev = review.SelectById(review_id);
            string gem_id = rev.Gem_Id;
            review.DeleteReview(review_id);
            Gem gem = new Gem();
            gem.UpdateRating(Convert.ToInt32(gem_id));
        }

        //Reports
        public List<Report> GetAllReports()
        {
            Report report = new Report();
            return report.SelectAll();
        }

        public Report GetReportByStatus(string status)
        {
            Report report = new Report();
            return report.SelectByStatus(status);
        }

        public Report GetReportById(int report_id)
        {
            Report report = new Report();
            return report.SelectById(report_id);
        }

        public int CreateReport(DateTime date_reported, string post, string type, string reported_by, string reason, string remarks, string status)
        {
            Report report = new Report(date_reported, post, type, reported_by, reason, remarks, status);
            return report.Insert();
        }

        public void UpdateReportStatus(int review_id, string status)
        {
            Report report = new Report();
            report.UpdateStatus(review_id, status);
        }

        public int CountUnresolvedReports()
        {
            Report report = new Report();
            return report.CountUnresolved();
        }


        public int CreatePointShopItem(string name, string partner, string partner_email, string description, int price, string image, string type)
        {
            Point_Shop_Item item = new Point_Shop_Item(name, partner, partner_email, description, price, image, type);
            return item.Insert();
        }

        //Point Shop
        public Point_Shop_Item SelectById(string Point_Shop_Item_Id) 
        {
            Point_Shop_Item items = new Point_Shop_Item();
            return items.SelectById(Point_Shop_Item_Id);
        }

        public List<Point_Shop_Item> SelectAll()
        {
            Point_Shop_Item items = new Point_Shop_Item();
            return items.SelectAll();
        }

        public void DeletePointShopItem(int point_shop_item_id)
        {
            Point_Shop_Item psi = new Point_Shop_Item();
            psi.DeletePointShopItem(point_shop_item_id);
        }
    }
}
