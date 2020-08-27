using UnityEngine;

public class IVTRImputs : MonoBehaviour
{

    //Não precisa ser alterado por fora
    public ItemsSCOBJ[] ItemsOBJ;

    public ItemsSCOBJ Nothing;

    public IVTRGraphic Grafic;

    public ItemListID ItemListID;

    /// <summary>AddItem()  Ultilizando para Adicionar um item a um Slot no inventario </summary>
    /// 
    /// <param name="ItemToAdd"></param> Scriptable Object com as informações dos items
    /// 
    public bool AddItem(ItemsSCOBJ ItemToAdd)
    {

        for (int i = 0; ItemsOBJ.Length >= i + 1; i++) //adiciona o item em um slot vazio
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

    /// <summary> RemoveItem utilizado para remover um item de uma slot especifico ou de um ID especifico </summary>
    /// 
    /// <param name="IDItemToRemove"></param> ID de um Objeto para a sua remoção
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

    /// <summary> Troca a posição de um item </summary>
    /// 
    /// <param name="Item"></param> Item que vai trocar de posição
    /// 
    /// <param name="NexSlotPosition"></param> Posição que o intem vai estar
    /// 
    /// <param name="PreviuosSlotPosition"></param> Posição que o item está
    /// 
    public void ChangeItemSlotPosition(ItemsSCOBJ Item, int NexSlotPosition, int PreviuosSlotPosition)
    {

        ItemsOBJ[NexSlotPosition] = Item;

        ItemsOBJ[PreviuosSlotPosition] = Nothing;

        Grafic.ItemSpriteUpdate(ItemsOBJ);
        Grafic.ItemSlotUpdate(NexSlotPosition);

    }

}
