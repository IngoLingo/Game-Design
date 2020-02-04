using UnityEngine;

public class CheckBoolData : MonoBehaviour
{
    public BoolData boolDataObj;

    void Update()
    {
        if (boolDataObj.value) 
        {
            print(true);
            //do true work
        }
        else
        {
            //do false work
        }
    }
}
