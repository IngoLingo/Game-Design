using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scr_StringPlusScriptableObj : MonoBehaviour
{
    [SerializeField]
    private string value = "";
    public Create_FloatVariable scriptableObjectHere;
    public Text myText;

    public string Value
    {
        get { return value; }
        set { this.value = value; }
    }

    void Update() //Use the update method anthony showed us
    {
        myText.text = value + Mathf.Round(scriptableObjectHere.value).ToString();
    }

}
