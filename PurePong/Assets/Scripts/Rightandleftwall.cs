using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightandleftwall : MonoBehaviour
{
    public static Prect rWall;
    public static Prect lWall;

    private Color wallColor = new Color(1, 0, .5f, 1);

    // Start is called before the first frame update
    void Start()
    {
        lWall = new Prect("Upper Wall", 0, 0, Screen.width, 10, true, "WALL");
        rWall = new Prect("Lower Wall", 0, Screen.height - 10, Screen.width, 10, true, "WALL");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
