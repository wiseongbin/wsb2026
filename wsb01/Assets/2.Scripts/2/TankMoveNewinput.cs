using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI.Table;

public class TankMoveNewinput : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float rotateSpeed = 2f;
    float move;
    float rotate;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Mathf.Abs(move) > 0.1f || Mathf.Abs(rotate) > 0.1f) 
        {
            Move();
            Rotate();
        }
    }

    void OnMove(InputValue value)
    {
        //Debug.Log("Input value : " + value.Get<float>());
        move = value.Get<float>();
    }


    void OnRotate(InputValue value)
    {
        rotate = value.Get<float>();
        Debug.Log("Rotate value : " + value.Get<float>());
    }

    void Move()
        {
            Vector3 moveDir = transform.forward * move * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + moveDir);
        }
    void Rotate()
    {
        float rotSpeed = rotate * rotateSpeed * Time.deltaTime;
        transform.Rotate(0f, rotSpeed, 0f);
    }
}

   