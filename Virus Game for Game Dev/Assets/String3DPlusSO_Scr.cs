using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class String3DPlusSO_Scr : MonoBehaviour
{
    [SerializeField]
    private string value = " / ";
    public Create_FloatVariable scriptableObjectHere;
    //public Component infectedCountScript;

    public string Value
    {
        get { return value; }
        set { this.value = value; }
    }

    void Update() //Use the update method anthony showed us
    {
        GetComponent<TextMesh>().text = Mathf.Round(scriptableObjectHere.value).ToString() + value + Mathf.Round(GetComponentInParent<DoorMouseClick_Scr>().inectedRequired).ToString();
        
    }
}
