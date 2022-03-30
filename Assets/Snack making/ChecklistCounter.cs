using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistCounter : MonoBehaviour
{
    ChecklistFridge fridgelist;
    public GameObject spawnButter;
    public GameObject spawnBread;
    public GameObject butter;
    public GameObject bread;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fridgelist.gotButter)
        {
            Instantiate(butter, transform.position, Quaternion.identity);
        }
        if (fridgelist.gotBread)
        {
            Instantiate(butter, transform.position, Quaternion.identity);
        }
    }
}
