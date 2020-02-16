using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{//Allows us to acces a text compnenet
    [SerializeField] Text txtcomponent;
    [SerializeField] State startingstate;
    //Type class and all the info
    State state;
    // Start is called before the first frame update
    void Start()
    {//gets the state and retuns its current value
        state = startingstate;
        txtcomponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
