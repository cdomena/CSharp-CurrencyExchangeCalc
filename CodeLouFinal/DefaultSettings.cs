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

        DefaultsProperty settings = new DefaultsProperty();

        //Load Defaults from default.json
        public void LoadDefault()
        {
            
            var serializer = new JsonSerializer();
            string path = Directory.GetCurrentDirectory();
            using (var reader = new StreamReader(Path.Combine(path, @"Data\Default.json")))
            using (var jsonReader = new JsonTextReader(reader))
            {
                settings = serializer.Deserialize<DefaultsProperty>(jsonReader);
            }
            Program.Origin = settings.Origin;
            Program.Destination = settings.Destination;
        }



        // attempting to serialize settings to default.json.
        public void SaveDefault()
        {
            
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
