using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPaddle : MonoBehaviour
{
    public float scaler = .5f;
    public Prect paddleR;
    private Color RpaddleColor = new Color(1, 1, 0, 1);
    private static Prect paddlep;

    // Start is called before the first frame update
    void Start()
    {
        paddleR = new Prect("Right Paddle",700, 100, 10, 60, true, "PADDLE");
        Manager.colliderprects.Add(paddleR);
    }

    // Update is called once per frame
    void Update()
    {


        if(Manager.ballLocation.x > Screen.width / 2)
        {
            if(Manager.ballLocation.y > paddleR.rect.y)
            {
                if (paddleR.rect.y < 10) paddleR.rect.y = 10;
                if (paddleR.rect.y > Screen.height - 70) paddleR.rect.y = Screen.height - 70;
                paddleR.rect.y += scaler;
            }
            if (Manager.ballLocation.y < paddleR.rect.y)
            {
                if (paddleR.rect.y < 10) paddleR.rect.y = 10;
                if (paddleR.rect.y > Screen.height - 65) paddleR.rect.y = Screen.height - 65;
                paddleR.rect.y -= scaler;
            }
            // paddleR.rect.y = Manager.ballLocation.y - 15;
        }

    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(paddleR.rect, RpaddleColor);
    }
    public static void End()
    {
        paddlep = new Prect("Right Paddle", 700, 100, 10, 600, true, "PADDLE");
        Manager.colliderprects.Add(paddlep);
    }
}
