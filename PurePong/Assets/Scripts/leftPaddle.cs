using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPaddle : MonoBehaviour
{
    public float scaler = 2;
    public Prect paddleL;
    private Color LpaddleColor = new Color(1, 1, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        paddleL = new Prect("Left Paddle", 50, 100, 10, 30, true, "PADDLE");
        Manager.colliderprects.Add(paddleL);
    }

    // Update is called once per frame
    void Update()
    {
        paddleL.rect.y += -scaler * Input.GetAxis("Vertical");
        if (paddleL.rect.y < 10) paddleL.rect.y = 10;
        if (paddleL.rect.y > Screen.height - 40) paddleL.rect.y = Screen.height - 40;
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(paddleL.rect, LpaddleColor);
    }
}
