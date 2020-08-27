using UnityEngine;

public class ItemSelected : MonoBehaviour
{

    public MouseInteract MouseInte;

    /// <summary> Move a Item to empty slot </summary>
    /// 
    /// <param name="SlotColider"></param> is a colider took by raycast in MouseInteract
    /// 
    /// <param name="ListItemSprite"></param> List of Item Sprites ( IVTRGraphic )
    /// 
    /// <param name="ListItemSCOBJ"></param> List of item ( IVTRImputs )
    /// 
    /// <param name="IDSelected"></param> Item selected ID
    /// 
    /// <param name="PreviuosSlotPosition"></param> previous slot position
    /// 
    /// <returns> This function return a vector2( Next slot position, Item selected ID )</returns>
    /// 
    public Vector2 SelectItem(Collider2D SlotColider, SpriteRenderer[] ListItemSprite, ItemsSCOBJ[] ListItemSCOBJ, int IDSelected,int PreviuosSlotPosition)
    {

        int NextSlotPosition = 0;

        for (int i = 0; ListItemSprite.Length > i; i++)
        {

            if (ListItemSprite[i].GetComponent<Collider2D>() == SlotColider)
            {

                NextSlotPosition = i;
                break;

            }

        }

        if (ListItemSCOBJ[NextSlotPosition].ID == 0)
        {

            if (IDSelected == 0)//if dont have any Item Selected
            {

                MouseInte.IVTRimputs.Grafic.ItemSlotUpdate(NextSlotPosition);
                return new Vector2(0, 0);

            }
            else//if have any item selected and the next slot are empty
            {

                MouseInte.IVTRimputs.ChangeItemSlotPosition(ListItemSCOBJ[PreviuosSlotPosition], NextSlotPosition, PreviuosSlotPosition);
                return new Vector2(NextSlotPosition, IDSelected);

            }
            
        }
        else//if the next slot have any item
        {

            MouseInte.IVTRimputs.Grafic.ItemSlotUpdate(NextSlotPosition);
            return new Vector2 (NextSlotPosition, ListItemSCOBJ[NextSlotPosition].ID);

        }

    }

}
