using UnityEngine;
using UnityEngine.InputSystem; // 이 namespace가 필요합니다.

public class TankMoveEvnet : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 150f;
    float move;
    float rotate;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.freezeRotation = true;
        }
    }

    private void FixedUpdate()
    {
        // 값이 잘 들어오는지 디버그로 확인해보세요
        Move();
        Rotate();
    }

    // Input System에서 Send Messages나 Invoke Unity Events 방식을 쓸 때 사용
    public void OnTankMove(InputValue value)
    {
        move = value.Get<float>();
        Debug.Log("move value : " + move);
    }

    public void OnTankRotate(InputValue value)
    {
        rotate = value.Get<float>();
        Debug.Log("Rotate value : " + rotate);
    }

    void Move()
    {
        if (rb == null) return;

        Vector3 moveDir = transform.forward * move * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDir);
    }

    void Rotate()
    {
        float rotSpeed = rotate * rotateSpeed * Time.fixedDeltaTime;
        transform.Rotate(0f, rotSpeed, 0f);
    }
}