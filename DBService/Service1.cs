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

        public int CreateAccount(string email, string password, string type, string first_name, string last_name, string hp, string address, DateTime? last_login, DateTime account_created, string staff_id, int? points, List<int> owns)
        {
            Account user = new Account(email, password, type, first_name, last_name, hp, address, last_login, account_created, staff_id, points, null);
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

        public int CreateTrail(string trailId, string name, DateTime date, string description, int gem1, int gem2, int gem3, string banner)
        {
            Trail tr = new Trail(trailId, name, date, description, gem1, gem2, gem3, banner);
            return tr.Insert();
        }

    }
}
