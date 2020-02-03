// ----------------------------------------------------------------------------
// Create_FloatVariable
// Note: A float is a fractional (floating point) number (eg. 3.14159265359).
//This will create a float with set value, a maximum value and a minimum value (Can disable max and min).
//
// Credits: Ryan Hipple, Anthony Romrell
// Modified by: Nathan Ethington
// Date:   10/12/2019
// ----------------------------------------------------------------------------
using UnityEngine;

[CreateAssetMenu(fileName = "Create_FloatVariable", menuName = "Create Variable/FloatVariable")]
public class Create_FloatVariable : ScriptableObject
{
    //Creates a box in the inspector for developers to make notes on what the created scriptable object is.
    #if UNITY_EDITOR
        [Multiline]
        public string DeveloperNotes = "A rational number";
    #endif
    
    //Declare Variables.
    public float value;
    public bool disableMaxValue = true;
    public float maxValue;
    public bool disableMinValue = true;
    public float minValue;
    //public bool resetValueAfterRestart = true;

    
    public void ChangeValue(float amount)
    {
        value = amount;
        CheckIfPastMinMaxLimit();
    }

    public void AddValue(float amount)
    {
        value += amount; //if you want to subtract just put a "-" in front of the amount
        CheckIfPastMinMaxLimit();
    }
    
    public void MultiplyValue(float amount)
    {
        value *= amount;
        CheckIfPastMinMaxLimit();
    }
    
    public void DivideValue(float amount)
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