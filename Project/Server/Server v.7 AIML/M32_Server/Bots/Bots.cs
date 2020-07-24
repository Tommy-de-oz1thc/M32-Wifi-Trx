using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AIMLbot;
using QSO_Trainer.Lister;

namespace M32_Server.Bots
{
    public class Bots
    {
        private bool test_call = true;

        private static string _rst;
        private static string _callsign;
        private static string _name;
        private static string _qth;
        private static string _age;
        private static string _rig;
        private static string _ant;
        private static string _feet;
        private static string _occupation;
        private static string _watt;
        private static string _weather;
        private static string _work;
        private static string m32_rst = "";
        private static string m32_name = "";
        private static string m32_qth = "";
        private static string m32_age = "";
        private static string m32_rig = "";
        private static string m32_ant = "";
        private static string m32_watt = "";
        private static string m32_feet = "";
        private static string m32_work = "";
        private static string m32_weather = "";

        List<string> _botAnswer_no = new List<string>();
        List<string> _botAnswer_rst = new List<string>();
        List<string> _botAnswer_rst_name = new List<string>();
        List<string> _botAnswer_rst_name_qth = new List<string>();
        List<string> _botAnswer_rst_name_qth_age = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_ant = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_ant_feet = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather = new List<string>();
        List<string> _botAnswer_no_tx = new List<string>();
        List<string> _botAnswer_rst_tx = new List<string>();
        List<string> _botAnswer_rst_name_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_ant_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx = new List<string>();
        List<string> _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx = new List<string>();
        bool x_rst = false;
        bool x_name = false;
        bool x_qth = false;
        bool x_age = false;
        bool x_rig = false;
        bool x_watt = false;
        bool x_ant = false;
        bool x_feet = false;
        bool x_weather = false;
        bool x_work = false;

        private List<string[]> botListe = new List<string[]>();
        private string[] response = new string[2];

        string callsign;
        List<string> TxCall = TxCalls.TxCall;
        List<string> TxName = TxNames.TxName;
        List<string> Report = Reports.Report;
        List<string> City = Citys.City;
        List<string> State = States.State;
        List<string> Weather = Weathers.Weather;
        List<string> Age = Ages.Age;
        List<string> Watt = Watts.Watt;
        List<string> Rig = Rigs.Rig;
        List<string> Antenna = Antennas.Antenna;
        List<string> Occupation = Occupations.Occupation;
        List<string> Feet = Feets.Feet;



