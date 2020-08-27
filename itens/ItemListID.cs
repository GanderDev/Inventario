using UnityEngine;

[CreateAssetMenu(fileName = "IDItemDictionay", menuName = "IDItemDictionay")]
public class ItemListID : ScriptableObject
{

    public ItemsSCOBJ[] IDItemList;

    public ItemsSCOBJ SearchItem(int ItemID)
    {

        return IDItemList[ItemID];

    }

}
