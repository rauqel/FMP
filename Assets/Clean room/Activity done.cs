using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Activitydone : MonoBehaviour
{
    CleanBed bed;
    CleanClothes clothes;
    CleanDesk desk;
    CleanLitter litter;
    CleanPlushies plush;

    // Update is called once per frame
    void Update()
    {
        if(bed.bedCleaned && clothes.clothesCleaned && desk.deskCleaned && litter.wrappersCleaned && plush.plushCleaned)
        {
            //allow player to progress
        }
    }
}