        Random rand = new Random();
        public string Bot_Answer(string say, string call)
        {
            Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput = false;

            User myuser = new User(call, AI);
            AI.isAcceptingUserInput = true;
            Request r = new Request(say, myuser, AI);
            Result res = AI.Chat(r);
            string answer = res.Output;
            return answer;

        }
        private void Load_Lister()
        {

            _botAnswer_no.Clear();
            _botAnswer_rst.Clear();
            _botAnswer_rst_name.Clear();
            _botAnswer_rst_name_qth.Clear();
            _botAnswer_rst_name_qth_age.Clear();
            _botAnswer_rst_name_qth_age_rig.Clear();
            _botAnswer_rst_name_qth_age_rig_watt.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_ant.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Clear();
            _botAnswer_no_tx.Clear();
            _botAnswer_rst_tx.Clear();
            _botAnswer_rst_name_tx.Clear();
            _botAnswer_rst_name_qth_tx.Clear();
            _botAnswer_rst_name_qth_age_tx.Clear();
            _botAnswer_rst_name_qth_age_rig_tx.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_tx.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Clear();
            _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Clear();
            if (test_call)
            {
                string tempText__no_00 = callsign + " ur rst is " + _rst + " " + _rst + " hw copy? " + callsign + " <kn>";
                _botAnswer_no.Add(tempText__no_00);
                _botAnswer_no_tx.Add("rst");
                string tempText_no_01 = callsign + " rst? " + callsign + " <kn> ";
                _botAnswer_no.Add(tempText_no_01);
                _botAnswer_no_tx.Add("no");

                string tempText_rst_00 = callsign + " op? " + callsign + " <kn> ";
                _botAnswer_rst.Add(tempText_rst_00);
                _botAnswer_rst_tx.Add("no");
                string tempText_rst_01 = callsign + " op? " + callsign + " <kn> ";
                _botAnswer_rst.Add(tempText_rst_01);
                _botAnswer_rst_tx.Add("no");
                string tempText_rst_02 = callsign + " name? " + callsign + " <kn> ";
                _botAnswer_rst.Add(tempText_rst_02);
                _botAnswer_rst_tx.Add("no");
                string tempText_rst_03 = callsign + " name hr is " + _name + " " + callsign + " <kn>";
                _botAnswer_rst.Add(tempText_rst_03);
                _botAnswer_rst_tx.Add("name");
                string tempText_rst_04 = callsign + " op hr is " + _name + " " + callsign + " <kn>";
                _botAnswer_rst.Add(tempText_rst_04);
                _botAnswer_rst_tx.Add("name");

                string tempText_rst_name_00 = callsign + " fb " + m32_name + " qth?  " + callsign + " <kn>";
                _botAnswer_rst_name.Add(tempText_rst_name_00);
                _botAnswer_rst_name_tx.Add("no");
                string tempText_rst_name_01 = callsign + " fb " + m32_name + " my qth is " + _qth + " " + callsign + " <kn>";
                _botAnswer_rst_name.Add(tempText_rst_name_01);
                _botAnswer_rst_name_tx.Add("qth");
                string tempText_rst_name_02 = callsign + " fb " + m32_name + " qth hr is " + _qth + " " + callsign + " <kn>";
                _botAnswer_rst_name.Add(tempText_rst_name_02);
                _botAnswer_rst_name_tx.Add("qth");

                string tempText_rst_name_qth_00 = callsign + " fb " + m32_name + " age? " + callsign + " <kn>";
                _botAnswer_rst_name_qth.Add(tempText_rst_name_qth_00);
                _botAnswer_rst_name_qth_tx.Add("no");
                string tempText_rst_name_qth_01 = callsign + " fb " + m32_name + " I am " + _age + " old " + callsign + " <kn>";
                _botAnswer_rst_name_qth.Add(tempText_rst_name_qth_01);
                _botAnswer_rst_name_qth_tx.Add("age");
                string tempText_rst_name_qth_02 = callsign + " fb " + m32_name + " my age is " + _age + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth.Add(tempText_rst_name_qth_02);
                _botAnswer_rst_name_qth_tx.Add("age");

                string tempText_rst_name_qth_age_00 = callsign + " fb " + m32_name + " rig? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age.Add(tempText_rst_name_qth_age_00);
                _botAnswer_rst_name_qth_age_tx.Add("no");
                string tempText_rst_name_qth_age_01 = callsign + " fb " + m32_name + " rig hr is " + _rig + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age.Add(tempText_rst_name_qth_age_01);
                _botAnswer_rst_name_qth_age_tx.Add("rig");
                string tempText_rst_name_qth_age_02 = callsign + " fb " + m32_name + " my rig is " + _rig + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age.Add(tempText_rst_name_qth_age_02);
                _botAnswer_rst_name_qth_age_tx.Add("rig");


                string tempText_rst_name_qth_age_rig_00 = callsign + " fb " + m32_name + " watt? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_00);
                _botAnswer_rst_name_qth_age_rig_tx.Add("no");
                string tempText_rst_name_qth_age_rig_01 = callsign + " fb " + m32_name + " what is ur pw? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_01);
                _botAnswer_rst_name_qth_age_rig_tx.Add("no");
                string tempText_rst_name_qth_age_rig_02 = callsign + " fb " + m32_name + " i am sending with " + _watt + " watt " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_02);
                _botAnswer_rst_name_qth_age_rig_tx.Add("watt");
                string tempText_rst_name_qth_age_rig_03 = callsign + " fb " + m32_name + " my pw is " + _watt + " watt " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_03);
                _botAnswer_rst_name_qth_age_rig_tx.Add("watt");

