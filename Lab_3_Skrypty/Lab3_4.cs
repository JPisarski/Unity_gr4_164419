using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzalki : MonoBehaviour
{
    public float speed = 2.0f;


    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        float gd = Input.GetAxis("Horizontal");
        float lp = Input.GetAxis("Vertical");

        Vector3 przemieszczenie = new Vector3(gd, 0, lp);
        przemieszczenie = przemieszczenie.normalized * speed * Time.deltaTime;
        transform.position += przemieszczenie;
    }
}
