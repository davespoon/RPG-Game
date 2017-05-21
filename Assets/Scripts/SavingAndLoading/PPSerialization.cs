using System;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PPSerialization
{
    public static BinaryFormatter BinaryFormatter = new BinaryFormatter();

    public static void Save(string saveTag, object obj)
    {
        MemoryStream memoryStream = new MemoryStream();
        BinaryFormatter.Serialize(memoryStream, obj);
        string temp = System.Convert.ToBase64String(memoryStream.ToArray());
        PlayerPrefs.SetString(saveTag, temp);
    }

    public static object Load(string loadTag)
    {
        string temp = PlayerPrefs.GetString(loadTag);

        if (temp == string.Empty)
        {
            return null;
        }

        MemoryStream memoryStream = new MemoryStream(System.Convert.FromBase64String(temp));
        return BinaryFormatter.Deserialize(memoryStream);
    }
}