                string tempText_rst_name_qth_age_rig_watt_00 = callsign + " fb " + m32_name + " ant? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt.Add(tempText_rst_name_qth_age_rig_00);
                _botAnswer_rst_name_qth_age_rig_watt_tx.Add("no");
                string tempText_rst_name_qth_age_watt_rig_01 = callsign + " fb " + m32_name + " my ant is " + _ant + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt.Add(tempText_rst_name_qth_age_rig_01);
                _botAnswer_rst_name_qth_age_rig_watt_tx.Add("ant");
                string tempText_rst_name_qth_age_watt_rig_02 = callsign + " fb " + m32_name + " ant hr is " + _ant + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt.Add(tempText_rst_name_qth_age_rig_02);
                _botAnswer_rst_name_qth_age_rig_watt_tx.Add("ant");

                string tempText_rst_name_qth_age_rig_watt_ant_00 = callsign + " fb " + m32_name + " feet? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant.Add(tempText_rst_name_qth_age_rig_watt_ant_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_01 = callsign + " fb " + m32_name + " my ant is " + _feet + " feet up " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant.Add(tempText_rst_name_qth_age_rig_watt_ant_01);
                _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Add("feet");
                string tempText_rst_name_qth_age_rig_rig_watt_ant_02 = callsign + " fb " + m32_name + " my ant high is " + _feet + " feet " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant.Add(tempText_rst_name_qth_age_watt_rig_02);
                _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Add("feet");

