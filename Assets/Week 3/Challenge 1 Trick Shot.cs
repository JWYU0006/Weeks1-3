using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge1TrickShot : MonoBehaviour
{
    float speed = 0.005f;
    public AnimationCurve curve;
    [Range(0, 1)]
    float t;
    bool jumpStat = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        Vector2 inScreenPos = Camera.main.WorldToScreenPoint(pos);
        if (inScreenPos.x < 0 || inScreenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
        if (Input.GetKey(KeyCode.Space))
        {
            jumpStat = true;
        }
        if (jumpStat)
        {
            Jump();
        }
        Debug.Log(t);
    }

    void Jump()
    {
        t += 2 * Time.deltaTime;
        if (t > 1)
        {
            t = 0;
            jumpStat = false;
        }
        transform.position = new Vector2(transform.position.x, curve.Evaluate(t));
    }
}
