using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouFinal
{

    public class DefaultSettings
    {
        


        //Load Defaults from default.json
        public void LoadDefault()
        {



        }



        // attempting to serialize settings to default.json.
        public void SaveDefault()
        {
            DefaultsProperty settings = new DefaultsProperty();
            settings.Origin = Program.Origin;
            settings.Destination = Program.Destination;
            string path = Directory.GetCurrentDirectory();
            using (StreamWriter file = File.CreateText(Path.Combine(path, @"Data\Default.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, settings);
            }

        }
       
            
        
    }
}
