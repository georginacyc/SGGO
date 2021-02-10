using DBService.Entity;
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

        public int CreateGem(string title, string description, string type, string location, DateTime? date, string status, float rating, string partner, string image)
        {
            Gem gem = new Gem(title, description, type, location, date, status, rating, partner, image);
            return gem.Insert();
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

        public int CreateReview(string status, string post, string author, string rating, string description)
        {
            Review review = new Review(status, post, author, rating, description);
            return review.Insert();
        }
        public int CreatePointShopItem(string name, string partner, string description, int price, string image, string type, string qr)
        {
            Point_Shop_Item item = new Point_Shop_Item(name, partner, description, price, image, type, qr);
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
    }
}
