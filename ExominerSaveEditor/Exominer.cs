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
            File.Copy(pathToSave, "GameState.bak");
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

        public string ShowInfo() 
        {
            var result = string.Empty;
            result += "Rank: " + save["Rank"] + '\n';
            result += "Planet: " + save["Planet"] + '\n';
            result += ShowWallet() + '\n';
            result += "OreValue: " + save["OreValue"] + '\n';
            result += "AlloyValue: " + save["AlloyValue"] + '\n';
            result += "ItemsValue: " + save["ItemsValue"] + '\n';
            result += "SmelterLevel: " + save["SmelterLevel"] + '\n';
            result += "CrafterLevel: " + save["CrafterLevel"] + '\n';
            result += "RemoveAds: " + save["RemoveAds"] + '\n';
            return result;
        }

        public void SetSoftCurrency(double updatedSoftCurrency) => save["Wallet"]["SoftCurrency"] = updatedSoftCurrency;

        public void SetHardCurrency(double updatedHardCurrency) => save["Wallet"]["HardCurrency"] = updatedHardCurrency;

        public void SetSciencePoints(double updatedSciencePoints) => save["Wallet"]["SciencePoints"] = updatedSciencePoints;

        public void SetOreValue(double updateOreValue) => save["OreValue"] = updateOreValue;

        public void SetAlloyValue(double updateAlloyValue) => save["AlloyValue"] = updateAlloyValue;

        public void SetItemsValue(double updateItemsValue) => save["ItemsValue"] = updateItemsValue;

        public void SetSmelterLevel(double updateSmelterLevel) => save["SmelterLevel"] = (int)updateSmelterLevel;

        public void SetCrafterLevel(double updateCrafterLevel) => save["CrafterLevel"] = (int)updateCrafterLevel;

        public void DisableAds() 
        {
            save["Store"]["noAdsProductState"][0]["_isPurchased"] = true;
            save["Store"]["noAdsProductState"][0]["_isSpecialOfferPurchased"] = true;
            save["RemoveAds"] = true;
        }
        public JToken? ShowProperty(string property) => save[property];



    }
}
