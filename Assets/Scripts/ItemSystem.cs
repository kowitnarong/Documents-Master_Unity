using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class ItemSystem : MonoBehaviour
{
    static public int score = 0;

    public string checkID = "0";
    public string itemID = "0";
    static public string orderList = "0";
    public GameObject document1Prefab;
    public GameObject document2Prefab;
    public GameObject document3Prefab;
    public GameObject document4Prefab;
    public GameObject trashPrefab;

    // เอกสาร 1 : 3-1-2-4-7 * 1
    // เอกสาร 2 : 8-5-3-1-2-7 * 5
    // เอกสาร 3 : 4-5-1-2-7 * 9
    // เอกสาร 4 : 3-1-2-4-5-7

    // 1 - ห้องเครื่องปริ้นท์
    // 2 - ห้องลงตราประทับ 
    // 3 - ห้องคอม 
    // 4 - ห้องเก็บตู้เอกสาร 
    // 5 - ห้อง Scanner 
    // 6 - ห้องทำลายเอกสาร
    // 7 - จุดส่งเอกสาร 
    // 8 - จุดรับเอกสาร

    void Update()
    {
        if (itemID == "100")
        {
            document1Prefab.SetActive(false);
            document2Prefab.SetActive(false);
            document3Prefab.SetActive(false);
            document4Prefab.SetActive(false);
            trashPrefab.SetActive(true);
        }
    }

    public void OnPickItem(InputValue value)
    {
        Debug.Log("PickUp");
        var v = value.Get<float>();
        if (value.isPressed)
        {
            if (orderList == "0" && checkID == "3" && itemID == "0" && itemID != "100")
            {
                document1Prefab.SetActive(true);
                orderList = "1";
                itemID = "1";
            }
            else if (checkID == "1" && itemID == "1")
            {
                itemID = "2";
                orderList = "2";
            }
            else if (checkID == "2" && itemID == "2")
            {
                itemID = "3";
                orderList = "3";
            }
            else if (checkID == "4" && itemID == "3")
            {
                itemID = "4";
                orderList = "4";
            }
            else if (checkID == "7" && itemID == "4")
            {
                score += 100;
                orderList = "0";
                itemID = "0";
                document1Prefab.SetActive(false);
            }
            else if (itemID == "1" && checkID != "1")
            {
                itemID = "100";
            }
            else if (itemID == "2" && checkID != "2")
            {
                itemID = "100";
            }
            else if (itemID == "3" && checkID != "4")
            {
                itemID = "100";
            }
            else if (itemID == "4" && checkID != "7")
            {
                itemID = "100";
            }

            // 2
            if (orderList == "0" && checkID == "8" && itemID == "0" && itemID != "100")
            {
                document2Prefab.SetActive(true);
                orderList = "1";
                itemID = "5";
            }
            else if (checkID == "5" && itemID == "5")
            {
                orderList = "2";
                itemID = "6";
            }
            else if (checkID == "3" && itemID == "6")
            {
                orderList = "3";
                itemID = "7";
            }
            else if(checkID == "1" && itemID == "7")
            {
                orderList = "4";
                itemID = "8";
            }
            else if(checkID == "2" && itemID == "8")
            {
                orderList = "5";
                itemID = "9";
            }
            else if(checkID == "7" && itemID == "9")
            {
                score += 130;
                orderList = "0";
                itemID = "0";
                document2Prefab.SetActive(false);
            }
            else if(itemID == "5" && checkID != "5")
            {
                itemID = "100";
            }
            else if(itemID == "6" && checkID != "3")
            {
                itemID = "100";
            }
            else if(itemID == "7" && checkID != "1")
            {
                itemID = "100";
            }
            else if(itemID == "8" && checkID != "2")
            {
                itemID = "100";
            }
            else if(itemID == "9" && checkID != "7")
            {
                itemID = "100";
            }

            // Destroy
            if (itemID == "100" && checkID == "99")
            {
                if (orderList == "1")
                {
                    score -= 20;
                }
                else if (orderList == "2")
                {
                    score -= 40;
                }
                else if (orderList == "3")
                {
                    score -= 60;
                }
                else if (orderList == "4")
                {
                    score -= 80;
                }
                else if (orderList == "5")
                {
                    score -= 100;
                }

                document1Prefab.SetActive(false);
                document2Prefab.SetActive(false);
                document3Prefab.SetActive(false);
                document4Prefab.SetActive(false);
                trashPrefab.SetActive(false);

                orderList = "0";
                itemID = "0";
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Table1" || collision.gameObject.name == "Table2"
            || collision.gameObject.name == "Table3" || collision.gameObject.name == "Table4"
            || collision.gameObject.name == "Table5" || collision.gameObject.name == "Table7"
            || collision.gameObject.name == "Table8")
        {
            checkID = collision.gameObject.GetComponent<DeviceSystem>().deviceID;
        }
        if (collision.gameObject.name == "Destroy")
        {
            checkID = collision.gameObject.GetComponent<DeviceSystem>().deviceID;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Table1" || collision.gameObject.name == "Table2"
            || collision.gameObject.name == "Table3" || collision.gameObject.name == "Table4"
            || collision.gameObject.name == "Table5" || collision.gameObject.name == "Table7"
            || collision.gameObject.name == "Table8")
        {
            checkID = "0";
        }
        if (collision.gameObject.name == "Destroy")
        {
            checkID = "0";
        }
    }
}
