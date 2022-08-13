using Q_and_A_Forum.Context;
using Q_and_A_Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Q_and_A_Forum.Controllers
{
    public class HomeController : Controller
    {
        private ForumDbContext db = new ForumDbContext();
        public ActionResult Index()
        {

            var list = db.Topics.OrderBy(p => p.Date).ToList();

            var newList = db.Topics.Include("Replies").ToList();


            if (list.Count == 0)
            {
                var topic = new List<Topic>
            {
            new Topic{UserId="Bob023", Title="Achieving a better future",Description="Sustainability is right at the heart of Siemens Gamesa Renewable Energy. It is the driving philosophy of our company, and we regard it with utmost respect.",Tags=new List<string>(), Date=DateTime.Now,
                Replies = new List<Reply>
                (){
            new Reply{UserId="Bella", Description="Climate change, water scarcity, geopolitical conflicts, resource depletion, and economic inequality – these must all be acknowledged as the challenges they are, and then they must be met and overcome.",Date=new DateTime(2010, 06, 15, 20, 19, 03)},

                }},
            new Topic{UserId="Bob023", Title="Siemens Gamesa receives an MSCI ESG rating of A",Description="Siemens Gamesa Renewable Energy recently received a rating of A (on a scale of AAA-CCC) in the MSCI ESG ratings assessment, enabling the company´s inclusion in the MSCI indices and with an investment grade rating. The MSCI ESG ratings measure companies, according to exposure to industry-specific environmental, social and government (ESG) risks and the ability to manage those risks.Siemens Gamesa's upgrade from ‘BB’ was driven by an improvement in its environmental, social and governance practices and policies.",Tags=new List<string>(){"environmental", "social", "political" }, Date=new DateTime(2016, 09, 28, 19, 35, 02)},
            new Topic{UserId="Bob023", Title="Siemens Gamesa secures preferred supplier status for 1.1 GW offshore in Germany using upgraded 11 MW turbine with 200-meter rotor",Description="Ørsted has conditionally named Siemens Gamesa Renewable Energy as the preferred turbine supplier for two offshore wind power projects in the German North Sea totaling 1,142 GW. At both the 900 MW Borkum Riffgrund 3 and the 242 MW Gode Wind 3 sites, Siemens Gamesa will deploy its new SG 11.0-200 DD offshore wind turbine. A five-year service and maintenance agreement is included in the preferred supplier award.",Tags=new List<string>(){"242 MW Gode Wind 3 sites", "Siemens Gamesa" }, Date=new DateTime(2015, 02, 16, 09, 38, 55)},
            new Topic{UserId="Bob023", Title="Africa’s energy transition gains traction as Siemens Gamesa introduces renewable energy in Djibouti",Description="Energy access rates and reliability in Africa are the lowest in the world and electricity costs are among the highest. In line with its commitment to deliver cleaner, more reliable and affordable energy in Africa, Siemens Gamesa has sealed a contract to build the first renewable energy installation in the Republic of Djibouti.",Tags=new List<string>(){"Renewable energy", "Republic of Djibouti"}, Date=new DateTime(2019, 11, 02, 10, 16, 56)},
            new Topic{UserId="Bella", Title="Siemens Gamesa successfully completes acquisition of European Service assets and IP from Senvion",Description="Siemens Gamesa Renewable Energy announced today the closing of the acquisition of Senvion’s European Service assets and Intellectual Property (IP). The transaction adds approximately 9.0 GW of serviced fleet and operations in 13 countries.The addition of the Senvion assets marks an important step in the company’s growth strategy, part of the company’s L3AD2020 strategic program, and strengthens its competitive position in its multibrand portfolio.",Tags=new List<string>(), Date=new DateTime(2011, 6, 10, 15, 24, 16)},

                    new Topic{UserId="Kasper", Title="Gigawatt growth in the USA: Siemens Gamesa named preferred supplier for largest U.S. offshore wind power project to date at 2.64 GW",Description="Siemens Gamesa Renewable Energy (SGRE) has been named as the preferred turbine supplier for the massive 2,640-MW Dominion Energy Virginia Offshore Wind project in the USA. This is the largest offshore wind power project in the rapidly increasing U.S. market to date. A long-term service and maintenance agreement is included for the site located off the coast of Virginia. The agreement furthermore foresees utilizing turbines from Siemens Gamesa’s Direct Drive offshore wind turbine platform.",Tags=new List<string>(), Date=new DateTime(2018, 06, 30, 08, 09, 11)
            ,Replies=new List<Reply>(){
            new Reply{
               UserId="Bob023",
                Description="The final number of units and turbine model remain to be determined. All installations are expected to complete by 2026. The agreement is subject to certain conditions including Dominion Energy’s final investment decision, governmental permitting, and other required approvals.",
                Date=new DateTime(2020, 02, 02, 13, 08, 46)},
            } }
            };
                topic.ForEach(s => db.Topics.Add(s));
                db.SaveChanges();

                return View(newList);
            }
            else
            {
                return View(newList);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}