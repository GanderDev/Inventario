using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInGame : MouseAct
{

    public ItemsSCOBJ ItemSCOBJ;

    public override void Click(int ID = 0, int Arrayposition = 0)
    {
        
        if (IVTRimputs.AddItem(ItemSCOBJ)) 
        {

            Destroy(gameObject);

        }

    }

}
