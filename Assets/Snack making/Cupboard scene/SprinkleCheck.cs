using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SprinkleCheck : MonoBehaviour
{
    public GameObject sprinkleObject;

    public GameObject noSprinkles;
    public GameObject sprinkleCollected;

    // Start is called before the first frame update
    void Start()
    {
        noSprinkles.SetActive(true);
        sprinkleCollected.SetActive(false);
    }

    void OnMouseDown()
    {
        sprinkleObject.SetActive(false);
        noSprinkles.SetActive(false);
        sprinkleCollected.SetActive(true);
    }
}
