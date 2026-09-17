using UnityEngine;
using UnityEngine.InputSystem;

public class TankMoveEvnet : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 150f; // 회전 속도를 키웠습니다!
    float move;
    float rotate;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.freezeRotation = true; // 물리 회전으로 인해 탱크가 쓰러지는 것 방지
        }
    }

    // 물리 이동은 Update 대신 FixedUpdate를 사용하는 것이 정석입니다.
    private void FixedUpdate()
    {
        if (Mathf.Abs(move) > 0.1f || Mathf.Abs(rotate) > 0.1f)
        {
            Move();
            Rotate();
        }
    }

    public void OnTankMove(float value)
    {
        move = value;
        Debug.Log("move value : " + move);
    }

    public void OnTankRotate(float value)
    {
        rotate = value;
        Debug.Log("Rotate value : " + rotate);
    }

    void Move()
    {
        if (rb == null) return;

        // FixedUpdate에서는 Time.fixedDeltaTime을 사용하는 것이 좋습니다.
        Vector3 moveDir = transform.forward * move * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDir);
    }

    void Rotate()
    {
        float rotSpeed = rotate * rotateSpeed * Time.fixedDeltaTime;
        transform.Rotate(0f, rotSpeed, 0f);
    }
}