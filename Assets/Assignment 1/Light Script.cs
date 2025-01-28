using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //light follow mouse
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);    //get mouse position and convert into world coordinate
        Vector2 direction = transform.position - mouse;     //calculate a vector from the center point to the mouse position
        //another way to rotate
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //angle += 90;    //The light is placed vertically downward, 90 degrees away from the mouse position.
        //float clamp = Mathf.Clamp(angle, -50, 50);      //set max and min angle
        //transform.rotation = Quaternion.Euler(0, 0, angle);     //set transform rotation value
        transform.up = direction;
    }
}
