using System;
using System.IO;
using System.Text;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Easy_Weather
{
    public class Weather_Info
    {

        public string userLoc { set; get; }

        public Form1 myForm;

        public void generate(Form1 passedForm)
        {
            myForm = passedForm;
            string userString = userZip(userLoc);
            makeWeatherDir();
            loadWeatherData(userString);
            readAndPrintData(myForm);

        }

        public void readAndPrintData(Form1 passedForm)
        {
            FileStream fs = File.OpenRead("C:\\Weather_Data\\Weather_Data.txt");
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string resultsString = (sr.ReadToEnd());
            //Console.WriteLine(resultsString);
            if(passedForm.results == "")
            {
                passedForm.results = resultsString;
            }
            
        }

        public string fixSpaceString(string withSpaces)
        {
            string stillSpaced = withSpaces;

            string spaceLess = stillSpaced.Replace(' ', '_');

            return spaceLess;
        }

        public string userZip(string passedZip)
        {
            string enteredZip = passedZip;
            int userNo = 0;
            bool isvalid = int.TryParse(passedZip, out userNo);

            if(userNo == 0)
            {
                string fixedLoc = fixSpaceString(enteredZip);
                return fixedLoc;
            }
            


            return enteredZip;
        }

        public void makeWeatherDir()
        {
            string path = "C:\\Weather_Data";

            try
            {

                if (Directory.Exists(path))
                {
                    return;
                }

                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to create weather directory, please check permissions, run as admin, or try again");
            }
        }

        public void loadWeatherData(string useMyZip)
        {
            try
            {
                string givenZip = useMyZip;
                var client = new RestClient("https://weather.visualcrossing.com/VisualCrossingWebServices/rest/");
                var request = new RestRequest("services/timeline/" + givenZip + "/today?unitGroup=us&key=P4Y4KKVUX3NHKDLSMRH3JDABD&options=nonulls&include=current");
                var query = client.Execute(request);

                var myWeather = JsonConvert.DeserializeObject<Root>(query.Content);





                var curCondMy = myWeather.currentConditions;
                var dayCon = myWeather.days;
                Day specDay = dayCon.ElementAt(0);



                using (StreamWriter sw = new StreamWriter("C:\\Weather_Data\\Weather_Data.txt"))
                {
                    sw.WriteLine("");
                    sw.WriteLine("====================================================");
                    sw.WriteLine(DateTime.Now.ToString("dddd MMM dd yyyy h:mm tt"));
                    sw.WriteLine("Current Weather for {0}", myWeather.resolvedAddress);
                    sw.WriteLine("Current temperature is {0} F", curCondMy.temp);
                    sw.WriteLine("Current Windspeed is {0} mph", curCondMy.windspeed);
                    sw.WriteLine("Current humidity is {0}%", curCondMy.humidity);
                    sw.WriteLine("The max temperature today is {0}, and the low temperature is {1}", specDay.tempmax, specDay.tempmin);
                    sw.WriteLine("====================================================");
                }
            }
            catch(Exception e)
            {
                myForm.results = "There was an error loading weather data, close the app and try again later";
            }

        }
        public class CurrentConditions
        {
            public double temp { get; set; }
            public double feelslike { get; set; }
            public double humidity { get; set; }
            public double windspeed { get; set; }

        }
        public class Day
        {
            public double tempmax { get; set; }
            public double tempmin { get; set; }
        }

        public class Root
        {
            public CurrentConditions currentConditions { get; set; }
            public List<Day> days { get; set; }

            public string resolvedAddress { get; set; }

        }
    }
}

