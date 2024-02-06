using ExpressionBuilder.Common;
using ExpressionBuilder.Generics;
using RevolvingCredit.Data;
using RevolvingCredit.Data.DataFiltering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevolvingCredit.Data.DataFiltering
{
    /// <summary>
    /// Load data and build dynamic filters
    /// </summary>
    public class RawData
    {
        private static List<Customer> Customers = new List<Customer>();
        private static List<Contract> Contracts = new List<Contract>();
        private static List<UiDataFilter> CustomerFilters = new List<UiDataFilter>();

        public static void LoadData()
        {
            #region CustomerData
            Customers.Add(new Customer(1, "Nancy Davolio", "Ana Trujillo Emparedados y helados", "New Balance 5th Avenue Mile 2017", "New York", "615-555-0169", "Owner", false));
            Customers.Add(new Customer(2, "Andrew Fuller", "Antonio Moreno Taquería", "514 S. Magnolia St. ", "Orlando", "615-555-0169", "Sales Representative", true));
            Customers.Add(new Customer(3, "Janet Leverling", "Around the Horn", "70 Bowman St. ", "South Windsor", "615-555-0169", "Sales Representative", false));
            Customers.Add(new Customer(4, "Robert King", "Blauer See Delikatessen", "123 6th St.", "Melbourne", "615-555-0169", "Marketing Manager", false));
            Customers.Add(new Customer(5, "Laura Callahan", "Blondesddsl père et fils", "4 Goldfield Rd.", "Honolulu", "615-555-0169", "Marketing Manager", false));
            Customers.Add(new Customer(6, "Michael Suyama", "Bottom-Dollar Markets", "2 Coffee Street ", "Bergenfield", "615-555-0169", "Sales Representative", false));
            Customers.Add(new Customer(7, "Carlos Hernández", "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "(5) 555-1340", "Sales Representative", false));
            Customers.Add(new Customer(8, "Yoshi Latimer", "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "(503) 555-6874", "Sales Representative", false));
            Customers.Add(new Customer(9, "Patricia McKenna", "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "2967 542", "Sales Associate", false));
            Customers.Add(new Customer(10, "Helen Bennett", "Island Trading", "Garden House Crowther Way", "Cowes", "(198) 555-8888", "Marketing Manager", true));
            Customers.Add(new Customer(11, "Philip Cramer", "Königlich Essen", "Maubelstr. 90", "Brandenburg", "0555-09876", "Sales Associate", false));
            Customers.Add(new Customer(12, "Daniel Tonini", "La corne d'abondance", "67, avenue de l'Europe", "Versailles", "30.59.84.10", "Sales Representative", true));
            Customers.Add(new Customer(13, "Annette Roulet", "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "61.77.61.10", "Sales Manager", false));
            Customers.Add(new Customer(14, "Yoshi Tannamuri", "Laughing Bacchus Wine Cellars", "1900 Oak St.", "Vancouver", "(604) 555-3392", "Marketing Assistant", true));
            Customers.Add(new Customer(15, "John Steel", "Lazy K Kountry Store", "12 Orchestra Terrace", "Walla Walla", "(509) 555-7969", "Marketing Manager", false));
            Customers.Add(new Customer(16, "Renate Messner", "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "069-0245984", "Sales Representative", false));
            Customers.Add(new Customer(17, "Jaime Yorres", "Let's Stop N Shop", "87 Polk St. Suite 5", "San Francisco", "(415) 555-5938", "Owner", false));
            Customers.Add(new Customer(18, "Carlos González", "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "(9) 331-6954", "Accounting Manager", false));
            Customers.Add(new Customer(19, "Felipe Izquierdo", "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "(8) 34-56-12", "Owner", true));
            Customers.Add(new Customer(20, "Fran Wilson", "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "(503) 555-9573", "Sales Manager", true));
            Customers.Add(new Customer(21, "Giovanni Rovelli", "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "035-640230", "Marketing Manager", false));
            Customers.Add(new Customer(22, "Catherine Dewey", "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", "(02) 201 24 67", "Sales Agent", false));
            Customers.Add(new Customer(23, "Jean Fresnière", "Mère Paillarde", "43 rue St. Laurent", "Montréal", "(514) 555-8054", "Marketing Assistant", false));
            Customers.Add(new Customer(24, "Alexander Feuer", "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", "0342-023176", "Marketing Assistant", false));
            Customers.Add(new Customer(25, "Simon Crowther", "North/South", "South House 300 Queensbridge", "London", "(171) 555-7733", "Sales Associate", false));
            Customers.Add(new Customer(26, "Yvonne Moncada", "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", "(1) 135-5333", "Sales Agent", false));
            Customers.Add(new Customer(27, "Rene Phillips", "Old World Delicatessen", "2743 Bering St.", "Anchorage", "(907) 555-7584", "Sales Representative", false));
            Customers.Add(new Customer(28, "Henriette Pfalzheim", "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", "0221-0644327", "Owner", false));
            Customers.Add(new Customer(29, "Marie Bertrand", "Paris spécialités", "265, boulevard Charonne", "Paris", "(1) 42.34.22.66", "Owner", false));
            Customers.Add(new Customer(30, "Guillermo Fernández", "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", "(5) 552-3745", "Sales Representative", false));
            Customers.Add(new Customer(31, "Georg Pipps", "Piccolo und mehr", "Geislweg 14", "Salzburg", "6562-9722", "Sales Manager", false));
            Customers.Add(new Customer(32, "Isabel de Castro", "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "(1) 356-5634", "Sales Representative", true));
            Customers.Add(new Customer(33, "Bernardo Batista", "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "(21) 555-4252", "Accounting Manager", true));
            Customers.Add(new Customer(34, "Lúcia Carvalho", "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "(11) 555-1189", "Marketing Assistant", true));
            Customers.Add(new Customer(35, "Horst Kloss", "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "0372-035188", "Accounting Manager", false));
            Customers.Add(new Customer(36, "Sergio Gutiérrez", "Rancho grande", "Av. del Libertador 900", "Buenos Aires", "(1) 123-5555", "Sales Representative", false));
            Customers.Add(new Customer(37, "Paula Wilson", "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "(505) 555-5939", "Assistant Sales Representative", false));
            Customers.Add(new Customer(38, "Maurizio Moroni", "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "0522-556721", "Sales Associate", false));
            Customers.Add(new Customer(39, "Janete Limeira", "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "(21) 555-3412", "Assistant Sales Agent", true));
            Customers.Add(new Customer(40, "Michael Holz", "Richter Supermarkt", "Grenzacherweg 237", "Genève", "0897-034214", "Sales Manager", false));
            Customers.Add(new Customer(41, "Alejandra Camino", "Romero y tomillo", "Gran Vía, 1", "Madrid", "(91) 745 6200", "Accounting Manager", false));
            Customers.Add(new Customer(42, "Jonas Bergulfsen", "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", "07-98 92 35", "Owner", false));
            Customers.Add(new Customer(43, "Jose Pavarotti", "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "(208) 555-8097", "Sales Representative", true));
            Customers.Add(new Customer(44, "Hari Kumar", "Seven Seas Imports", "90 Wadhurst Rd.", "London", "(171) 555-1717", "Sales Manager", false));
            Customers.Add(new Customer(45, "Jytte Petersen", "Simons bistro", "Vinbæltet 34", "Kobenhavn", "31 12 34 56", "Owner", false));
            Customers.Add(new Customer(46, "Dominique Perrier", "Spécialités du monde", "25, rue Lauriston", "Paris", "(1) 47.55.60.10", "Marketing Manager", false));
            Customers.Add(new Customer(47, "Art Braunschweiger", "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "(307) 555-4680", "Sales Manager", false));
            Customers.Add(new Customer(48, "Pascale Cartrain", "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", "(071) 23 67 22 20", "Accounting Manager", true));
            Customers.Add(new Customer(49, "Liz Nixon", "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "(503) 555-3612", "Marketing Manager", false));
            Customers.Add(new Customer(50, "Liu Wong", "The Cracker Box", "55 Grizzly Peak Rd.", "Butte", "(406) 555-5834", "Marketing Assistant", true));
            Customers.Add(new Customer(51, "Karin Josephs", "Toms Spezialitäten", "Luisenstr. 48", "Münster", "0251-031259", "Marketing Manager", false));
            Customers.Add(new Customer(52, "Miguel Angel Paolino", "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "(5) 555-2933", "Owner", false));
            Customers.Add(new Customer(53, "Anabela Domingues", "Tradição Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "(11) 555-2167", "Sales Representative", false));
            Customers.Add(new Customer(54, "Helvetius Nagy", "Trail's Head Gourmet Provisioners", "722 DaVinci Blvd.", "Kirkland", "(206) 555-8257", "Sales Associate", false));
            Customers.Add(new Customer(55, "Palle Ibsen", "Vaffeljernet", "Smagsloget 45", "Århus", "86 21 32 43", "Sales Manager", false));
            Customers.Add(new Customer(56, "Mary Saveley", "Victuailles en stock", "2, rue du Commerce", "Lyon", "78.32.54.86", "Sales Agent", false));
            Customers.Add(new Customer(57, "Paul Henriot", "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "26.47.15.10", "Accounting Manager", false));
            Customers.Add(new Customer(58, "Rita Müller", "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "0711-020361", "Sales Representative", false));
            Customers.Add(new Customer(59, "Pirkko Koskitalo", "Wartian Herkku", "Torikatu 38", "Oulu", "981-443655", "Accounting Manager", false));
            Customers.Add(new Customer(60, "Paula Parente", "Wellington Importadora", "Rua do Mercado, 12", "Resende", "(14) 555-8122", "Sales Manager", true));
            Customers.Add(new Customer(62, "Karl Jablonski", "White Clover Markets", "305 - 14th Ave. S. Suite 3B", "Seattle", "(206) 555-4112", "Owner", true));
            Customers.Add(new Customer(62, "Matti Karttunen", "Wilman Kala", "Keskuskatu 45", "Helsinki", "90-224 8858", "Owner/Marketing Assistant", true));
            Customers.Add(new Customer(63, "Zbyszek Piestrzeniewicz", "Wolski  Zajazd", "ul. Filtrowa 68", "Warszawa", "(26) 642-7012", "Owner", false));
            #endregion

            #region Contracts
            Contracts.Add(new Contract(1000, RndBroker(), RndStartDate(), RndTerms(), "More documents needed", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1001, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1002, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1003, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1004, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1005, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1006, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1007, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1008, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1009, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1010, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1011, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1012, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1013, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1014, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1015, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1016, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1017, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1018, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1019, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1020, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1021, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1022, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1023, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1024, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1025, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1026, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1027, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1028, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1029, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1030, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1031, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1032, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1033, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1034, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1035, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1036, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1037, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1038, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1039, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1040, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1041, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1042, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1043, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1044, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1045, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1046, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1047, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1048, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1049, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1050, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1051, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1052, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1053, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1054, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1055, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1056, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1057, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1058, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1059, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1060, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1061, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            Contracts.Add(new Contract(1062, RndBroker(), RndStartDate(), RndTerms(), "NA", RndAmount(), RndInterest(), RndState()));
            #endregion

            #region CustomerFilers
            CustomerFilters.Add(new UiDataFilter("Business Type", "B2B", "IsBusiness", true));
            CustomerFilters.Add(new UiDataFilter("Business Type", "B2C", "IsBusiness", false));
            CustomerFilters.Add(new UiDataFilter("Contract Status", "In Progress", "ContractInProgress", true));
            CustomerFilters.Add(new UiDataFilter("Contract Status", "Completed", "ContractInProgress", false));
            #endregion
        }

        public static List<UiDataFilter> GetCustomerFilters()
        {
            return CustomerFilters;
        }

        public static Contract ContractListById(int id)
        {
            return Contracts.Where(c => c.Id == id).FirstOrDefault();
        }

        public static List<Customer> FilteredCustomerList(List<DbFilter>? filters = null)
        {
            if (filters == null)
            {
                return Customers;
            }
            //Connector conector = Connector.Or;
            Filter<Customer> dynoFilters = DynamicFilter<Customer>(filters);
            return Customers.Where(dynoFilters).ToList();
        }

        private static Filter<T> DynamicFilter<T>(List<DbFilter> filters) where T : class
        {
            var newFilter = new Filter<T>();
            foreach (var myFilter in filters)
            {
                newFilter.By(myFilter.PropertyName, myFilter.Operation, myFilter.Value, myFilter.SecondValue, myFilter.FilterConnector);
            }
            return newFilter;
        }

        private static int RndTerms()
        {
            Random rnd = new Random();
            return rnd.Next(10, 30);
        }

        private static DateTime RndStartDate()
        {
            Random rnd = new Random();
            return DateTime.Now.AddDays(rnd.Next(10, 100) * (-1));
        }

        private static int RndInterest()
        {
            Random rnd = new Random();
            return rnd.Next(8, 14);
        }
        private static int RndAmount()
        {
            Random rnd = new Random();
            return rnd.Next(4, 30) * 10000;
        }

        private static string RndBroker()
        {
            Random rnd = new Random();
            var stateIndex = rnd.Next(1, 10);
            return BrokerByIndex(stateIndex);
        }

        private static string BrokerByIndex(int index)
        {
            string[] brokers = new string[] {"Joe Doe","John Smith","Maria Devale","Robert King","Alfonso De Brie","Emanuel Goss Jr.","Bartolomeu Gee","Joana Loke","Ana Kotrik", "Luca De Mango"
            };
            return brokers[index];
        }

        private static string RndState()
        {
            Random rnd = new Random();
            var stateIndex = rnd.Next(1, 50);
            return StateByIndex(stateIndex);
        }
        private static string StateByIndex(int index)
        {
            string[] states = new string[] {
                    "Alabama",
                    "Alaska",
                    "Arizona",
                     "Arkansas",
                    "California",
                    "Colorado",
                    "Connecticut",
                    "Delaware",
                    "District of Columbia",
                    "Florida",
                    "Georgia",
                    "Hawaii",
                    "Idaho",
                    "Illinois",
                    "Indiana",
                    "Iowa",
                    "Kansas",
                    "Kentucky",
                    "Louisiana",
                    "Maine",
                    "Maryland",
                    "Massachusetts",
                    "Michigan",
                    "Minnesota",
                    "Mississippi",
                    "Missouri",
                    "Montana",
                    "Nebraska",
                    "Nevada",
                    "New Hampshire",
                    "New Jersey",
                    "New Mexico",
                    "New York",
                    "North Carolina",
                    "North Dakota",
                    "Ohio",
                    "Oklahoma",
                    "Oregon",
                    "Pennsylvania",
                    "Rhode Island",
                    "South Carolina",
                    "South Dakota",
                    "Tennessee",
                    "Texas",
                    "Utah",
                    "Vermont",
                    "Virginia",
                    "Washington",
                    "West Virginia",
                    "Wisconsin",
                    "Wyoming"
                };
            return states[index];
        }
    }
}
