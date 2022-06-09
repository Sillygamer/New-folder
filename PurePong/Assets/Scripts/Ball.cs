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
        CheckCollisions(ball);
        CheckOutOfBounds(ball);
        Manager.ballLocation = new Vector2(ball.rect.x, ball.rect.y);
    }

    private void CheckCollisions(Prect b)
    {
        foreach(Prect target in Manager.colliderprects)
        {
            if (b.rect.Overlaps(target.rect))
            {
                Debug.Log("Cilided with" + target.name);
                if(target.tag == "WALL")
                {
                    ballVelocity.y = -ballVelocity.y;
                }
                if(target.tag == "PADDLE")
                {
                    ballVelocity.x = -ballVelocity.x;
                }

                //increasesped
                speed *= 1;
            }
        }
    }

    private void CheckOutOfBounds(Prect b)
    {
        if(b.rect.x < 0)
        {
            BallReset();
        }
        if(b.rect.x > Screen.width)
        {
            BallReset();
        }
    }

    private void BallReset()
    {
        int vely = 0;
        int velx = 0;
        int negpos = 2;
        negpos = Random.Range(0, 1);
        velx = Random.Range(-3, 3);
        vely = Random.Range(-3, 3);
        if (velx == 0 && negpos == 1) velx = Random.Range(1, 3);
        if (velx == 0 && negpos == 0) velx = Random.Range(1, 3);
        if (vely == 0 && negpos == 1) vely = Random.Range(-3, -1);
        if (vely == 0 && negpos == 0) vely = Random.Range(-3, -1);
        ballVelocity = new Vector2(velx, vely);
        ball.rect.x = Screen.width / 2;
        ball.rect.y = Screen.height / 2;
        speed = Manager.InitBallSpeed;
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(ball.rect, ballColor);
    }
}
