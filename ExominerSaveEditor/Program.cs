using Exominer;
using System.Runtime.Serialization.Formatters.Binary;

BinaryFormatter formatter = new();

string saveString = null;

using (FileStream fs = new FileStream("GameState", FileMode.Open))
{
    saveString = (string)formatter.Deserialize(fs);
}

