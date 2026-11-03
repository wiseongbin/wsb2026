using UnityEngine;
using UnityEngine.InputSystem;

public class PaladinScripts : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float rotateSpeed = 100f;
    float move;
    float rotate;
    Rigidbody rb;
    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Mathf.Abs(move) > 0.1f || Mathf.Abs(rotate) > 0.1f)
        {
            Move();
            Rotate();
        }
        anim.SetFloat("Move", move);
    }

    void OnMove(InputValue value)
    {
        //Debug.Log("Input value : " + value.Get<float>());
        move = value.Get<float>();
    }

    void OnFire(InputValue value)
    {
        anim.SetTrigger("IsPunching");
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