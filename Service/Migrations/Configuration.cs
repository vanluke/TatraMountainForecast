using System.Collections.Generic;
using Model.Implementation;
using Newtonsoft.Json;

namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    internal sealed class Configuration : DbMigrationsConfiguration<Service.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //if (System.Diagnostics.Debugger.IsAttached == false)
            //    System.Diagnostics.Debugger.Launch();
        }

        protected override void Seed(Service.ApplicationContext context)
        {
            //--  This method will be called after migrating to the latest version.

            //--  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //--  to avoid creating duplicate seed data. E.g.
            var cityPossitions = new List<CityPossition>()
            {
                new CityPossition("Augustow", "53,51", "23"),
                new CityPossition("Auschwitz-Oswiecim", "50,02", "19,11"),
                new CityPossition("Biala Podxlaska", "52,04", "23,06"),
                new CityPossition("Bialogard", "54,02", "15,58"),
                new CityPossition("Bialystok", "53,1", "23,1"),
                new CityPossition("Bielsk Podlaski", "52,47", "23,12"),
                new CityPossition("Bielsko-Biata", "49,5", "19,02"),
                new CityPossition("Bobr", "52,04", "15,04"),
                new CityPossition("Bochnia", "49,58", "20,27"),
                new CityPossition("Boleslawiec", "51,17", "15,337"),
                new CityPossition("Braniewo", "54,25", "19,5"),
                new CityPossition("Breslau-Wroclaw", "51,05", "17,05"),
                new CityPossition("Brodnica", "53,15", "19,25"),
                new CityPossition("Bug", "52,31", "21,05"),
                new CityPossition("Bydgoszcz", "53,1", "18"),
                new CityPossition("Bytom", "50,25", "18,54"),
                new CityPossition("Bytow", "54,1", "17,3"),
                new CityPossition("Chelm", "51,08", "23,3"),
                new CityPossition("Chelmno", "53,2", "18,3"),
                new CityPossition("Chojnice", "53,42", "17,32"),
                new CityPossition("Chorzow", "50,18", "18,57"),
                new CityPossition("Choszczno", "53,07", "15,25"),
                new CityPossition("Ciechanow", "52,52", "20,38"),
                new CityPossition("Cieszyn", "49,45", "18,35"),
                new CityPossition("Cracow-Krakow", "50,04", "19,57"),
                new CityPossition("Czestochowa", "50,49", "19,07"),
                new CityPossition("Danzing-Gdansk", "54,22", "18,4"),
                new CityPossition("Darlowo", "54,25", "16,25"),
                new CityPossition("Debica", "50,02", "21,25"),
                new CityPossition("Dzialdowo", "53,15", "20,15"),
                new CityPossition("Dzierzonio", "50,45", "16,39"),
                new CityPossition("Elbing-Elblag", "54,1", "19,25"),
                new CityPossition("Elbalag", "54,1", "19,25"),
                new CityPossition("Elk", "53,5", "22,21"),
                new CityPossition("Gdansk", "54,22", "18,4"),
                new CityPossition("Gdanska, Zatoka", "54,3", "19,2"),
                new CityPossition("Gdynia", "54,35", "18,33"),
                new CityPossition("Gizycko", "54,02", "21,48"),
                new CityPossition("Gliwice", "50,22", "18,41"),
                new CityPossition("Glogow", "51,37", "16,05"),
                new CityPossition("Gniezno", "52,3", "17,35"),
                new CityPossition("Goleniow", "53,35", "14,5"),
                new CityPossition("Gorzow Wielkopolski", "52,43", "15,15"),
                new CityPossition("Grojec", "51,5", "20,58"),
                new CityPossition("Grudziadz", "53,3", "18,47"),
                new CityPossition("Hajnowka", "52,47", "23,35"),
                new CityPossition("Ilawa", "53,36", "19,34"),
                new CityPossition("Inowroclaw", "52,5", "18,12"),
                new CityPossition("Jaroslaw", "50,02", "22,42"),
                new CityPossition("Jaslo", "49,45", "21,3"),
                new CityPossition("Jedrzejow", "50,35", "20,15"),
                new CityPossition("Jelenia Gora", "50,5", "15,45"),
                new CityPossition("Kalisz", "51,45", "18,08"),
                new CityPossition("Katowice", "50,17", "19,05"),
                new CityPossition("Ketrzyn", "54,07", "21,22"),
                new CityPossition("Kielce", "50,52", "20,42"),
                new CityPossition("Klodzko", "50,28", "16,38"),
                new CityPossition("Kluczbork", "50,58", "18,12"),
                new CityPossition("Kolo", "52,14", "18,4"),
                new CityPossition("Kolobrzeg", "54,1", "15,35"),
                new CityPossition("Konin", "52,12", "18,15"),
                new CityPossition("Konskie", "51,15", "20,23"),
                new CityPossition("Koscian", "52,05", "16,4"),
                new CityPossition("Kostrzyn", "52,35", "14,39"),
                new CityPossition("Koszalin", "54,11", "16,08"),
                new CityPossition("Krakow", "50,04", "19,57"),
                new CityPossition("Krasnik", "50,55", "22,15"),
                new CityPossition("Krosno", "49,42", "21,46"),
                new CityPossition("Krotoszyn", "51,42", "17,23"),
                new CityPossition("Kutno", "52,15", "19,23"),
                new CityPossition("Kwidzyn", "53,44", "18,55"),
                new CityPossition("Lebork", "54,33", "17,46"),
                new CityPossition("Leczyca", "52,05", "19,15"),
                new CityPossition("Legionowo", "43,33", "10,19"),
                new CityPossition("Legnica", "45,11", "11,18"),
                new CityPossition("Leszno", "51,5", "16,3"),
                new CityPossition("Liegnitz,Legnica", "51,12", "16,1"),
                new CityPossition("Lodz", "51,45", "19,27"),
                new CityPossition("Lomza", "53,1", "22,02"),
                new CityPossition("Lowicz", "52,06", "19,55"),
                new CityPossition("Lubin", "51,24", "16,11"),
                new CityPossition("Lukow", "51,55", "22,23"),
                new CityPossition("Lyna", "54,37", "21,14"),
                new CityPossition("Malbork", "54,0", "19,01"),
                new CityPossition("Mazurski Pojezierze", "53,5", "21"),
                new CityPossition("Miedzychod", "52,35", "15,53"),
                new CityPossition("Miedzyrzec Podlaski", "51,58", "22,45"),
                new CityPossition("Mielec", "50,15", "21,25"),
                new CityPossition("Minsk Mazowiecki", "52,1", "74,58"),
                new CityPossition("Mlawa", "53,09", "20,25"),
                new CityPossition("Myskow", "50,45", "19,22"),
                new CityPossition("Narew", "52,26", "20,41"),
                new CityPossition("Nesterov", "50,04", "23,58"),
                new CityPossition("Notec", "52,44", "15,26"),
                new CityPossition("Nowa Sol", "51,48", "15,44"),
                new CityPossition("Nowy Sacz", "49,4", "20,41"),
                new CityPossition("Nowy Targ", "49,29", "20,02"),
                new CityPossition("Nowy Tomysi", "52,19", "16,1"),
                new CityPossition("Nysa", "50,3", "17,22"),
                new CityPossition("Olawa", "50,57", "17,2"),
                new CityPossition("Olesnica", "51,13", "17,22"),
                new CityPossition("Olsztyn", "53,48", "20,29"),
                new CityPossition("Opole", "50,42", "17,58"),
                new CityPossition("Ostroda", "53,42", "19,58"),
                new CityPossition("Ostroleka", "53,04", "21,32"),
                new CityPossition("Ostrow Mazowiecka", "52,5", "21,51"),
                new CityPossition("Ostrow Wielkopolski", "51,36", "17,44"),
                new CityPossition("Ostrowiec-swietokrzyski", "50,55", "21,22"),
                new CityPossition("Oswiecim", "50,02", "19,11"),
                new CityPossition("Otwock", "52,05", "21,2"),
                new CityPossition("Pabianice", "51,4", "19,2"),
                new CityPossition("Pila", "53,1", "16,48"),
                new CityPossition("Pilica", "51,52", "21,17"),
                new CityPossition("Pinczow", "50,32", "20,32"),
                new CityPossition("Piotrkow Trybunalski", "51,23", "19,43"),
                new CityPossition("Plock", "52,32", "19,4"),
                new CityPossition("Police", "53,33", "14,33"),
                new CityPossition("Pomorskie, Pojezierze", "53,4", "16,37"),
                new CityPossition("Poznan", "52,25", "16,55"),
                new CityPossition("Prosna", "52,06", "17,44"),
                new CityPossition("Pruszkow", "52,09", "20,49"),
                new CityPossition("Przemysl", "49,5", "22,45"),
                new CityPossition("Pulawy", "51,23", "21,59"),
                new CityPossition("Pultusk", "52,43", "21,06"),
                new CityPossition("Raciborz", "50,07", "18,18"),
                new CityPossition("Radom", "51,23", "21,12"),
                new CityPossition("Radomsko", "51,05", "19,28"),
                new CityPossition("Ratibor-Raciborz", "50,07", "18,18"),
                new CityPossition("Rava-Ruska", "50,15", "23,42"),
                new CityPossition("Rava Russkaya-Rava-Ruska", "50,15", "23,42"),
                new CityPossition("Rumia", "54,37", "18,25"),
                new CityPossition("Rypin", "53,3", "19,25"),
                new CityPossition("San", "50,45", "21,51"),
                new CityPossition("Sandomierz", "50,4", "21,43"),
                new CityPossition("Sanok", "49,35", "22,1"),
                new CityPossition("Silesia-Slask", "51", "16,3"),
                new CityPossition("Slask", "51", "16,3"),
                new CityPossition("Slupsk", "54,3", "17,3"),
                new CityPossition("Sokolka", "53,25", "23,3"),
                new CityPossition("Sopot", "54,27", "18,31"),
                new CityPossition("Sosnowiec", "50,2", "19,1"),
                new CityPossition("Srem", "52,6", "17,2"),
                new CityPossition("Suwalki", "54,8", "22,59"),
                new CityPossition("Swidnica", "50,5", "16,3"),
                new CityPossition("Swidnik", "52,15", "15,31"),
                new CityPossition("Swiecie", "53,25", "18,3"),
                new CityPossition("Swinoujscie", "53,54", "14,16"),
                new CityPossition("Szczecin", "53,27", "14,27"),
                new CityPossition("Szczytno", "53,33", "21"),
                new CityPossition("Tarnow", "50,3", "21"),
                new CityPossition("Tczew", "54,8", "18,5"),
                new CityPossition("Torun", "53,2", "18,39"),
                new CityPossition("Turek", "52,3", "18,3"),
                new CityPossition("Tychy", "50,9", "18,59"),
                new CityPossition("Vistula-Wisla", "54,22", "18,55"),
                new CityPossition("Walbrzych", "50,45", "16,18"),
                new CityPossition("Walcz", "53,17", "16,27"),
                new CityPossition("Warsaw-Warszawa", "52,13", "21"),
                new CityPossition("Warta", "52,5", "14,39"),
                new CityPossition("Wejherowo", "54,35", "18,12"),
                new CityPossition("Wisla", "54,22", "18,55"),
                new CityPossition("Wkra", "52,27", "20,44"),
                new CityPossition("Wloclawek", "51,33", "23,31"),
                new CityPossition("Wolin", "53,5", "14,37"),
                new CityPossition("Wroclaw", "51,5", "17,5"),
                new CityPossition("Wrzesnia", "51,5", "17,5"),
                new CityPossition("Zabrze", "50,18", "18,5"),
                new CityPossition("Zagari", "51,39", "15,22"),
                new CityPossition("Zagan", "51,39", "15,22"),
                new CityPossition("Zakopane", "49,18", "19,57"),
                new CityPossition("Zary", "51,37", "15,1"),
                new CityPossition("Zawiercie", "50,3", "19,24"),
                new CityPossition("Zdunska Wola", "51,37", "18,59"),
                new CityPossition("Zgorzelec", "51,1", "15"),
                new CityPossition("Zyrardow", "52,3", "20,28"),
                new CityPossition("Zywiec", "49,42", "19,1")
            };

            cityPossitions.ForEach(v =>
            {
                v.Latitude = v.Latitude.Replace(",", ".");
                v.Longitude = v.Longitude.Replace(",", ".");
            });

           // context.CityPossitions.AddRange(cityPossitions);
           

            var weatherSeed = File.ReadAllText(@"D:\New folder\TAi\TatraMountainForecase\Service\Seed\weather_seed.json");

            var weatherData = JsonConvert.DeserializeObject<WeatherContainer>(weatherSeed);

            if (weatherData != null)
            {
                context.Weathers.Add(weatherData);
            }

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
