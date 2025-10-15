using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace InvestWF.Api
{
    internal static class Config
    {
        internal static string ReadConfig(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();
        }
    }
}
