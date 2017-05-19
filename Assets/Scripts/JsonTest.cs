using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonTest : MonoBehaviour
{
    [System.Serializable]
    public class PlayerInfo
    {
        public int HP;
        public string Name;
    }

    []

    public PlayerInfo Player;
    void Start()
    {
        var info = new PlayerInfo() { HP = 5,  Name = "El Generico",};
        Player = info;
        Save();
    }

    private string path;

    public void Save()
    {
        path = Application.dataPath + "/" + "Resources" + "/";
        string filename = "playerinfo.json";
        var json = JsonUtility.ToJson(Player, true);
        System.IO.File.WriteAllText(path + filename, json);
    }
}
