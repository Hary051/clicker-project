using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{
    public Text count;
    private int number = 0;

    void OnMouseDown()
    {

        number++;
        Debug.Log("Clicked Count: " + number);
    }

}
