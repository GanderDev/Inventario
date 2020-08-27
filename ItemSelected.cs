using UnityEngine;

public class ItemSelected : MonoBehaviour
{

    public MouseInteract MouseInte;

    /// <summary> Move um item para um slot vazio </summary>
    /// 
    /// <param name="SlotColider"></param> É o colider identificado no Raycast do MouseInteract
    /// 
    /// <param name="ListItemSprite"></param> Lista de Sprites de Item do IVTRGraphic
    /// 
    /// <param name="ListItemSCOBJ"></param> Lista de items do IVTRImputs
    /// 
    /// <param name="IDSelected"></param> ID do Item que está selecionado
    /// 
    /// <param name="PreviuosSlotPosition"></param> Posição do Item que está selecionado
    /// 
    /// <returns> Ele retorna um Vector2 que é (Proxima Posição do Item selecionado, ID do Item Selecionado) </returns>
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

            if (IDSelected == 0)//se ele n estiver selecionando nenhum item 
            {

                MouseInte.IVTRimputs.Grafic.ItemSlotUpdate(NextSlotPosition);
                return new Vector2(0, 0);

            }
            else//se tiver item selecionado e o proximo slot estiver livre ele move
            {

                MouseInte.IVTRimputs.ChangeItemSlotPosition(ListItemSCOBJ[PreviuosSlotPosition], NextSlotPosition, PreviuosSlotPosition);
                return new Vector2(NextSlotPosition, IDSelected);

            }
            
        }
        else//se o proximo slot tiver um item, ele so altera a seleção
        {

            MouseInte.IVTRimputs.Grafic.ItemSlotUpdate(NextSlotPosition);
            return new Vector2 (NextSlotPosition, ListItemSCOBJ[NextSlotPosition].ID);

        }

    }

}
