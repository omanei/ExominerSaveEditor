using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExominerSaveEditor
{
    internal class Exominer
    {
        private readonly BinaryFormatter formatter;
        private readonly JObject save;
        public Exominer(string pathToSave)
        {
            formatter = new();
            using (FileStream fs = new(pathToSave, FileMode.Open))
            {
                save = JObject.Parse((string)formatter.Deserialize(fs));
            }
        }

        public void WriteFile() 
        {
            string json = save.ToString(Newtonsoft.Json.Formatting.None);
            using (FileStream fs = new("GameState", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, json);
            }
        }

        public string ShowWallet()
        {
            string result = string.Empty;
            foreach (var item in save["Wallet"])
            {
                result += item.ToString() + '\n'; 
            }

            return result;
        }

        public void SetSoftCurrency(double updatedSoftCurrency)
        {
            save["Wallet"]["SoftCurrency"] = updatedSoftCurrency;
        }

        public void SetHardCurrency(double updatedSoftCurrency)
        {
            save["Wallet"]["HardCurrency"] = updatedSoftCurrency;
        }

        public void SetSciencePoints(double updatedSoftCurrency)
        {
            save["Wallet"]["SciencePoints"] = updatedSoftCurrency;
        }

    }
}
