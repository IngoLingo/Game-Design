// ----------------------------------------------------------------------------
// Create_BoolVariable
// Note: A bool is a boolean and can only contain ether a true or false value.
//
// Credits: Ryan Hipple
// Modified by: Nathan Ethington
// Date:   10/12/2019
// ----------------------------------------------------------------------------
using UnityEngine;

[CreateAssetMenu(fileName = "Create_BoolVariable", menuName = "Create Variable/BoolVariable")]
public class Create_BoolVariable : ScriptableObject
{
    //Creates a box in the inspector for developers to make notes on what the created scriptable object is.
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperNotes = "";
#endif
    
    //Declare Variables.
    public bool value = true;

    public void ReverseValue() //Changes the value to be the opposite of what it currently is
    {
        value = !value;
    }
    
    public void ChangeValue(bool newValue) //Changes the value to the new value or keeps it the same.
    {
        value = newValue;
    }
}