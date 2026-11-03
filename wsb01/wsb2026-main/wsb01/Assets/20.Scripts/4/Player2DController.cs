using UnityEngine;
using UnityEngine.InputSystem;

public class Player2DController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnFire(InputValue value)
    {

        anim.SetTrigger("IsFire");
    }
}