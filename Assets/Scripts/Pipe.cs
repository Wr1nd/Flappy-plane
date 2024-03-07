using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1;

    private void Start()
    {
        float randomY = Random.Range(-2.5f, 2.5f);
        var x = transform.position.x + Random.Range(-1f, 1.1f);
        transform.position = new Vector3(transform.position.x, randomY, transform.position.z);
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
            
        }
    }
}
