using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos2 = transform.position;
        pos2.x += speed;
        if (pos2.x >= Screen.width/2)
        {
            pos2.x = -12;
        }
        transform.position = pos2;
    }
}
