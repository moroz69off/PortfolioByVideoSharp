using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework.XamlTypes;

namespace MrzFastDoIt
{
    public class BindSetting
    {
        private string[] iniList = File.ReadAllLines("accounts.ini", Encoding.UTF8);
        List<string> iniAccouns = new List<string>();

        public string accountEmail { get; set; }
        public string accountPassw { get; set; }
        public string accountNamee { get; set; }
        public string accountMName { get; set; }
        public string accountSName { get; set; }
        public string accontCrdNum { get; set; }
        public string cardMonVdate { get; set; }
        public string cardYeaVdate { get; set; }
        public string accontCrdCsv { get; set; }
        public string releaceDateT { get; set; }

        public BindSetting()
        {
            foreach (string acc in iniList)
            {
                string[] array = acc.Split(separator: new char[] { ',' });
                iniAccouns.Add(array[array.Length - 1].Replace("profileName: ", ""));
            }
        }

        internal void AppendIniFile(string newString)
        {
            File.AppendAllText("accounts.ini", newString);
        }

        internal string[] GetProfiles()
        {
            return iniAccouns.ToArray();
        }

        internal string[] GetProfileData(string itemText)
        {
            string[] selectedData = new string[10];
            foreach (var line in iniList)
            {
                if (line.Contains(itemText)) selectedData = line.Split(new string[] { ", " }, 10, StringSplitOptions.None);
            }

            accountEmail = selectedData[0];
            accountPassw = selectedData[1];
            accountNamee = selectedData[2];
            accountMName = selectedData[3];
            accountSName = selectedData[4];
            accontCrdNum = selectedData[5];
            cardMonVdate = selectedData[6];
            cardYeaVdate = selectedData[7];
            accontCrdCsv = selectedData[8];
            releaceDateT = selectedData[9];


            return selectedData;
        }
    }
}
