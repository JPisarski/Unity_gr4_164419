using UnityEngine;
using System.Collections;

public class Kwadrat : MonoBehaviour
{
    public float speed = 2.0f;
    private int kierunek = 1;
    

    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        
        if(kierunek == 1 && transform.position.z <= 10.0f)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if(transform.position.z >= 10.0f)
            {
                transform.Rotate(0, 90, 0, Space.Self);
                kierunek = 2;
            }
        }
        if (kierunek == 2 && transform.position.x <= 10.0f)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if (transform.position.x >= 10.0f)
            {
                transform.Rotate(0, 90, 0, Space.Self);
                kierunek = 3;
            }
        }
        if (kierunek == 3 && transform.position.z >= 0.0f)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if (transform.position.z <= 0.0f)
            {
                transform.Rotate(0, 90, 0, Space.Self);
                kierunek = 4;
            }
        }
        if (kierunek == 4 && transform.position.x >= 0.0f)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if (transform.position.x <= 0.0f)
            {
                transform.Rotate(0, 90, 0, Space.Self);
                kierunek = 1;
            }
        }
    }
}