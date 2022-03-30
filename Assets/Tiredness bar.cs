using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tirednessbar : MonoBehaviour
{
    public Slider fatigueBar;
    int maxFatigue = 100;
    int currentFatigue;

    // Start is called before the first frame update
    void Start()
    {
        currentFatigue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
