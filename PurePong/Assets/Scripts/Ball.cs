using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 ballVelocity;
    public Vector2 ballLoc;
    public float speed;
    public Prect ball;
    private Color ballColor = new Color(0, 1, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        ball = new Prect("Ball", Screen.width / 2, Screen.height / 2, 10, 10, true, "BALL");
        ballVelocity = new Vector2(3, 3);
        ballLoc = new Vector2(ball.rect.x, ball.rect.y);
        speed = Manager.InitBallSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        ball.rect.x += speed * ballVelocity.normalized.x;
        ball.rect.y += speed * ballVelocity.normalized.y;

        Manager.ballLocation = new Vector2(ball.rect.x, ball.rect.y);
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(ball.rect, ballColor);
    }
}
