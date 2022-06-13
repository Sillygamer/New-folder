using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    //boundaries
    public static Prect lowerWall;
    public static Prect upperWall;
    public static Prect centerLine;
    private Color wallColor = new Color(1, 0, .5f, 1);
    private Color centerLineColor = new Color(0, 1.5f, 1, 0.5f);

    //paddleai stuff
    public static Vector2 ballLocation;

    //set initial balll speed
    public static float InitBallSpeed = 1;

    //gui.box
    private static Texture2D _staticRectTexture;
    private static GUIStyle _staticRectStyle;

    //scoring
    public static int LeftScore;
    public static int Rightscore;
    private Rect leftscoretext;
    private Rect rightscoretext;


    //colision
    public static List<Prect> colliderprects = new List<Prect>();

    // Start is called before the first frame update
    void Start()
    {

        upperWall = new Prect("Upper Wall", 0, 0, Screen.width, 10, true, "WALL");
        lowerWall = new Prect("Lower Wall", 0, Screen.height - 10, Screen.width, 10, true, "WALL");
        centerLine = new Prect("Center Wall", Screen.width / 2, 0, 5, Screen.height, false, "CTRLine");

        //colisionadd
        colliderprects.Add(upperWall);
        colliderprects.Add(lowerWall);

        LeftScore = 0;
        Rightscore = 0;
        leftscoretext = new Rect(20, 20, 20, 20);
        rightscoretext = new Rect(Screen.width - 30, 20, 20, 20);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACE");
            foreach(Prect p in colliderprects)
            {
                Debug.Log(p.name);
            }
        }
    }

    public static void GUIDrawRect(Rect position, Color color)
    {
        if(_staticRectTexture == null)
        {
            _staticRectTexture = new Texture2D(1, 1);
        }

        if(_staticRectStyle == null)
        {
            _staticRectStyle = new GUIStyle();
            _staticRectStyle.fontSize = 16;
        }

        _staticRectTexture.SetPixel(0, 0, color);
        _staticRectTexture.Apply();
        _staticRectStyle.normal.background = _staticRectTexture;
        GUI.Box(position, GUIContent.none, _staticRectStyle);
    }//end of draw rect
    private void OnGUI()
    {
        GUIDrawRect(centerLine.rect, centerLineColor);
        GUIDrawRect(upperWall.rect, wallColor);
        GUIDrawRect(lowerWall.rect, wallColor);
        GUIDrawRect(leftscoretext, centerLineColor, LeftScore.ToString());
        GUIDrawRect(rightscoretext, centerLineColor, Rightscore.ToString());

    }
    public static void GUIDrawRect(Rect position, Color color, string text)
    {
        if (_staticRectTexture == null)
        {
            _staticRectTexture = new Texture2D(1, 1);
        }

        if (_staticRectStyle == null)
        {
            _staticRectStyle = new GUIStyle();
            _staticRectStyle.fontSize = 16;
        }

        _staticRectTexture.SetPixel(0, 0, color);
        _staticRectTexture.Apply();
        _staticRectStyle.normal.background = _staticRectTexture;
        GUI.Box(position, text, _staticRectStyle);
    }
}
