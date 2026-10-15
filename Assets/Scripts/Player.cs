using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public KeyCode up;
    public KeyCode down;
    public float speedMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.GetComponent<Transform>().position;
        if (Input.GetKey(up) && pos.y < 3.31)
        {
            pos.y += Time.deltaTime * speedMovement;
            this.GetComponent<Transform>().position = pos;
        }
        if (Input.GetKey(down) && pos.y > - 3.11)
        {
            pos.y -= Time.deltaTime * speedMovement;
            this.GetComponent<Transform>().position = pos;
        }
    }
}
