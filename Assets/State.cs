using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{//Sets rules for text
   [TextArea(14,10)] [SerializeField] string strStoryText;
    //Calls to gain information on the sate of the story
    public string GetStateStory()
    {//Tells where the state of the story is at
        return strStoryText;
    }

}
