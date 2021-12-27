using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof (Rigidbody))]
[RequireComponent(typeof(Animator))]


public class VikingController : MonoBehaviour
{
    public Vector3 movingDirection;
    [SerializeField]float movingSpeed = 10f;
    Rigidbody rb;
    Animator animator;
    bool onGround = true, run = false;
    int degree = 1000;
    // Start is called before the first frame update
    void Start()
    {
        Transform t = GetComponent<Transform>();
        transform.position = Vector3.one;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        run = false;
        if(Input.GetKey(KeyCode.W))
        {
            if(degree%4 == 0)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            }
            else if (degree % 4 == 1)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
            }
            else if (degree % 4 == 2)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
            }
            else if (degree % 4 == 3)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
            }

            run = true;
        }
        if (Input.GetKey(KeyCode.A))
        {

            if (degree % 4 == 0)
            {
                transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
            }
            else if (degree % 4 == 1)
            {
                transform.rotation = Quaternion.Euler(0.0f, -180.0f, 0.0f);
            }
            else if (degree % 4 == 2)
            {
                transform.rotation = Quaternion.Euler(0.0f, -270.0f, 0.0f);
            }
            else if (degree % 4 == 3)
            {
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }
            degree++;
            run = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (degree % 4 == 0)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
            }
            else if (degree % 4 == 1)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
            }
            else if (degree % 4 == 2)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            }
            else if (degree % 4 == 3)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
            }
            run = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (degree % 4 == 0)
            {
                transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            }
            else if (degree % 4 == 1)
            {
                transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            }
            else if (degree % 4 == 2)
            {
                transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
            }
            else if (degree % 4 == 3)
            {
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }
            
            degree--;
            run = true;
        }
        animator.SetBool("Run", run);
    }
}
