using UnityEngine;

public class IVTRGraphic : MonoBehaviour
{

    public SpriteRenderer[] SpriteRendererItemSlot, SpriteRendererItemSprite;

    public Sprite ItemSlotNome, ItemSlotSelected;

    /// <summary> Atuliza todos os srpites dos items </summary>
    /// 
    /// <param name="Itemsobj"></param> Lista de itens no inventario(originado no IVTRImputs)
    /// 
    public void ItemSpriteUpdate(ItemsSCOBJ[] Itemsobj)
    {

        for (int i = 0; SpriteRendererItemSprite.Length > i; i++)
        {

            SpriteRendererItemSprite[i].sprite = Itemsobj[i].icone;

        }

    }

    /// <summary> Atualiza todos os sprites dos slots </summary>
    /// 
    /// <param name="PosiçãoDaSelecao"></param> 
    /// 
    public void ItemSlotUpdate(int PosiçãoDaSelecao)
    {

        for (int i = 0; SpriteRendererItemSlot.Length > i; i++)
        {

            if (PosiçãoDaSelecao == i)
            {

                SpriteRendererItemSlot[i].sprite = ItemSlotSelected;

            }
            else
            {

                SpriteRendererItemSlot[i].sprite = ItemSlotNome;

            }

        }

    }

}