                string tempText_rst_name_qth_age_rig_ant_watt_feet_00 = callsign + " fb " + m32_name + " wx? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_ant_watt_feet_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_01 = callsign + " fb " + m32_name + " weather? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_01);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_02 = callsign + " fb " + m32_name + " wx hr is " + _weather + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_02);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("weather");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_03 = callsign + " fb " + m32_name + " weather hr is " + _weather + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_03);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("weather");

                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_00 = callsign + " fb " + m32_name + " work? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_01 = callsign + " fb " + m32_name + " what is ur work? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_02 = callsign + " fb " + m32_name + " occupation? " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_02);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_03 = callsign + " fb " + m32_name + " i work as " + _work + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_03);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("work");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_04 = callsign + " fb " + m32_name + " occupation hr is " + _work + " " + callsign + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_04);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("work");

            }
            else
            {

                string tempText__no_00 = "ur rst is " + _rst + " " + _rst + " hw copy?  <kn>";
                _botAnswer_no.Add(tempText__no_00);
                _botAnswer_no_tx.Add("rst");
                string tempText_no_01 = "rst? <kn> ";
                _botAnswer_no.Add(tempText_no_01);
                _botAnswer_no_tx.Add("no");

                string tempText_rst_00 = "op? <kn> ";
                _botAnswer_rst.Add(tempText_rst_00);
                _botAnswer_rst_tx.Add("no");
                string tempText_rst_01 = "op? <kn> ";
                _botAnswer_rst.Add(tempText_rst_01);
                _botAnswer_rst_tx.Add("no");
                string tempText_rst_02 = "name? <kn> ";
                _botAnswer_rst.Add(tempText_rst_02);
                _botAnswer_rst_tx.Add("no");
                string tempText_rst_03 = "name hr is " + _name + " <kn>";
                _botAnswer_rst.Add(tempText_rst_03);
                _botAnswer_rst_tx.Add("name");
                string tempText_rst_04 = "op hr is " + _name + " <kn>";
                _botAnswer_rst.Add(tempText_rst_04);
                _botAnswer_rst_tx.Add("name");

                string tempText_rst_name_00 = "fb " + m32_name + " qth? <kn>";
                _botAnswer_rst_name.Add(tempText_rst_name_00);
                _botAnswer_rst_name_tx.Add("no");
                string tempText_rst_name_01 = "fb " + m32_name + " my qth is " + _qth + " <kn>";
                _botAnswer_rst_name.Add(tempText_rst_name_01);
                _botAnswer_rst_name_tx.Add("qth");
                string tempText_rst_name_02 = "fb " + m32_name + " qth hr is " + _qth + " <kn>";
                _botAnswer_rst_name.Add(tempText_rst_name_02);
                _botAnswer_rst_name_tx.Add("qth");

                string tempText_rst_name_qth_00 = "fb " + m32_name + " age? <kn>";
                _botAnswer_rst_name_qth.Add(tempText_rst_name_qth_00);
                _botAnswer_rst_name_qth_tx.Add("no");
                string tempText_rst_name_qth_01 = "fb " + m32_name + " I am " + _age + " old <kn>";
                _botAnswer_rst_name_qth.Add(tempText_rst_name_qth_01);
                _botAnswer_rst_name_qth_tx.Add("age");
                string tempText_rst_name_qth_02 = "fb " + m32_name + " my age is " + _age + " <kn>";
                _botAnswer_rst_name_qth.Add(tempText_rst_name_qth_02);
                _botAnswer_rst_name_qth_tx.Add("age");

                string tempText_rst_name_qth_age_00 = "fb " + m32_name + " rig? <kn>";
                _botAnswer_rst_name_qth_age.Add(tempText_rst_name_qth_age_00);
                _botAnswer_rst_name_qth_age_tx.Add("no");
                string tempText_rst_name_qth_age_01 = "fb " + m32_name + " rig hr is " + _rig + " <kn>";
                _botAnswer_rst_name_qth_age.Add(tempText_rst_name_qth_age_01);
                _botAnswer_rst_name_qth_age_tx.Add("rig");
                string tempText_rst_name_qth_age_02 = "fb " + m32_name + " my rig is " + _rig + " <kn>";
                _botAnswer_rst_name_qth_age.Add(tempText_rst_name_qth_age_02);
                _botAnswer_rst_name_qth_age_tx.Add("rig");


                string tempText_rst_name_qth_age_rig_00 = "fb " + m32_name + " watt? <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_00);
                _botAnswer_rst_name_qth_age_rig_tx.Add("no");
                string tempText_rst_name_qth_age_rig_01 = "fb " + m32_name + " what is ur pw? <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_01);
                _botAnswer_rst_name_qth_age_rig_tx.Add("no");
                string tempText_rst_name_qth_age_rig_02 = "fb " + m32_name + " i am sending with " + _watt + " watt <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_02);
                _botAnswer_rst_name_qth_age_rig_tx.Add("watt");
                string tempText_rst_name_qth_age_rig_03 = "fb " + m32_name + " my pw is " + _watt + " watt <kn>";
                _botAnswer_rst_name_qth_age_rig.Add(tempText_rst_name_qth_age_rig_03);
                _botAnswer_rst_name_qth_age_rig_tx.Add("watt");

                string tempText_rst_name_qth_age_rig_watt_00 = "fb " + m32_name + " ant? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt.Add(tempText_rst_name_qth_age_rig_00);
                _botAnswer_rst_name_qth_age_rig_watt_tx.Add("no");
                string tempText_rst_name_qth_age_watt_rig_01 = "fb " + m32_name + " my ant is " + _ant + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt.Add(tempText_rst_name_qth_age_rig_01);
                _botAnswer_rst_name_qth_age_rig_watt_tx.Add("ant");
                string tempText_rst_name_qth_age_watt_rig_02 = "fb " + m32_name + " ant hr is " + _ant + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt.Add(tempText_rst_name_qth_age_rig_02);
                _botAnswer_rst_name_qth_age_rig_watt_tx.Add("ant");

                string tempText_rst_name_qth_age_rig_watt_ant_00 = "fb " + m32_name + " feet? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant.Add(tempText_rst_name_qth_age_rig_watt_ant_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_01 = "fb " + m32_name + " my ant is " + _feet + " feet up <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant.Add(tempText_rst_name_qth_age_rig_watt_ant_01);
                _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Add("feet");
                string tempText_rst_name_qth_age_rig_rig_watt_ant_02 = "fb " + m32_name + " my ant high is " + _feet + " feet <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant.Add(tempText_rst_name_qth_age_watt_rig_02);
                _botAnswer_rst_name_qth_age_rig_watt_ant_tx.Add("feet");

                string tempText_rst_name_qth_age_rig_ant_watt_feet_00 = "fb " + m32_name + " wx? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_ant_watt_feet_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_01 = "fb " + m32_name + " weather? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_01);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_02 = "fb " + m32_name + " wx hr is " + _weather + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_02);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("weather");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_03 = "fb " + m32_name + " weather hr is " + _weather + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_03);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx.Add("weather");

                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_00 = "fb " + m32_name + " work? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_01 = "fb " + m32_name + " what is ur work? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_00);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_02 = "fb " + m32_name + " occupation? <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_02);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("no");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_03 = "fb " + m32_name + " i work as " + _work + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_03);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("work");
                string tempText_rst_name_qth_age_rig_watt_ant_feet_weather_04 = "fb " + m32_name + " occupation hr is " + _work + " <kn>";
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Add(tempText_rst_name_qth_age_rig_watt_ant_feet_weather_04);
                _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx.Add("work");
            }
        }
        private void Test_Say(string say)
        {
            string word = "";
           
            if (say.Contains("rst? "))
            {
                response[0] = _botAnswer_no[0];
                response[1] = _botAnswer_no_tx[0];
            }
            if (response[1] == "rst")
            {
                x_rst = true;
            }
            if(say.Contains("rst "))
            {
                word = "rst";

                m32_rst = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (say.Contains("name? "))
            {
                response[0] = _botAnswer_rst[2];
                response[1] = _botAnswer_rst_tx[1];
            }
            if (say.Contains("name "))
            {
                word = "name";

                m32_name = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (say.Contains("op? "))
            {
                response[0] = _botAnswer_rst[3];
                response[1] = _botAnswer_rst_tx[3];
            }
            if (say.Contains("op "))
            {
                word = "op";

                m32_name = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "name")
            { x_name = true; }

            if (say.Contains("qth? "))
            {
                int qth_int = rand.Next(0, 1);
                if (qth_int == 0)
                {
                    response[0] = _botAnswer_rst_name[1];
                    response[1] = _botAnswer_rst_name_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name[2];
                    response[1] = _botAnswer_rst_name_tx[2];
                }
            }
            if (say.Contains("qth "))
            {
                word = "qth";

                m32_qth = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "qth")
            { x_qth = true; }
            if (say.Contains("age? "))
            {
                int age_int = rand.Next(0, 1);
                if (age_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth[1];
                    response[1] = _botAnswer_rst_name_qth_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth[2];
                    response[1] = _botAnswer_rst_name_qth_tx[2];
                }
            }
            if (say.Contains("age "))
            {
                word = "age";

                m32_age = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "age")
            { x_age = true; }
            if (say.Contains("rig? "))
            {
                int rig_int = rand.Next(0, 1);
                if (rig_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age[1];
                    response[1] = _botAnswer_rst_name_qth_age_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age[2];
                    response[1] = _botAnswer_rst_name_qth_age_tx[2];
                }
            }
            if (say.Contains("rig "))
            {
                word = "rig";

                m32_rig = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "rig")
            { x_rig = true; }
            if (say.Contains("watt? "))
            {
                int watt_int = rand.Next(0, 1);
                if (watt_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_tx[2];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig[3];
                    response[1] = _botAnswer_rst_name_qth_age_rig_tx[3];
                }
            }
            if (say.Contains("watt "))
            {
                word = "watt";

                m32_watt = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (say.Contains("pw "))
            {
                word = "pw";

                m32_watt = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "watt")
            { x_watt = true; }
            if (say.Contains("ant? "))
            {
                int ant_int = rand.Next(0, 1);
                if (ant_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt[1];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_tx[2];
                }
            }
            if (say.Contains("ant "))
            {
                word = "ant";

                m32_ant = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "ant")
            { x_ant = true; }
            if (say.Contains("feet? "))
            {
                int feet_int = rand.Next(0, 1);
                if (feet_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant[1];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_tx[2];
                }
            }
            if (say.Contains("feet "))
            {
                word = "feet";

                m32_feet = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "feet")
            { x_feet = true; }
            if (say.Contains("wx? "))
            {
                int weather_int = rand.Next(0, 1);
                if (weather_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet[1];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx[2];
                }
            }
            if (say.Contains("wx "))
            {
                word = "wx";

                m32_weather = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (say.Contains("weather? "))
            {
                int weather_int = rand.Next(0, 1);
                if (weather_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet[1];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx[2];
                }
            }
            if (say.Contains("weather "))
            {
                word = "weather";

                m32_weather = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "weather")
            { x_weather = true; }
            if (say.Contains("work? "))
            {
                int work_int = rand.Next(0, 1);
                if (work_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather[1];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx[2];
                }
            }
            if (say.Contains("work "))
            {
                word = "work";

                m32_work = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (say.Contains("occupation? "))
            {
                int work_int = rand.Next(0, 1);
                if (work_int == 0)
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather[1];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx[1];
                }
                else
                {
                    response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather[2];
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx[2];
                }
            }
            if (say.Contains("occupation "))
            {
                word = "occupation";

                m32_work = Regex.Match(say.Substring(word.Length), @"^\s*(\w*)").Groups[1].Value;
            }
            if (response[1] == "work")
            { x_work = true; }

        }


        public Bots()
        {

            int bot_int = rand.Next(0, TxCall.Count - 1);
            string[] bot = { TxCall[bot_int], Report[bot_int], TxName[bot_int], City[bot_int] + ", " + State[bot_int], Age[bot_int], Rig[bot_int], Antenna[bot_int], Watt[bot_int], Feet[bot_int], Weather[bot_int], Occupation[bot_int] };
            _callsign = bot[0];
            _rst = bot[1];
            _name = bot[2];
            _qth = bot[3];
            _age = bot[4];
            _rig = bot[5];
            _ant = bot[6];
            _watt = bot[7];
            _feet = bot[8];
            _weather = bot[9];
            _occupation = bot[10];
        }


        public string Talk_Whit_Bot(string m32_call, string say, string F_M_L) // F_M_L F or first qso, M for normal qso, L for last qso
        {
            string test_response_callsign = _callsign + " de " + m32_call;
            if (say.Contains(test_response_callsign))
            {
                test_call = true;
            }
            else
            {
                test_call = false;
            }

            callsign = m32_call + " de " + _callsign;
            string r = "de " + m32_call + " <kn>";
            string response_callsign = say.Replace(r, "");
            string toBeSearched = "call ";
            if (say.Contains("call "))
            {
                m32_call = say.Substring(say.IndexOf(toBeSearched) + toBeSearched.Length);
            }








            string first_response = callsign + " <kn>";
           


            string last_response = callsign + "txn for nice oqs 73 73 hope to meet ur ang " + callsign + " <sk>";
            if (F_M_L == "F")
            {
                response[0] = first_response;
            }
            else if (F_M_L == "M")
            {
                if (m32_rst == "")
                {
                    Load_Lister();

                    int tx_no = rand.Next(0, _botAnswer_no.Count - 1);
                    response[1] = _botAnswer_no_tx[tx_no];
                    if (x_rst)
                    {
                        response[0] = _botAnswer_no[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_no[tx_no];
                    }

                    Test_Say(say);
                }
                if (m32_rst != "")
                {
                    Load_Lister();

                    int tx_rst = rand.Next(0, _botAnswer_rst.Count - 1);
                    response[1] = _botAnswer_rst_tx[tx_rst];
                    if (x_name)
                    {
                        response[0] = _botAnswer_rst[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst[tx_rst];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != ""))
                {
                    Load_Lister();

                    int tx_rst_name = rand.Next(0, _botAnswer_rst_name.Count - 1);
                    response[1] = _botAnswer_rst_name_tx[tx_rst_name];
                    if (x_qth)
                    {
                        response[0] = _botAnswer_rst_name[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name[tx_rst_name];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth = rand.Next(0, _botAnswer_rst_name_qth.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_tx[tx_rst_name_qth];
                    if (x_qth)
                    {
                        response[0] = _botAnswer_rst_name_qth[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth[tx_rst_name_qth];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age = rand.Next(0, _botAnswer_rst_name_qth_age.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_tx[tx_rst_name_qth_age];
                    if (x_age)
                    {
                        response[0] = _botAnswer_rst_name_qth_age[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age[tx_rst_name_qth_age];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age_rig = rand.Next(0, _botAnswer_rst_name_qth_age_rig.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_rig_tx[tx_rst_name_qth_age_rig];
                    if (x_rig)
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig[tx_rst_name_qth_age_rig];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != "") && (m32_watt != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age_rig_watt = rand.Next(0, _botAnswer_rst_name_qth_age_rig_watt.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_tx[tx_rst_name_qth_age_rig_watt];
                    if (x_watt)
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt[tx_rst_name_qth_age_rig_watt];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != "") && (m32_watt != "") && (m32_ant != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age_rig_watt_ant = rand.Next(0, _botAnswer_rst_name_qth_age_rig_watt_ant.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_tx[tx_rst_name_qth_age_rig_watt_ant];
                    if (x_ant)
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant[tx_rst_name_qth_age_rig_watt_ant];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != "") && (m32_watt != "") && (m32_ant != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age_rig_watt_ant = rand.Next(0, _botAnswer_rst_name_qth_age_rig_watt_ant.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_tx[tx_rst_name_qth_age_rig_watt_ant];
                    if (x_ant)
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant[tx_rst_name_qth_age_rig_watt_ant];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != "") && (m32_watt != "") && (m32_ant != "") && (m32_feet != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age_rig_watt_ant_feet = rand.Next(0, _botAnswer_rst_name_qth_age_rig_watt_ant_feet.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_tx[tx_rst_name_qth_age_rig_watt_ant_feet];
                    if (x_feet)
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet[tx_rst_name_qth_age_rig_watt_ant_feet];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != "") && (m32_watt != "") && (m32_ant != "") && (m32_feet != "") && (m32_weather != ""))
                {
                    Load_Lister();

                    int tx_rst_name_qth_age_rig_watt_ant_feet_weather = rand.Next(0, _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather.Count - 1);
                    response[1] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather_tx[tx_rst_name_qth_age_rig_watt_ant_feet_weather];
                    if (x_weather)
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather[1];
                    }
                    else
                    {
                        response[0] = _botAnswer_rst_name_qth_age_rig_watt_ant_feet_weather[tx_rst_name_qth_age_rig_watt_ant_feet_weather];
                    }

                    Test_Say(say);
                }
                if ((m32_rst != "") && (m32_name != "") && (m32_qth != "") && (m32_age != "") && (m32_rig != "") && (m32_watt != "") && (m32_ant != "") && (m32_feet != "") && (m32_weather != "") && (m32_work != ""))
                {
                    response[0] = callsign + " " + Bot_Answer(say, m32_call) + " " + callsign + " <kn>";
                }

               
            }
            if (F_M_L == "L")
            {
                response[0] = last_response;
            }
            return response[0];
        }
}   }
    
