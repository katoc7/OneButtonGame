using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matriz : MonoBehaviour

{
    public float maxTi = 1;
    private float timer = 0;
    public float height;
    public GameObject shark;
    public GameObject[] myArray;    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var element = myArray[Random.Range(0, myArray.Length)];
        if (timer > maxTi)
        {
            GameObject newShark = Instantiate(element);
            newShark.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newShark, 15);
            timer = 0;
        }

        timer += Time.deltaTime;

    }


    


 
}
