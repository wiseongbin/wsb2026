using JetBrains.Annotations;
using UnityEngine;

public class CannonController : MonoBehaviour
{
        public GameObject shellPrefab;
        public Transform firetrans;

    GameObject shell;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
     {
            shell = Instantiate(shellPrefab, firetrans.position, firetrans.rotation);
            shell.GetComponent<ShellController>().Shoot(transform.up);
        }
    }
}
