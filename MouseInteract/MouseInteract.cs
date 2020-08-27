using UnityEngine;

public class MouseInteract : MonoBehaviour
{
    public IVTRImputs IVTRimputs;
    public ItemSelected ItemSelect;
    public int ItemSelectedID, OBJSelectePosition; 

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickCheck();

        }

    }

    /// <summary> ClickCheck () checks if something was hit by a mouse click </summary>
    /// 
    void clickCheck()
    {

        Vector2 mousePosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var Click = Physics2D.Raycast(mousePosi, Vector2.zero);

        if (Click.collider != null)
        {

            ItemSelectedID = IVTRimputs.ItemsOBJ[OBJSelectePosition].ID;

            if (Click.collider.CompareTag("Interactable"))
            {

                Click.collider.GetComponent<MouseAct>().Click(ItemSelectedID, OBJSelectePosition);
                return;

            }
            if (Click.collider.CompareTag("Inventory"))
            {

                Vector2 ItemSelected = ItemSelect.SelectItem(Click.collider, IVTRimputs.Grafic.SpriteRendererItemSprite, IVTRimputs.ItemsOBJ,ItemSelectedID,OBJSelectePosition);
                ItemSelectedID = (int)ItemSelected.y; OBJSelectePosition = (int)ItemSelected.x;
                return;

            }

        }

    }

}
