using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;

    private Rigidbody rigidbody;
    private Vector3 scale;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        /*Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();*/

        float moveHorizontal = Input.acceleration.x;
        float moveVertical = -Input.acceleration.z;

        rigidbody.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed * Time.deltaTime);
    }
 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            GameManager.instance.coins++;
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            GameManager.instance.SetCoinText();
        }

        if (other.tag == "KillPlane")
        {
            gameObject.SetActive(false);
            GameManager.instance.SetLoseCanvas();
        }
    }
}
