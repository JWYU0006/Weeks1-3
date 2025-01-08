using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos2 = transform.position;
        pos2.x += speed;
        Vector2 squareInScreenPos = Camera.main.WorldToScreenPoint(pos2);
        if (squareInScreenPos.x < 0 || squareInScreenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos2;
    }
}
