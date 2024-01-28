using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    Vector3 initialPosition;

    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    public void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }

    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<Rigidbody2D>().gravityScale = 1;
        Vector3 direction = initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(direction * 120);
    }

    public void Update()
    {
        if (transform.position.x < -20 || transform.position.x > 20 || transform.position.y > 10)
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
