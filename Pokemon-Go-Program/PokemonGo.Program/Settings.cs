using PokemonGo.RocketAPI;
using System;
using PokemonGo.RocketAPI.Enums;

namespace PokemonGo.Program
{
    class Settings : ISettings
    {
        public AuthType AuthType
        {
            get
            {
                return (AuthType) Enum.Parse(typeof(AuthType), UserSettings.Default.AuthType, true);
            }

            set
            {
                UserSettings.Default.AuthType = value.ToString();
            }
        }

        public double DefaultAltitude
        {
            get
            {
                return UserSettings.Default.DefaultAltitude;
            }

            set
            {
                UserSettings.Default.DefaultAltitude = value;
            }
        }

        public double DefaultLatitude
        {
            get
            {
                return UserSettings.Default.DefaultLatitude;
            }

            set
            {
                UserSettings.Default.DefaultLatitude = value;
            }
        }

        public double DefaultLongitude
        {
            get
            {
                return UserSettings.Default.DefaultLongitude;
            }

            set
            {
                UserSettings.Default.DefaultLongitude = value;
            }
        }

        public string GoogleUsername
        {
            get
            {
                return UserSettings.Default.GoogleUsername;
            }

            set
            {
                UserSettings.Default.GoogleUsername = value;
            }
        }

        public string GooglePassword
        {
            get
            {
                return UserSettings.Default.GooglePassword;
            }

            set
            {
                UserSettings.Default.GooglePassword = value;
            }
        }

        public string GoogleRefreshToken
        {
            get
            {
                return UserSettings.Default.GoogleRefreshToken;
            }

            set
            {
                UserSettings.Default.GoogleRefreshToken = value;
            }
        }

        public string PtcUsername
        {
            get
            {
                return UserSettings.Default.PtcUsername;
            }

            set
            {
                UserSettings.Default.PtcUsername = value;
            }
        }

        public string PtcPassword
        {
            get
            {
                return UserSettings.Default.PtcPassword;
            }

            set
            {
                UserSettings.Default.PtcPassword = value;
            }
        }
    }
}
