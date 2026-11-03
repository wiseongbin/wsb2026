using UnityEngine;
using UnityEngine.InputSystem;

public class CanonNewinput : MonoBehaviour
{
    public GameObject shellPrefab;
    public Transform firetrans;

    GameObject shell;

    void OnFire(InputValue value)
    {
        shell = Instantiate(shellPrefab, firetrans.position, firetrans.rotation);
        shell.GetComponent<ShellController>().Shoot(transform.up);
    }
}
