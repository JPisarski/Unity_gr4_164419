using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int ile;
    public Material[] kolory;
    int objectCounter = 0;
    public GameObject block;
    private Renderer Platforma;

    void Start()
    {
        Platforma = GetComponent<Renderer>();
        Bounds zakres = Platforma.bounds;
        for (int i = 0; i < ile; i++)
        {
            float pozycja_x = UnityEngine.Random.Range(zakres.min.x, zakres.max.x);
            float pozycja_y = UnityEngine.Random.Range(zakres.min.y, zakres.max.y);
            float pozycja_z = UnityEngine.Random.Range(zakres.min.z, zakres.max.z);
            this.positions.Add(new Vector3(pozycja_x, (pozycja_y+0.5f), pozycja_z));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("Wywo³ano coroutine");
        foreach (Vector3 pos in positions)
        {
            GameObject kostka = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            kostka.GetComponent<Renderer>().material = kolory[UnityEngine.Random.Range(0, 5)];
            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}
