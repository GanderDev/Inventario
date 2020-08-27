using UnityEngine;

public class IVTRGraphic : MonoBehaviour
{

    public SpriteRenderer[] SpriteRendererItemSlot, SpriteRendererItemSprite;

    public Sprite ItemSlotNome, ItemSlotSelected;

    /// <summary> Updates all Item's sprites </summary>
    /// 
    /// <param name="Itemsobj"></param> List of items in inventory(originado no IVTRImputs)
    /// 
    public void ItemSpriteUpdate(ItemsSCOBJ[] Itemsobj)
    {

        for (int i = 0; SpriteRendererItemSprite.Length > i; i++)
        {

            SpriteRendererItemSprite[i].sprite = Itemsobj[i].icone;

        }

    }

    /// <summary> Updates all slot's sprite </summary>
    /// 
    /// <param name="Selectposition"></param>
    /// 
    public void ItemSlotUpdate(int Selectposition)
    {

        for (int i = 0; SpriteRendererItemSlot.Length > i; i++)
        {

            if (Selectposition == i)
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
