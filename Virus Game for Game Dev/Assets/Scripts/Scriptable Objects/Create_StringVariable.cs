// ----------------------------------------------------------------------------
// Create_StringVariable
// Note: A string is a sequence of characters (eg. "Hello World 123").
//
// Credits: Ryan Hipple
// Modified by: Nathan Ethington
// Date:   10/12/2019
// ----------------------------------------------------------------------------
using UnityEngine;

[CreateAssetMenu(fileName = "Create_StringVariable", menuName = "Create Variable/StringVariable")]
public class Create_StringVariable : ScriptableObject
{
    [SerializeField]
    private string value = "";

    public string Value
    {
        get { return value; }
        set { this.value = value; }
    }
}