using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{//Sets rules for text
   [TextArea(10,14)] [SerializeField] string strStoryText;

}
