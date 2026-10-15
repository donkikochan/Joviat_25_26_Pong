using UnityEngine;

public class Ball : MonoBehaviour
{
    public float force = 10f;
    private Vector2 InitialPosition;

    private float timer = 0f;
    private bool flag = false; 
    public float timeToRest = 2f;
    
    void Start()
    { 
        //position = this.GetComponent<Transform>().position;
        InitialPosition = transform.position;

        ThrowBall();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        Debug.Log("Ball reset");
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        //rb.linearVelocity = new Vector2(0, 0);
        rb.linearVelocity = Vector2.zero;
        transform.position = InitialPosition;
        Invoke("ThrowBall",timeToRest);

    }


    void ThrowBall()
    {
        Rigidbody2D r = this.GetComponent<Rigidbody2D>();
        Vector2 rand = Random.insideUnitCircle.normalized;
        r.AddForce(rand*force);
    }
}
