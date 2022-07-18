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
        private static string FAVORITEPLAYERS_PATH = PATH + "favoriteplayers.txt";

        private static string PICKED_CHAMPIONSHIP;

        private static string PICKED_LANGUAGE;
        private static string PICKED_FAVORITE_TEAM;
        private static string PICKED_FIFA_CODE;

        private static string MALE_CHAMPIONSHIP_URL = "https://world-cup-json-2018.herokuapp.com/teams/results";
        private static string FEMALE_CHAMPIONSHIP_URL = "http://worldcup.sfg.io/teams/results";

        //private static string FEMALE_MATCH_DETAILS_URL = "https://worldcup.sfg.io/matches/country?fifa_code="; 
        private static string FEMALE_MATCH_FILE = PATH + "JsonData/women/matches.json";
        private static string MALE_MATCH_DETAILS_URL = "https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";

        private static string MALE_CHAMPIONSHIP_FILE = PATH + "JsonData/men/";
        private static string FEMALE_CHAMPIONSHIP_FILE = PATH + "JsonData/women/";


        private static string WPF_PICKED_GENDER;
        private static string WPF_PICKED_LANGUAGE;
        private static string WPF_PICKED_SCREENSIZE;

        private static string WPF_FAVORITE_TEAM;

        private static string WPF_SETTINGS_PATH = PATH + "wpfsettings.txt";
        private static string WPF_FAVORITETEAM_PATH = PATH + "wpffavoriteteam.txt";

        //WPF
        public static void SaveWPFSettings(WPFSettings wPFSettings)
        {
            WPF_PICKED_GENDER = wPFSettings.selectedGender;
            WPF_PICKED_LANGUAGE = wPFSettings.selectedLanguage;
            WPF_PICKED_SCREENSIZE = wPFSettings.selectedScreenSize;

            using (StreamWriter writter = new StreamWriter(WPF_SETTINGS_PATH))
            {
                writter.WriteLine(WPF_PICKED_GENDER);
                writter.WriteLine(WPF_PICKED_LANGUAGE);
                writter.WriteLine(WPF_PICKED_SCREENSIZE);
            }

        }

        public static string GetWPFResolution()
        {
            using (StreamReader reader = new StreamReader(WPF_SETTINGS_PATH))
            {
                List<string> wpfsettings = new List<string>();

                while (!reader.EndOfStream)
                {
                    wpfsettings.Add(reader.ReadLine());
                }
                if (wpfsettings.Count > 0)
                {
                    WPF_PICKED_SCREENSIZE = wpfsettings[2];
                }
            }

            return WPF_PICKED_SCREENSIZE;
        }

        public static Task<HashSet<Match>> LoadMatches(string fifa_code)
        {
            if (WPF_PICKED_GENDER == "Male")
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(MALE_MATCH_DETAILS_URL + fifa_code);
                    var response = apiClient.Execute<HashSet<Match>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Match>>(response.Content);
                });
            }
            else
            {
                return Task.Run(() =>
                {
                    using (StreamReader reader = new StreamReader(FEMALE_MATCH_FILE))
                    {
                        string json = reader.ReadToEnd();
                        return JsonConvert.DeserializeObject<HashSet<Match>>(json);
                    }
                });
            }
        }

        public static void SaveWPFFavoriteTeam(WPFSettings wPFSettings)
        {
            WPF_FAVORITE_TEAM = wPFSettings.favoriteTeam;

            using (StreamWriter writter = new StreamWriter(WPF_FAVORITETEAM_PATH))
            {
                writter.WriteLine(WPF_FAVORITE_TEAM);
            }

        }

        public static void LoadWPFSettings()
        {
            List<string> wpfsettings = new List<string>();
            using (StreamReader reader = new StreamReader(WPF_SETTINGS_PATH))
            {
                while (!reader.EndOfStream)
                {
                    wpfsettings.Add(reader.ReadLine());
                }
                if (wpfsettings.Count > 0)
                {
                    WPF_PICKED_GENDER = wpfsettings[0];
                    WPF_PICKED_LANGUAGE = wpfsettings[1];
                    WPF_PICKED_SCREENSIZE = wpfsettings[2];
                }
            }
        }

        public static Task<HashSet<Result>> LoadMatchResults()
        {
            LoadWPFSettings();

            if (WPF_PICKED_GENDER == "Male")
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(MALE_CHAMPIONSHIP_URL);
                    var response = apiClient.Execute<HashSet<Result>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Result>>(response.Content);
                });
            }
            else
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(FEMALE_CHAMPIONSHIP_URL);
                    var response = apiClient.Execute<HashSet<Result>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Result>>(response.Content);
                });
            }
        }

        //WIN FORM

        public static void SaveFavoriteTeam(Team favoriteTeam)
        {
            PICKED_FAVORITE_TEAM = favoriteTeam.Country;
            PICKED_FIFA_CODE = favoriteTeam.FifaCode;
            using (StreamWriter writter = new StreamWriter(FAVORITETEAM_PATH))
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
        public static void SaveFavoritePlayers(List<string> favorites)
        {
            using (StreamWriter writter = new StreamWriter(FAVORITEPLAYERS_PATH))
            {
                foreach (string favorite in favorites)
                {
                    writter.Write(favorite);
                    writter.Write(Environment.NewLine);
                }
            }
        }
        public static char LoadSettings()
        {
            if (!File.Exists(SETTINGS_PATH))
            {
                File.AppendAllText(SETTINGS_PATH, "");

            }
            if (!File.Exists(FAVORITETEAM_PATH))
            {
                File.AppendAllText(FAVORITETEAM_PATH, "");
            }

            List<string> settings = new List<string>();
            if (String.IsNullOrEmpty(PICKED_CHAMPIONSHIP) || String.IsNullOrEmpty(PICKED_LANGUAGE))
            {
                using (StreamReader reader = new StreamReader(SETTINGS_PATH))
                {
                    while (!reader.EndOfStream)
                    {
                        settings.Add(reader.ReadLine());
                    }
                    if (settings.Count > 0)
                    {
                        PICKED_CHAMPIONSHIP = settings[0];
                        PICKED_LANGUAGE = settings[1];
                    }
                }
            }
            if (String.IsNullOrEmpty(PICKED_FIFA_CODE))
            {
                List<string> info = new List<string>();
                using (StreamReader reader = new StreamReader(FAVORITETEAM_PATH))
                {
                    while (!reader.EndOfStream)
                    {
                        info.Add(reader.ReadLine());
                    }
                }

                if (info.Count != 0)
                {
                    string[] details = info[0].Split('(');
                    string code = details[1].Substring(0, 3);
                    PICKED_FIFA_CODE = code;
                }
            }

            if (PICKED_CHAMPIONSHIP == null || PICKED_LANGUAGE == null)
            {
                return 's';
            }

            if (String.IsNullOrEmpty(PICKED_FIFA_CODE))
            {
                return 'f';
            }
            else
            {
                return 'a';
            }
        }
        public static List<string> LoadFavorites()
        {
            if (!File.Exists(FAVORITEPLAYERS_PATH))
            {
                File.AppendAllText(FAVORITEPLAYERS_PATH, "");
            }

            List<string> favorites = new List<string>();
            using (StreamReader reader = new StreamReader(FAVORITEPLAYERS_PATH))
            {
                while (!reader.EndOfStream)
                {
                    favorites.Add(reader.ReadLine());
                }
            }
            return favorites;
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
                pickedPath = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
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
