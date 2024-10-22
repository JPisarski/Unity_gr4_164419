using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_5 : MonoBehaviour
{
    public GameObject kostka;
    public int liczba = 10;
    private HashSet<Vector3> zajete_miejsca = new HashSet<Vector3>();


    void Start()
    {
        while(zajete_miejsca.Count < liczba)
        {
            Vector3 miejsce = new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(-4.5f, 4.5f));

            if (!zajete_miejsca.Contains(miejsce))
            {
                zajete_miejsca.Add(miejsce);
                Instantiate(kostka, miejsce, Quaternion.identity);
            }       
        }
    }
    
    void Update()
    {
        
    }
}
