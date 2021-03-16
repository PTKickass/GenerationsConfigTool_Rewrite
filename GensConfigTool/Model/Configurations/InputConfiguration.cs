﻿using ConfigurationTool.Model.Devices;
using System.IO;

namespace ConfigurationTool.Model.Configurations
{
    class InputConfiguration : IConfiguration
    {
        public string ConfigLocation => "PlayerInput.cfg";
        public string DefaultConfig => "DefaultConfig.cfg";

        public Configuration LoadConfiguration(Configuration config)
        {
            if (config == null) config = new Configuration();
            string path = $"{config.InputSaveLocation}\\{ConfigLocation}";

            if (!File.Exists(path)) return config;
            try
            {
                using (StreamReader sr = new StreamReader(new BufferedStream(File.Open(path, FileMode.Open))))
                {
                    string name = sr.ReadLine();
                    string serialized = sr.ReadLine();
                    config.Keyboard = Keyboard.DeSerialize(serialized);
                }
                return config;
            }
            catch
            {
                return new Configuration();
            }
        }

        public void SaveConfiguration(Configuration config)
        {
            string path = $"{config.InputSaveLocation}\\{ConfigLocation}";

            Directory.CreateDirectory(config.InputSaveLocation);
            using (StreamWriter writer = new StreamWriter(File.Create(path)))
            {
                writer.Write(config.Keyboard.Serialize());
            }
        }
    }
}
