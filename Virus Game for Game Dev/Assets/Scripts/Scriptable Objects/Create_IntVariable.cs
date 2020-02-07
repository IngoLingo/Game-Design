// ----------------------------------------------------------------------------
// Create_IntVariable
// Note: A int is an integer number (3 is an int, 3.1 is not). Can be a whole number between -+2147483647.
//This will create a integer with set value, a maximum value and a minimum value (Can disable max and min).
//
// Credits: Ryan Hipple, Anthony Romrell
// Modified by: Nathan Ethington
// Date:   10/12/2019
// ----------------------------------------------------------------------------
using UnityEngine;

[CreateAssetMenu(fileName = "Create_IntVariable", menuName = "Create Variable/IntVariable")]
public class Create_IntVariable : ScriptableObject
{
    //Creates a box in the inspector for developers to make notes on what the created scriptable object is.
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperNotes = "An integer number";
#endif
    
    //Declare Variables.
    public int value;
    public bool disableMaxValue = true;
    public int maxValue;
    public bool disableMinValue = true;
    public int minValue;

    
    public void ChangeValue(int amount)
    {
        value = amount;
        CheckIfPastMinMaxLimit();
    }

    public void AddValue(int amount)
    {
        value += amount; //if you want to subtract just put a "-" in front of the amount
        CheckIfPastMinMaxLimit();
    }
    
    public void MultiplyValue(int amount)
    {
        value *= amount;
        CheckIfPastMinMaxLimit();
    }
    
    public void DivideValue(int amount)
    {
        value /= amount;
        CheckIfPastMinMaxLimit();
    }

    public void ChangeValueToMax()
    {
        value = maxValue;
    }
    
    public void ChangeValueToMin()
    {
        value = minValue;
    }
    
    
    public void CheckIfPastMinMaxLimit()
    {
        if (disableMinValue == false)
        {
            if (value < minValue)
            {
                value = minValue;
            }
        }
        
        if (disableMaxValue == false)
        {
            if (value > maxValue)
            {
                value = maxValue;
            }
        }
    }
}