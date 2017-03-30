using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] dialogue = {"Are you here?\nPress Enter...",
         "It's time to show our museum.\nPress Enter...",
         ", you can turn around and using the trigger button to move and stop.\nPress Enter..."};
    int index = 0;
    Rect dialogueRect = new Rect(435, 100, 500, 50);
    


    void Update()
    {
        if (Input.anyKeyDown)
        {
            index++;
        }
    }

    void OnGUI()
    {
        if (index < dialogue.Length)
        {
            GUI.Box(dialogueRect, dialogue[index]);

        }
        else
        {
        }
    }
}