using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivityDone : MonoBehaviour
{
    public BedClean bed;
    public CleanClothes clothes;
    public DeskClean desk;
    public LitterController litter;
    public PlushController plush;

    // Update is called once per frame
    void Update()
    {
        if(bed.bedCleaned && clothes.clothesCleaned && desk.cleanedDesk && litter.litterCleaned && plush.plushCleaned)
        {
            //SceneManager.LoadScene("MainScene");
        }
    }
}
