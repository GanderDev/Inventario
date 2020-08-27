using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAct : MonoBehaviour
{

    //exemple: public class Door : MouseAct

    protected IVTRImputs IVTRimputs;

    private void Awake()
    {

        IVTRimputs = GameObject.FindObjectOfType<IVTRImputs>();

    }

    /// <summary> This function is called by MouseInteract </summary>
    /// 
    /// <param name="IDItemSelected"></param> Item Selected ID
    /// 
    /// <param name="ListPositionSelected"></param> Item Position in list
    /// 
    public virtual void Click(int IDItemSelected, int ListPositionSelected = 0 ) { }

}
