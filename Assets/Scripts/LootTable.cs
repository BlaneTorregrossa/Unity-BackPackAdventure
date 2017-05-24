using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

//1
[CreateAssetMenu]
public class LootTable : ScriptableObject
{
    //2
    public float CurrentRoll;
    public List<ItemDrop> drops;
    public int counter;

    public List<Item> ListOfItems = new List<Item>();

    // Items as shown in inspector
    [System.Serializable]
    public class ItemDrop
    {
        public Item item;
        [Range(0, 1)]
        public float drop;
    }


  
    //Returns all drops in a list
    public List<Item> GetDrop()
    {
        CurrentRoll = Random.Range(0f, 1f);
        foreach (var loot in drops)
        {
            if (CurrentRoll < loot.drop)
            {
                ListOfItems.Add(loot.item);
            }
        }
        Debug.Log("List of Items: " + ListOfItems);
        return ListOfItems;
    }

    void Start()
    {
        GetDrop();
    }

}
