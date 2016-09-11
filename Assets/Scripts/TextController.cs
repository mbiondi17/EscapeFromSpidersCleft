using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States { caveMouth, WebWall_0, DarkTunnel, DimlyLitTunnel}
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.caveMouth;
        text.alignment = TextAnchor.UpperCenter;
	}
	
	// Update is called once per frame
	void Update () {
        if (myState == States.caveMouth)
        {
            state_caveMouth();
        }
        else if (myState == States.WebWall_0)
        {
            state_WebWall_0;
        }
    }

    void state_caveMouth()
    {
        text.text = "It is dark, and the air wet. Your hands graze the walls of the cave as you grasp your way around another corner. " +
            "You hear something skitter across rock. The echoing of each sound off the cave walls makes the judgment of distance " +
            "difficult. You can barely see, but your eyes can make out three paths diverging in front of you. They are, for all " +
            "you can tell, utterly indistinguishable from each other.\n\n" +

            "L to take Left path, M to take Middle path, R to take Right path";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.WebWall_0;
        }
    }

    void state_WebWall_0()
    {

        text.text = "You huff a deep breath and head down the left path. You don't get very far before the hand you use for guidance " +
                    "comes in contact with something thick and sticky. "
    }
}
