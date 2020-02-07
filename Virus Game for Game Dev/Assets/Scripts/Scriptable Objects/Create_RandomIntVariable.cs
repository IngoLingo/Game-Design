// ----------------------------------------------------------------------------
// Create_RandomIntVariable
// Note: A int is an integer number (3 is an int, 3.1 is not). Can be a whole number between -+2147483647.
//This will create a integer with set value, a maximum value and a minimum value (Can disable max and min).
//
// Made by: Nathan Ethington
// Date:   10/12/2019
// ----------------------------------------------------------------------------
using UnityEngine;

[CreateAssetMenu(fileName = "Create_RandomIntVariable", menuName = "Create Variable/IntVariable")]
public class Create_RandomIntVariable : ScriptableObject
{
    //Creates a box in the inspector for developers to make notes on what the created scriptable object is.
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperNotes = "An integer number";
#endif
    
    //Declare Variables.
    private int finalValue;
    public int maxValue;
    public int minValue;

    
    public void ChangeValue(int amount)
    {
        finalValue = Random.Range(minValue, maxValue);
    }
}