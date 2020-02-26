// ----------------------------------------------------------------------------
// Create_4DirectionCollisionCheck
// This will return a collsion check for a 4 directional movement (North, East, South, West)
//
// Credits:  Nathan Ethington
// Date:   02/25/2020
// ----------------------------------------------------------------------------
using UnityEngine;

[CreateAssetMenu(fileName = "Create_4DirectionCollisionCheck", menuName = "Create Collision/4 Direction Check")]
public class Create_4DirectionCollisionCheck : ScriptableObject
{
    //Creates a box in the inspector for developers to make notes on what the created scriptable object is.
    #if UNITY_EDITOR
        [Multiline]
        public string DeveloperNotes = "Check the collision in 4 directions";
    #endif

    public bool North = false;
    public bool East = false;
    public bool South = false;
    public bool West = false;

    //To False
    public void FalseNorth()
    {
        North = false;
    }
    public void FalseEast()
    {
        East = false;
    }
    public void FalseSouth()
    {
        South = false;
    }
    public void FalseWest()
    {
        West = false;
    }

    //To True
    public void TrueNorth()
    {
        North = true;
    }
    public void TrueEast()
    {
        East = true;
    }
    public void TrueSouth()
    {
        South = true;
    }
    public void TrueWest()
    {
        West = true;
    }

    //Reverse
    public void ReverseNorth()
    {
        North = !North;
    }
    public void ReverseEast()
    {
        East = !East;
    }
    public void ReverseSouth()
    {
        South = !South;
    }
    public void ReverseWest()
    {
        West = !West;
    }
}
