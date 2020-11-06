using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifieMovement : MonoBehaviour
{
    public Rules rules;
    //should be the board

    public bool LifieSide = false;

    private KeyCode Up, Left, Down, Right;
    private int WalkLength;

    void Start()
    {
        if (LifieSide)
        {
            Up = KeyCode.UpArrow;
            Left = KeyCode.LeftArrow;
            Down = KeyCode.DownArrow;
            Right = KeyCode.RightArrow;
        }
        else
        {
            Up = KeyCode.W;
            Left = KeyCode.A;
            Down = KeyCode.S;
            Right = KeyCode.D;
        }
        WalkLength = 1;
    }

    void Update()
    {
        if (rules.turn == LifieSide)
        {
            if (Input.GetKeyDown(Up))
            {
                Walk(-WalkLength, 0, 0);
            }
            if (Input.GetKeyDown(Left))
            {
                Walk(0, 0, -WalkLength);
            }
            if (Input.GetKeyDown(Down))
            {
                Walk(WalkLength, 0, 0);
            }
            if (Input.GetKeyDown(Right))
            {
                Walk(0, 0, WalkLength);
            }


        }

    }

    void Walk(float x, float y, float z)
    {
        Vector3 Vector3save = transform.position;
        transform.position += new Vector3(x, y, z);
        if (transform.position.z < -3.5 || transform.position.z > 4.30 ||
            transform.position.x < -4.30 || transform.position.x > 4)
        {
            //rollback movement
            transform.position = Vector3save;
        }
        else
        {
            //commit movement
            rules.ChangeTurn(!LifieSide);
        }
    }
}
