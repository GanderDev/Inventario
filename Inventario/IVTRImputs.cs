using UnityEngine;

public class IVTRImputs : MonoBehaviour
{

    public ItemsSCOBJ[] ItemsOBJ;

    public ItemsSCOBJ Nothing;

    public IVTRGraphic Grafic;

    public ItemListID ItemListID;

    /// <summary> AddItem() this function is use to add a Item to Inventory Ultilizando para Adicionar um item a um Slot no inventario </summary>
    /// 
    /// <param name="ItemToAdd"></param> Scriptable Object with Item's Info
    /// 
    public bool AddItem(ItemsSCOBJ ItemToAdd)
    {

        for (int i = 0; ItemsOBJ.Length >= i + 1; i++)
        {
 
            if (ItemsOBJ[i].ID == 0)
            {
                
                ItemsOBJ[i] = ItemToAdd;
                break;

            }else if((i + 1) == ItemsOBJ.Length)
            {

                return false;

            }
            
        }

        Grafic.ItemSpriteUpdate(ItemsOBJ);
        return true;

    }

    /// <summary> RemoveItem() is a function use to remove a item of a especific slot RemoveItem </summary>
    /// 
    /// <param name="IDItemToRemove"></param> item's ID to remove
    /// 
    /// <param name="ItemSlotPosition"></param> Is the slot position to remove a Item in the especific slot
    /// 
    public void RemoveItem(int IDItemToRemove = 0, int ItemSlotPosition = 0)
    {

        if (ItemSlotPosition != 0)
        {

            ItemsOBJ[ItemSlotPosition] = Nothing;

        }
        else
        {

            for (int i = 0; ItemsOBJ.Length >= i + 1; i++)
            {

                if (ItemsOBJ[i].ID == IDItemToRemove)
                {

                    ItemsOBJ[i] = Nothing;
                    break;

                }

            }

        }

        Grafic.ItemSpriteUpdate(ItemsOBJ);

    }

    /// <summary> change the position of a Item </summary>
    /// 
    /// <param name="Item"></param> Item that will change position
    /// 
    /// <param name="NexSlotPosition"></param> Position that a item will be in
    /// 
    /// <param name="PreviuosSlotPosition"></param> item position
    /// 
    public void ChangeItemSlotPosition(ItemsSCOBJ Item, int NexSlotPosition, int PreviuosSlotPosition)
    {

        ItemsOBJ[NexSlotPosition] = Item;

        ItemsOBJ[PreviuosSlotPosition] = Nothing;

        Grafic.ItemSpriteUpdate(ItemsOBJ);
        Grafic.ItemSlotUpdate(NexSlotPosition);

    }

}
