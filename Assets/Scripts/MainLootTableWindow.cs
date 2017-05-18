//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//#if UNITY_EDITOR
//using UnityEditor;
//#endif

//[CreateAssetMenu(fileName = "Loot Menu", menuName = "Loot Menu")]
//public class MainLootTable : EditorWindow
//{
//    [SerializeField]
//    public class Loot : ScriptableObject
//    {
//        public float DropRate;
//    }
    
//    private GUIStyle Header;
//    public Loot CurrentLoot;
//    public List<Loot> LootList = new List<Loot>() { };
    
    
//    public void SetDropRateAndListSize(Loot loot)
//    {
//        loot.DropRate = 0.5f;
//        CurrentLoot = loot;
//    }
    
    
//    public float RollDropRate()
//    {
//        float CurrentRoll = 0f;
//        CurrentRoll = Random.Range(0f, 1f);
//        if (CurrentRoll >= CurrentLoot.DropRate)
//        {
//            Debug.Log("Roll was highger than the drop rate of "
//                    + CurrentLoot.DropRate.ToString()
//                    + ". Roll was " + CurrentRoll.ToString());
//            LootList.Add(CurrentLoot);
//        }
//        else
//        {
//            Debug.Log("Loot was not added to list. Loot DropRate was "
//                    + CurrentLoot.DropRate.ToString()
//                    + ". Roll was " + CurrentRoll.ToString());
//        }
//        return CurrentRoll;
//    }
    
//    // To return list of drops on resolution
//    public List<Loot> GetDrops()
//    {
//        return LootList;
//    }
    
//    public void Start()
//    {
//        //SetDropRateAndListSize()
//        RollDropRate();
//        GetDrops();
//    }
    
//}
