using Newtonsoft.Json;
using OOPLib.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib
{
    public class Repository
    {
        private static string PATH = "../../../";
        private static string SETTINGS_PATH = PATH + "settings.txt";
        private static string FAVORITETEAM_PATH = PATH + "favoriteteam.txt";

        private static string PICKED_CHAMPIONSHIP;
        private static string PICKED_LANGUAGE;
        private static string PICKED_FAVORITE_TEAM;
        private static string PICKED_FIFA_CODE;

        private static string MALE_CHAMPIONSHIP_URL = "https://world-cup-json-2018.herokuapp.com/teams/results";
        private static string FEMALE_CHAMPIONSHIP_URL = "http://worldcup.sfg.io/teams/results"; // ZA VRIJEME PISANJA PROJEKTA LINK NE RADI PA SE KORISTI FILE

        private static string MALE_CHAMPIONSHIP_FILE = PATH + "JsonData/men/";
        private static string FEMALE_CHAMPIONSHIP_FILE = PATH + "JsonData/women/";

        public static void SaveFavoriteTeam(Team favoriteTeam)
        {
            PICKED_FAVORITE_TEAM = favoriteTeam.Country;
            PICKED_FIFA_CODE = favoriteTeam.FifaCode;
            using(StreamWriter writter = new StreamWriter(FAVORITETEAM_PATH))
            {
                writter.Write(favoriteTeam);
            }
        }

        public static void SaveSettings(SettingsModel settings)
        {
            using (StreamWriter writter = new StreamWriter(SETTINGS_PATH))
            {
                writter.Write(settings.Championship);
                writter.Write(Environment.NewLine);
                writter.Write(settings.Language);
            }
            PICKED_CHAMPIONSHIP = settings.Championship;
            PICKED_LANGUAGE = settings.Language;
        }

        private static void LoadSettings()
        {
            using (StreamReader reader = new StreamReader(SETTINGS_PATH))
            {
                List<string> settings = new List<string>();
                while (!reader.EndOfStream)
                {
                    settings.Add(reader.ReadLine());
                }
                PICKED_CHAMPIONSHIP = settings[0];
                PICKED_LANGUAGE = settings[1];
            }
        }

        //FavoriteTeam
        public static async Task<List<Team>> GetTeam()
        {
            LoadSettings();
            string pickedPath;

            if (PICKED_CHAMPIONSHIP == "Male")
            {
                pickedPath = MALE_CHAMPIONSHIP_URL;
            }
            else
            {
                pickedPath = FEMALE_CHAMPIONSHIP_URL;
            }

            RestResponse<Team> restResponse = await GetTeamData(pickedPath);
            List<Team> teams = DeserialiseData(restResponse);
            return teams;
        }

        private static Task<RestResponse<Team>> GetTeamData(string pickedPath)
        {
            RestClient restClient = new RestClient(pickedPath);
            return restClient.ExecuteAsync<Team>(new RestRequest());
        }

        public static async Task<List<Match>> GetMatch()
        {
            string pickedPath;

            if (PICKED_CHAMPIONSHIP == "Male")
            {
                pickedPath= "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
            }
            else
            {
                pickedPath = "http://worldcup.sfg.io/matches/country?fifa_code=";
            }

            RestResponse<Match> restResponse = await GetMatchData(pickedPath + PICKED_FIFA_CODE);
            List<Match> matches = DeserialiseData(restResponse);
            return matches;
        }

        private static Task<RestResponse<Match>> GetMatchData(string pickedMatch)
        {
            RestClient restClient = new RestClient(pickedMatch);
            return restClient.ExecuteAsync<Match>(new RestRequest());
        }



        private static List<T> DeserialiseData<T>(RestResponse<T> restResponse)
        {
            return (List<T>)JsonConvert.DeserializeObject(restResponse.Content, typeof(List<T>), new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
