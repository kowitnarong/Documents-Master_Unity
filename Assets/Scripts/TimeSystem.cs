using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{
    public string NameCheck;
    public GameObject TimeBG;
    public GameObject TimeObject;

    // Update is called once per frame
    void Update()
    {
        if (ItemSystem.Destroy1 == true && NameCheck == "Destroy1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device3_1 == true && NameCheck == "Device3_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID1 == true && NameCheck == "Device1_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID2 == true && NameCheck == "Device2_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID3 == true && NameCheck == "Device4_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID4 == true && NameCheck == "Device5_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device8_1 == true && NameCheck == "Device8_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID5 == true && NameCheck == "Device5_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID6 == true && NameCheck == "Device3_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID7 == true && NameCheck == "Device1_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID8 == true && NameCheck == "Device2_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device4_1 == true && NameCheck == "Device4_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID10 == true && NameCheck == "Device5_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID11 == true && NameCheck == "Device1_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID12 == true && NameCheck == "Device2_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Destroy1 == false || ItemSystem.Device3_1 == false
            || ItemSystem.itemID1 == false || ItemSystem.itemID2 == false
            || ItemSystem.itemID3 == false || ItemSystem.itemID4 == false
            || ItemSystem.Device8_1 == false || ItemSystem.itemID5 == false
            || ItemSystem.itemID6 == false || ItemSystem.itemID7 == false
            || ItemSystem.itemID8 == false || ItemSystem.Device4_1 == false
            || ItemSystem.itemID10 == false || ItemSystem.itemID11 == false
            || ItemSystem.itemID12 == false)
        {
            TimeObject.GetComponent<Image>().fillAmount = 0;
            TimeObject.GetComponent<TimeCount>().timeLeft = 0;
            TimeBG.SetActive(false);
        }
    }
}
