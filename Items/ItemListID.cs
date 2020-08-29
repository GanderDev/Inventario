using UnityEngine;

[CreateAssetMenu(fileName = "IDItemDictionary", menuName = "IDItemDictionary")]
public class ItemListID : ScriptableObject
{

    public ItemsSCOBJ[] IDItemList;

    public ItemsSCOBJ SearchItem(int ItemID)
    {

        return IDItemList[ItemID];

    }

}
