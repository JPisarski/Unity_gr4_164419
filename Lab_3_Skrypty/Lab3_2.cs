using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
    public float speed = 2.0f;
    private int kierunek = 1;
    

    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        
        if(kierunek == 1 && transform.position.x <= 10.0f)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            kierunek = 0;
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if (transform.position.x <= 0.0f)
            {
                kierunek = 1;
            }
        }
    }
}