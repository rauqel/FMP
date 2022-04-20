using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBread : MonoBehaviour
{
    public GameObject breadLoaf;
    public GameObject breadSlice;

    public Animator SliceToLife;

    public bool breadActive;

    // Start is called before the first frame update
    void Start()
    {
        breadSlice.SetActive(false);

        SliceToLife = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        breadSlice.SetActive(true);
        SliceToLife.Play("BreadCollection");
    }

    // Update is called once per frame
    void Update()
    {
        if (breadSlice.activeSelf)
        {
            breadActive = true;
        }
    }
}
