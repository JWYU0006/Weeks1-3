using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 6f;    //speed setting
    public AnimationCurve lightCurve;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // A/D, return 1 or -1 which represent the direction
        float vertical = Input.GetAxisRaw("Vertical");     // W/S
        Vector3 direction = new Vector3(horizontal, vertical, transform.position.z).normalized;  //convert 2 float above into a vector 3, keep z, use normalized to keep speed same in any direction
        transform.position += direction * speed * Time.deltaTime;   //use deltaTime to keep movement speed consistent regardless of frame rate.
        Debug.Log(direction);
    }
}
