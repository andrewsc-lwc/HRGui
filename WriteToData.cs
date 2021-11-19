using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WpfDemo
{
    class WriteToData
    {
        string folder = Directory.GetCurrentDirectory();
        
        string type;
        string name;
        int wages;
        string dob;
        string email;
        string playerPosition = "Undefined";
        int playerValue = 0;
        int playerGoals = 0;
        string coachPosition = "undefined";
        string physioSpeciality = "undefined";
        public WriteToData(string type, string name, int wages, string dob, string email, string playerPosition = "Undefined", int playerGoals = 0, int playerValue = 0, string coachPosition = "undefined", string physioSpeciality = "undefined")
        {
            this.type = type;
            this.name = name;
            this.wages = wages;
            this.dob = dob;
            this.email = email;
            this.playerPosition = playerPosition;
            this.playerGoals = playerGoals;
            this.playerValue = playerValue;
            this.coachPosition = coachPosition;
            this.physioSpeciality = physioSpeciality;
            switch (type)
            {
                case "Player":
                    AddPlayer();
                    break;
            }
            
        }
        public void AddPlayer()
        {
            string filename = "\\players.txt";
            TextWriter writeFile = new StreamWriter(folder + filename,true);
            writeFile.WriteLine(name+","+wages+ "," + dob + "," + email + "," + playerPosition + "," + playerGoals + "," + playerValue);
            writeFile.Flush();
            writeFile.Close();
        }
    }

}
