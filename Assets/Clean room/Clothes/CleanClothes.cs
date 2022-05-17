using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanClothes : MonoBehaviour
{
    public GameObject newClothes;
    public GameObject messyClothes;
    public bool clothesCleaned;

    private void Start()
    {
        newClothes.SetActive(false);
    }
    public void clothesClicked()
    {
        Destroy(messyClothes);
        newClothes.SetActive(true);
        clothesCleaned = true;
    }
}
