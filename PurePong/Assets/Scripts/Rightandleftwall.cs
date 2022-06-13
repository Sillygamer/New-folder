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
        lWall = new Prect("r Wall", 0, 0,10, Screen.height, true, "WALL2");
        rWall = new Prect("L Wall",Screen.width - 10, 0, 10, Screen.height, true, "WALL2");

        mana2.colliderprects.Add(rWall);
        mana2.colliderprects.Add(lWall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        mana2.GUIDrawRect(lWall.rect,wallColor);
        mana2.GUIDrawRect(rWall.rect, wallColor);
    }
}
