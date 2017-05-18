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
        CurrentRoll = 0;
        CurrentRoll = Random.Range(0f, 1f);
        // Iterate through the list (drops) and if drop is 
        // greater than or equal to current role then add that item to the item list.
        return ListOfItems;
    }


}
