using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritence
{
        class Game
    {
        int NoOfPlayers;
        string Country;
        public string country { get; set; }
        public int noofplayers { get; set; }
        public Game()
        {
                
        }
        public Game(int _NoOfPlayers,string _Country)
        {
            NoOfPlayers = _NoOfPlayers;
            Country = _Country;
        }
        public void WorldCup()
        {
            Console.WriteLine("WorldCup {0}",DateTime.Now);

        }
    }
    class Cricket:Game
    {   
        string CoachName;
        public string coachname { get; set; }
        public Cricket()
        {
                
        }
        public Cricket(int NoOfPlayers,string Country,string CoachName):base(NoOfPlayers,Country)
        {
            //new ShowGameDetails().ShowCricketDetails(NoOfPlayers,Country,CoachName);

        }

    }
    class Football:Game
    {
        string LeagueName;
        public string leaguename { get; set; }
        public Football()
        {

        }
        public Football(int NoOfPlayers,string Country,string LeagueName):base(NoOfPlayers,Country)
        {
            //new ShowGameDetails().ShowFootBallDetails(NoOfPlayers, Country, LeagueName);
        }
    }
    class ShowGameDetails
    {
        int nop;
        string country;
        string cname;
        public ShowGameDetails()
        {

        }
        public ShowGameDetails(int no,string c,string cn)
        {
            nop = no;
            country = c;
            cname = cn;
        }
        public void ShowCricketDetails()
        {
            Console.WriteLine("-------------CRICKET INFORMATION--------------");
            Console.WriteLine("Country : {0} No of Players : {1} Coach Name : {2}",nop,country,cname );
        }
        public void ShowFootBallDetails(int nop,string c,string ln)
        {
            Console.WriteLine("-------------FOOTBALL INFORMATION--------------");
            Console.WriteLine("Country : {0} No of Players : {1} League Name : {2}",nop,country,cname);
        }
        public void SetData()
        {

        }
        public void GetData()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricket india = new Cricket();
            Cricket Australia = new Cricket(11, "Australia", "John Buchanam");
            Football spain = new Football(14, "Spain", "Spanish League");
            Football england = new Football(13, "England", "English Premiur League");
            new ShowGameDetails(11, "India", "John Wright").ShowCricketDetails();
            Game g = new Game();
            g.WorldCup();
                   
            
            
        }
    }
}
