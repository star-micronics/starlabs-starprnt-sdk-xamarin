using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using StarIoWrapper;

namespace XamarinSDK
{
    class Configuration
    {
        public static string PortName
        {
            get
            {
                try
                {
                    return Application.Current.Properties["PortName"] as string;
                }
                catch
                {
                }

                return "";
            }

            set
            {
                Application.Current.Properties["PortName"] = value;

                Application.Current.SavePropertiesAsync();
            }
        }

        public static string ModelName
        {
            get
            {
                try
                {
                    return Application.Current.Properties["ModelName"] as string;
                }
                catch
                {
                }

                return "";
            }

            set
            {
                Application.Current.Properties["ModelName"] = value;

                Application.Current.SavePropertiesAsync();
            }
        }

        public static string MacAddress
        {
            get
            {
                try
                {
                    return Application.Current.Properties["MacAddress"] as string;
                }
                catch
                {
                }

                return "";
            }

            set
            {
                Application.Current.Properties["MacAddress"] = value;

                Application.Current.SavePropertiesAsync();
            }
        }

        public static string PortSettings
        {
            get
            {
                try
                {
                    return Application.Current.Properties["PortSettings"] as string;
                }
                catch
                {
                }

                return "";
            }

            set
            {
                Application.Current.Properties["PortSettings"] = value;

                Application.Current.SavePropertiesAsync();
            }
        }

        public static StarIoExtEmulation Emulation
        {
            get
            {
                try
                {
                    return (StarIoExtEmulation) Enum.Parse(typeof(StarIoExtEmulation), Application.Current.Properties["Emulation"] as string);
                }
                catch
                {
                }

//              return StarIoExtEmulation.None;
                return StarIoExtEmulation.StarPRNT;
            }

            set
            {
                Application.Current.Properties["Emulation"] = value.ToString();

                Application.Current.SavePropertiesAsync();
            }
        }

        public static bool CashDrawerOpenActiveHigh
        {
            get
            {
                try
                {
                    return bool.Parse(Application.Current.Properties["CashDrawerOpenActiveHigh"] as string);
                }
                catch
                {
                }

                return true;
            }

            set
            {
                Application.Current.Properties["CashDrawerOpenActiveHigh"] = value.ToString();

                Application.Current.SavePropertiesAsync();
            }
        }
    }
}
