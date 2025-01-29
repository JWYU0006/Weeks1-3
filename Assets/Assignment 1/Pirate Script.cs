using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PirateScript : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    Vector2 initialPos;
    // Start is called before the first frame update
    void Start()
    {
        curve = new AnimationCurve();       //initialize animationcurve
        curve.AddKey(new Keyframe(0, 0));   //first key frame, 0 second, move 0 downwards
        curve.AddKey(new Keyframe(1, 4));   //second key frame, 1 second, move 4 downwards.
        initialPos = transform.position;    //store initial position
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;    //curve time
        Vector2 pos = transform.position;
        pos.y = initialPos.y - curve.Evaluate(t) * (transform.localScale.x);    //initial position subtract curve value to get current position. Multiplying local scale can reduce the distance of movement and create a perspective effect.
        pos.x = initialPos.x - 10 * t * (transform.localScale.x);    //the value of the speed multiply time get the distance,
        transform.position = pos;
    }
}
