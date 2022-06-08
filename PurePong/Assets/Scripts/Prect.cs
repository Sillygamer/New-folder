using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prect 
{
    public string name;
    public Rect rect;
    public int x, y, w, h;
    public bool hasColision;
    public string tag;

    //default
    public Prect()
    {
    }

    public Prect(string NAME, int X, int Y, int W, int H, bool HASCOLISION, string TAG)
    {
        this.name = NAME;
        this.x = X;
        this.y = Y;
        this.w = W;
        this.h = H;
        this.hasColision = HASCOLISION;
        this.tag = TAG;
        rect.x = x;
        rect.y = y;
        rect.width = w;
        rect.height = h;

    }
}
