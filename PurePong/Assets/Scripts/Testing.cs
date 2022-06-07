using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private Rect testbox;
    private Color c;
    private int xpos, ypos;


    // Start is called before the first frame update
    void Start()
    {
        testbox = new Rect(10, 10, 100, 200);
        c = new Color(1, 0.5f, 0);
        xpos = 0;
        ypos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        xpos++;
        ypos++;
        testbox.x = xpos;
        testbox.y = ypos;
    }
    private void OnGUI()
    {
        Manager.GUIDrawRect(testbox, c);
    }
}
