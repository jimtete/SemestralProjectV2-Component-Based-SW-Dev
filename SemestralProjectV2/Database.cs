using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProjectV2
{
    class Database
    {
        public static BindingList<Question> Questions { get; private set; } = new BindingList<Question>();

        static Database()
        {

            //Loads / Creates the game's questions
            addQuestions();


            //Adds answers to the questions
            addAnswer("Greece", "Hellas", 2,0);
            addAnswer("Bulgaria", "Burgaria", 1, 0);
            addAnswer("North Macedonia", "Macedonia", 1, 0);
            addAnswer("Albania", "Albany", 1, 0);
            addAnswer("Montenegro", 2, 0);
            addAnswer("Serbia", 1, 0);
            addAnswer("Croatia", 2, 0);
            addAnswer("Bosnia & Herzegovina", "Bosnia", 2, 0);
            addAnswer("Slovenia", 5, 0);
            addAnswer("Romania", "Roumania", 2, 0);

            addAnswer("Finland", 1, 1);
            addAnswer("Sweden", 1, 1);
            addAnswer("Russia", "USSR", 1, 1);
            addAnswer("Iceland", 2, 1);
            addAnswer("Norway", 1, 1);
            addAnswer("Denmark", 1, 1);
            addAnswer("Estonia", "Esthonia", 2, 1);
            addAnswer("Latvia", 2, 1);
            addAnswer("Lithuania", 2, 1);
            addAnswer("Belarus", "Belarussia", 5, 1);

            addAnswer("California",1, 2);
            addAnswer("Nevada",2, 2);
            addAnswer("Arizona",2, 2);
            addAnswer("Washington",2, 2);
            addAnswer("Oregon",1, 2);
            addAnswer("Idaho",2, 2);
            addAnswer("Utah",2, 2);
            addAnswer("Montana",5, 2);
            addAnswer("Wyoming",5, 2);
            addAnswer("New Mexico",1, 2);

            addAnswer("China",1, 3);
            addAnswer("India","British Raj",1, 3);
            addAnswer("United States","USA",2, 3);
            addAnswer("Indonesia",2, 3);
            addAnswer("Pakistan",5, 3);
            addAnswer("Brazil",2, 3);
            addAnswer("Nigeria",2, 3);
            addAnswer("Bangladesh",2, 3);
            addAnswer("Russia","USSR",1, 3);
            addAnswer("Mexico",1, 3);

            addAnswer("Qatar",1, 4);
            addAnswer("Macau",2, 4);
            addAnswer("Singapore",1, 4);
            addAnswer("Brunei",5, 4);
            addAnswer("United Arab Emirates","UAE",1, 4);
            addAnswer("Kuwait",2, 4);
            addAnswer("Hong Kong","HK",2, 4);
            addAnswer("Taiwan",2, 4);
            addAnswer("Saudi Arabia","Arabia",1, 4);
            addAnswer("Bahrain",2, 4);

            addAnswer("Kill Bill Vol.1", "Kill Bill", 1, 5);
            addAnswer("Kill Bill Vol.2","Kill Bill 2",2, 5);
            addAnswer("Reservoir Dogs",1, 5);
            addAnswer("Pulp fiction",1, 5);
            addAnswer("Jackie Brown",2, 5);
            addAnswer("Death proof","Grindhouse",5, 5);
            addAnswer("Inglorious Basterds","Inglorious Bastards",1, 5);
            addAnswer("Django: Unchained","Django",1, 5);
            addAnswer("Hateful Eight","Hateful 8",2, 5);
            addAnswer("Once upon a time ... Hollywood","Once Upon a time in hollywood",1, 5);

            addAnswer("Robert Downey Jr.",1, 6);
            addAnswer("Chris Evans",1, 6);
            addAnswer("Chris Hemsworth",1, 6);
            addAnswer("Scarlett Johansson",1, 6);
            addAnswer("Jeremy Renner",2, 6);
            addAnswer("Mark Ruffalo",1, 6);
            addAnswer("Josh Brolin",1, 6);
            addAnswer("Brie Larson",1, 6);
            addAnswer("Paul Rudd",2, 6);
            addAnswer("Bradley Cooper",5, 6);

            addAnswer("The Irishman",1, 7);
            addAnswer("Silence",2, 7);
            addAnswer("The wolf of the wall street",1, 7);
            addAnswer("Hugo",1, 7);
            addAnswer("Shutter Island",1, 7);
            addAnswer("The Departed",2, 7);
            addAnswer("The Aviator",2, 7);
            addAnswer("Gangs of New York",2, 7);
            addAnswer("Bringing out the dead",5, 7);
            addAnswer("Kundun",5, 7);

            addAnswer("La la land",1, 8);
            addAnswer("The favourite","The Favorite",1, 8);
            addAnswer("Easy A","EasyA",1, 8);
            addAnswer("Paper Man",2, 8);
            addAnswer("Zombieland",2, 8);
            addAnswer("Birdman", "Birdman or (The Unexpected Virtue of Ignorance)",2, 8);
            addAnswer("Superbad",2, 8);
            addAnswer("The Amazing Spider-man","The Amazing Spiderman",1, 8);
            addAnswer("The Help",2, 8);
            addAnswer("Irrational Man",5, 8);

            addAnswer("Lady bird","Ladybird",1, 9);
            addAnswer("Midsommar",2, 9);
            addAnswer("The lighthouse",1, 9);
            addAnswer("Room",1, 9);
            addAnswer("Hereditary",1, 9);
            addAnswer("The lobster",2, 9);
            addAnswer("Ex Machina",1, 9);
            addAnswer("Good time",2, 9);
            addAnswer("Uncut Gems",2, 9);
            addAnswer("Life after Beth",5, 9);

            addAnswer("Monitor",1, 10);
            addAnswer("Keyboard",1, 10);
            addAnswer("Pen","Pencil",1, 10);
            addAnswer("Coffee Mug","Mug",2, 10);
            addAnswer("Glass",1, 10);
            addAnswer("Laptop",1, 10);
            addAnswer("Smartphone","Phone",1, 10);
            addAnswer("Plate","Bowl",2, 10);
            addAnswer("Wallet",2, 10);
            addAnswer("Decorates","Decoratives",5, 10);

            addAnswer("Supermarket","Super-market",1, 11);
            addAnswer("Post-office","Post office",1, 11);
            addAnswer("Clinic","Medical Clinic",2, 11);
            addAnswer("Liquor Store",1, 11);
            addAnswer("Hospital",1, 11);
            addAnswer("Clothes Store",2, 11);
            addAnswer("Bus station","Bus stop",1, 11);
            addAnswer("Police Station",2, 11);
            addAnswer("Museum",2, 11);
            addAnswer("Zoo","Park",5, 11);

            addAnswer("Noah",5, 12);
            addAnswer("Liam",2, 12);
            addAnswer("Mason",2, 12);
            addAnswer("Jacob",1, 12);
            addAnswer("William","Will",1, 12);
            addAnswer("Ethan",2, 12);
            addAnswer("Michael","Mike",1, 12);
            addAnswer("Alexander","Alex",1, 12);
            addAnswer("James","Jim",1, 12);
            addAnswer("Daniel",2, 12);

            addAnswer("Toilet",1, 13);
            addAnswer("Shower",1, 13);
            addAnswer("Bath",1, 13);
            addAnswer("Sink",1, 13);
            addAnswer("Toothpaste","Paste",2, 13);
            addAnswer("Toothbrush","Brush",1, 13);
            addAnswer("Body spray",2, 13);
            addAnswer("Shampoo",1, 13);
            addAnswer("Razor",2, 13);
            addAnswer("Bidet",5, 13);

            addAnswer("Bus",1, 14);
            addAnswer("Tram",1, 14);
            addAnswer("Metro",1, 14);
            addAnswer("Train",2, 14);
            addAnswer("Bicycle","Bike",1, 14);
            addAnswer("Tricycle",5, 14);
            addAnswer("Motorbike","Motorcycle",1, 14);
            addAnswer("Car","Autocar",1, 14);
            addAnswer("Electric Scooter","Scooter",2, 14);
            addAnswer("Skateboard","Skate",5, 14);

            addAnswer("Donald Trump",1, 15);
            addAnswer("Barack Obama",1, 15);
            addAnswer("George W. Bush",1, 15);
            addAnswer("Bill Clinton",2, 15);
            addAnswer("George H. W. Bush",2, 15);
            addAnswer("Ronald Reagan",1, 15);
            addAnswer("Jimmy Carter",2, 15);
            addAnswer("Gerald Ford",5, 15);
            addAnswer("Richard Nixon",1, 15);
            addAnswer("Lyndon B. Johnson",2, 15);

            addAnswer("Athens",1, 16);
            addAnswer("Sparta",1, 16);
            addAnswer("Corinth",2, 16);
            addAnswer("Thebes",1, 16);
            addAnswer("Eretria",2, 16);
            addAnswer("Chalcis",2, 16);
            addAnswer("Syracuse",2, 16);
            addAnswer("Massalia",5, 16);
            addAnswer("Taras",5, 16);
            addAnswer("Macedonia",1, 16);

            addAnswer("Russia","Russian Federation",1, 17);
            addAnswer("France","French Empire",1, 17);
            addAnswer("British Empire","England",1, 17);
            addAnswer("Serbia",2, 17);
            addAnswer("Belgium",2, 17);
            addAnswer("Luxemburg",2, 17);
            addAnswer("Italy",2, 17);
            addAnswer("Japan",5, 17);
            addAnswer("Greece","Hellas",2, 17);
            addAnswer("United States","USA",1, 17);

            addAnswer("Augustus",1, 18);
            addAnswer("Tiberius",1, 18);
            addAnswer("Caligula",1, 18);
            addAnswer("Claudius",2, 18);
            addAnswer("Nero",2, 18);
            addAnswer("Galba",5, 18);
            addAnswer("Otho",2, 18);
            addAnswer("Vespasian",5, 18);
            addAnswer("Titus",2, 18);
            addAnswer("Domitian",2, 18);

            addAnswer("Elamite Empire",5, 19);
            addAnswer("Kingdom of Kush",5, 19);
            addAnswer("Byzantine Empire",1, 19);
            addAnswer("Assyria",1, 19);
            addAnswer("Republic of Venice",1, 19);
            addAnswer("Ghana Empire",2, 19);
            addAnswer("Holy Roman Empire",2, 19);
            addAnswer("Ethiopian Empire",1, 19);
            addAnswer("Zhou dynasty",2, 19);
            addAnswer("Aksumite Empire",5, 19);

            addAnswer("Tower","Case",1, 20);
            addAnswer("PSU",2, 20);
            addAnswer("CPU","Processor",1, 20);
            addAnswer("GPU","Graphics Card",1, 20);
            addAnswer("SSD","HDD",1, 20);
            addAnswer("RAM","MEMORY",1, 20);
            addAnswer("Motherboard",1, 20);
            addAnswer("CPU Cooler",2, 20);
            addAnswer("Fans","Fan",2, 20);
            addAnswer("Optical Disc Drive","Drive",5, 20);

            addAnswer("Corsair",1, 21);
            addAnswer("Coolermaster",1, 21);
            addAnswer("NZXT",1, 21);
            addAnswer("Cougar",1, 21);
            addAnswer("Be Quiet",2, 21);
            addAnswer("EVGA",2, 21);
            addAnswer("BitFenix",2, 21);
            addAnswer("Azza",5, 21);
            addAnswer("Deepcool",2, 21);
            addAnswer("Sharkoon",1, 21);

            addAnswer("Xiaomi",1, 22);
            addAnswer("Samsung",1, 22);
            addAnswer("Huawei",1, 22);
            addAnswer("Realme",2, 22);
            addAnswer("Nokia",1, 22);
            addAnswer("Apple",1, 22);
            addAnswer("OnePlus",1, 22);
            addAnswer("Alcatel",2, 22);
            addAnswer("LG",2, 22);
            addAnswer("MLS",5, 22);

            addAnswer("WhatsApp",1, 23);
            addAnswer("Messenger",1, 23);
            addAnswer("Facebook",2, 23);
            addAnswer("Instagram",1, 23);
            addAnswer("LinkedIn",2, 23);
            addAnswer("Telegram",1, 23);
            addAnswer("Slack",2, 23);
            addAnswer("Discord",5, 23);
            addAnswer("Snapchat",1, 23);
            addAnswer("Viber",1, 23);

            addAnswer("Electronic Arts","EA",1, 24);
            addAnswer("Nintendo",1, 24);
            addAnswer("Ubisoft",1, 24);
            addAnswer("Naughty Dog","Sony",2, 24);
            addAnswer("Activision",1, 24);
            addAnswer("Epic Games",1, 24);
            addAnswer("Square Enix",2, 24);
            addAnswer("CD Project Red",5, 24);
            addAnswer("Quantum Dream",5, 24);
            addAnswer("Riot Games","Rito Gems",2, 24);

        }

        //This is used to set the answers for the questions without a backup answer
        static void addAnswer(String a, int points, int index)
        {
            addAnswer(a, "NA", points, index);
        }

        //Sets the double answer to a question
        static void addAnswer(String a, String b, int points, int index)
        {
            Questions[index].Answers.Add(new Answer(a, b, points));
        }


        //Creates the Questions and it adds them to the Binding List
        private static void addQuestions()
        {
            Questions.Add(new Question("Name 10 countries of the Balkan Peninsula", 1));
            Questions.Add(new Question("Name the 10 most northern Europe countries", 1));
            Questions.Add(new Question("Name the 10 most western US States", 1));
            Questions.Add(new Question("Which are the 10 most populated countries in the world", 1));
            Questions.Add(new Question("Which are the 10 richest countries by gdp/capita in Asia", 1));
            Questions.Add(new Question("List the 10 movies directed by Quentin Tarantino", 2));
            Questions.Add(new Question("Write 10 o the main actors that star in the " +
                "movie “Avengers: Endgame”", 2));
            Questions.Add(new Question("What are the latest 10 films (as of 2020) directed by " +
                "Martin Scorsese (including “the”)", 2));
            Questions.Add(new Question("Name 10 movies that star Actress “Emma Stone” " +
                "(including “the”)", 2));
            Questions.Add(new Question("Name 10 movies produced by the company named: “A24” " +
                "(including “the”)", 2));
            Questions.Add(new Question("Name 10 things that can be found on a desk", 3));
            Questions.Add(new Question("Name 10 stores/services that each human will visit " +
                "in a long-term", 3));
            Questions.Add(new Question("What are the most common American Male Names (as of 2014)", 3));
            Questions.Add(new Question("10 stuff and appliances that can be found on a bathroom", 3));
            Questions.Add(new Question("Name 10 means of transportation around the city", 3));
            Questions.Add(new Question("Who are the past 10 American Presidents (as of 2019)", 4));
            Questions.Add(new Question("Name 10 of the most important city states of " +
                "Ancient Greece", 4));
            Questions.Add(new Question("Name the allied countries of the first world war", 4));
            Questions.Add(new Question("Name 10 emperors of the Roman Empire (27 BC --> 96)", 4));
            Questions.Add(new Question("What are the 10 longest lasting empires", 4));
            Questions.Add(new Question("Name 10 parts that can be part of a full PC", 5));
            Questions.Add(new Question("Name 10 companies that manufacture PC Cases", 5));
            Questions.Add(new Question("Name 10 smartphone brands", 5));
            Questions.Add(new Question("Write down 10 applications that support messaging " +
                "between two users.", 5));
            Questions.Add(new Question("Write down the 10 most successful gaming companies.", 5));
        }
    }
}
