using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAct : MonoBehaviour
{

    //coloque esse script como base de um script(exemplo script Door)

    protected IVTRImputs IVTRimputs;

    private void Awake()
    {

        IVTRimputs = GameObject.FindObjectOfType<IVTRImputs>();

    }

    /// <summary> Click é chamado pelo MouseInteract </summary>
    /// 
    /// <param name="IDItemSelected"></param> ID di ItemSelecionado
    /// 
    /// <param name="ListPositionSelected"></param> Posição do Item na Lista
    /// 
    public virtual void Click(int IDItemSelected, int ListPositionSelected = 0 ) { }

}
