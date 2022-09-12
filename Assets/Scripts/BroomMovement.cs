using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomMovement : MonoBehaviour
{
    //Angle
    float angleX=-90;

    float angleY=270;

    float angleZ=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveStraightForward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveStraightBackward();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRightRot();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeftRot();
        }
    }
    void MoveUp()
    {
        
        transform.position += new Vector3(0,5f * Time.deltaTime,0);
    }
    void MoveDown()
    {

        transform.position -= new Vector3(0, 5f * Time.deltaTime, 0);
    }
    void MoveRightRot()
    {
        angleZ += 60f * Time.deltaTime;
        transform.eulerAngles= new Vector3(angleX,angleY,angleZ);
    }
    void MoveLeftRot()
    {
        angleZ -= 60f * Time.deltaTime;
        transform.eulerAngles=new Vector3(angleX, angleY, angleZ);
    }
    void MoveStraightBackward()
    {
        transform.position += transform.up*25f*Time.deltaTime;
    }

    void MoveStraightForward()
    {
        transform.position -= transform.up * 25f * Time.deltaTime;
    }
}

