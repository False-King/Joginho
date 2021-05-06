using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int width, height;
    [SerializeField] GameObject bloco;
    void Start()
    {
        generation();

    }
    void generation()
    {
        for (int x = 0; x<width; x++)
        {
            Instantiate(bloco, new Vector2(x, height), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
