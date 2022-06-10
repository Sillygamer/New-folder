using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPaddle : MonoBehaviour
{
    public float scaler = .5f;
    public Prect paddleL;
    private Color LpaddleColor = new Color(1, 1, 0, 1);
    private static Prect paddlep;

    // Start is called before the first frame update
    void Start()
    {
        paddleL = new Prect("Left Paddle", 50, 100, 10, 60, true, "PADDLE");
        Manager.colliderprects.Add(paddleL);
    }

    // Update is called once per frame
    void Update()
    {
        paddleL.rect.y += -scaler * Input.GetAxis("Vertical");
        if (paddleL.rect.y < 10) paddleL.rect.y = 10;
        if (paddleL.rect.y > Screen.height - 65) paddleL.rect.y = Screen.height - 65;
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(paddleL.rect, LpaddleColor);
    }
    public static void End()
    {
        paddlep = new Prect("Right Paddle", 700, 100, 10, 6000, true, "PADDLE");
        Manager.colliderprects.Add(paddlep);
    }
}
