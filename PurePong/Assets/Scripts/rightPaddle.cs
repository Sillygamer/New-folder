using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPaddle : MonoBehaviour
{
    public float scaler = 2;
    public Prect paddleR;
    private Color RpaddleColor = new Color(1, 1, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        paddleR = new Prect("Right Paddle",700, 100, 10, 30, true, "PADDLE");
    }

    // Update is called once per frame
    void Update()
    {
        paddleR.rect.y += -scaler * Input.GetAxis("Vertical");
        if (paddleR.rect.y < 10) paddleR.rect.y = 10;
        if (paddleR.rect.y > Screen.height - 40) paddleR.rect.y = Screen.height - 40;
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(paddleR.rect, RpaddleColor);
    }
}
