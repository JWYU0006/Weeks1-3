using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 6f;    //speed setting
    public AnimationCurve lightCurve;
    float horizontal;   //A/D, return 1 or -1 which represent the direction
    float vertical;     //W/S
    Camera cam;
    Vector2 screenBound;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;  //use cam to store Camera.main
        screenBound = cam.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));  //get screen size and convert it into world coordinate scale
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        horizontal = Input.GetAxisRaw("Horizontal"); // get input of A/D
        vertical = Input.GetAxisRaw("Vertical");     // W/S
        Vector2 direction = new Vector2(horizontal, vertical).normalized;  //convert 2 float above into a vector 3, keep z, use normalized to keep speed same in any direction
        pos += direction * speed * Time.deltaTime;  //use deltaTime to keep movement speed consistent regardless of frame rate.
        float clampX = Mathf.Clamp(pos.x, -screenBound.x, screenBound.x);    //set max and min value, keep sprite stay in screen.
        float clampY = Mathf.Clamp(pos.y, -screenBound.y, screenBound.y);
        pos = new Vector2(clampX, clampY);
        transform.position = pos;
        Debug.Log(direction);
    }
}
