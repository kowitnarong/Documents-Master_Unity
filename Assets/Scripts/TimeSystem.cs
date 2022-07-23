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
        else if (ItemSystem.Destroy2 == true && NameCheck == "Destroy2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device3_1 == true && NameCheck == "Device3_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device3_2 == true && NameCheck == "Device3_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device3_3 == true && NameCheck == "Device3_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID1_1 == true && NameCheck == "Device1_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID1_2 == true && NameCheck == "Device1_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID2_1 == true && NameCheck == "Device2_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID2_2 == true && NameCheck == "Device2_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID2_3 == true && NameCheck == "Device2_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID3_1 == true && NameCheck == "Device4_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID3_2 == true && NameCheck == "Device4_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID4_1 == true && NameCheck == "Device5_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID4_2 == true && NameCheck == "Device5_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID4_3 == true && NameCheck == "Device5_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device8_1 == true && NameCheck == "Device8_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID5_1 == true && NameCheck == "Device5_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID5_2 == true && NameCheck == "Device5_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID5_3 == true && NameCheck == "Device5_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID6_1 == true && NameCheck == "Device3_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID6_2 == true && NameCheck == "Device3_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID6_3 == true && NameCheck == "Device3_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID7_1 == true && NameCheck == "Device1_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID7_2 == true && NameCheck == "Device1_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID8_1 == true && NameCheck == "Device2_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID8_2 == true && NameCheck == "Device2_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID8_3 == true && NameCheck == "Device2_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device4_1 == true && NameCheck == "Device4_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Device4_2 == true && NameCheck == "Device4_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID10_1 == true && NameCheck == "Device5_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID10_2 == true && NameCheck == "Device5_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID10_3 == true && NameCheck == "Device5_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID11_1 == true && NameCheck == "Device1_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID11_2 == true && NameCheck == "Device1_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID12_1 == true && NameCheck == "Device2_1")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID12_2 == true && NameCheck == "Device2_2")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.itemID12_3 == true && NameCheck == "Device2_3")
        {
            TimeBG.SetActive(true);
        }
        else if (ItemSystem.Destroy1 == false || ItemSystem.Destroy2 == false || ItemSystem.Device3_1 == false
            || ItemSystem.Device3_2 == false || ItemSystem.Device3_3 == false 
            || ItemSystem.itemID1_1 == false || ItemSystem.itemID1_2 == false || ItemSystem.itemID2_1 == false 
            || ItemSystem.itemID2_2 == false || ItemSystem.itemID2_3 == false || ItemSystem.itemID3_1 == false
            || ItemSystem.itemID3_2 == false || ItemSystem.itemID4_1 == false || ItemSystem.itemID4_2 == false
            || ItemSystem.itemID4_3 == false || ItemSystem.Device8_1 == false || ItemSystem.itemID5_1 == false
            || ItemSystem.itemID5_2 == false || ItemSystem.itemID5_3 == false || ItemSystem.itemID6_1 == false
            || ItemSystem.itemID6_2 == false || ItemSystem.itemID6_3 == false || ItemSystem.itemID7_1 == false
            || ItemSystem.itemID7_2 == false || ItemSystem.itemID8_1 == false || ItemSystem.itemID8_2 == false
            || ItemSystem.itemID8_3 == false || ItemSystem.Device4_1 == false || ItemSystem.Device4_2 == false
            || ItemSystem.itemID10_1 == false || ItemSystem.itemID10_2 == false || ItemSystem.itemID10_3 == false
            || ItemSystem.itemID11_1 == false || ItemSystem.itemID11_2 == false || ItemSystem.itemID12_1 == false
            || ItemSystem.itemID12_2 == false || ItemSystem.itemID12_3 == false)
        {
            TimeObject.GetComponent<Image>().fillAmount = 0;
            TimeObject.GetComponent<TimeCount>().timeLeft = 0;
            TimeBG.SetActive(false);
        }
    }
}
