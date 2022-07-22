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

    public bool holding = false;
    private bool Collision = false;
    private bool Doc1 = false;
    private bool Doc2 = false;

    static public bool Destroy1 = false;

    private bool statusDestroy1 = false;
    private bool statusDevice1_1 = false;
    private bool statusDevice2_1 = false;
    private bool statusDevice3_1 = false;
    private bool statusDevice4_1 = false;
    private bool statusDevice5_1 = false;
    private bool statusDevice8_1 = false;

    static public bool Device3_1 = false;
    private bool Device3_1Check = false;
    

    static public bool itemID1 = false;
    private bool itemID1Check = false;


    static public bool itemID2 = false;
    private bool itemID2Check = false;

    static public bool itemID3 = false;
    private bool itemID3Check = false;

    static public bool itemID4 = false;
    private bool itemID4Check = false;

    static public bool Device8_1 = false;
    private bool Device8_1Check = false;

    static public bool itemID5 = false;
    private bool itemID5Check = false;

    static public bool itemID6 = false;
    private bool itemID6Check = false;

    static public bool itemID7 = false;
    private bool itemID7Check = false;

    static public bool itemID8 = false;
    private bool itemID8Check = false;

    static public bool Device4_1 = false;
    private bool Device4_1Check = false;

    static public bool itemID10 = false;
    private bool itemID10Check = false;

    static public bool itemID11 = false;
    private bool itemID11Check = false;

    static public bool itemID12 = false;
    private bool itemID12Check = false;

    // เอกสาร 1 : 3-1-2-4-7 * 1
    // เอกสาร 2 : 8-5-3-1-2-7 * 5
    // เอกสาร 3 : 4-5-1-2-7 * 9
    // เอกสาร 4 : 3-1-2-4-5-7 * 13

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
            if (orderList == "0" && checkID == "3" && itemID == "0" && itemID != "100" 
                && Device3_1 == false && holding == false && Doc2 == false && statusDevice3_1 == false)
            {
                Device3_1 = true;
                StartCoroutine(CooldownDevice3_1());
                statusDevice3_1 = true;
            }
            if (orderList == "0" && checkID == "3" && itemID == "0" && itemID != "100" && Device3_1Check == true)
            {
                document1Prefab.SetActive(true);
                orderList = "1";
                itemID = "1";
                Device3_1 = false;
                Device3_1Check = false;
                holding = true;
                statusDevice3_1 = false;
            }
            else if (checkID == "1" && itemID == "1" && itemID1 == false && statusDevice1_1 == false)
            {
                itemID1 = true;
                orderList = "0";
                itemID = "0";
                document1Prefab.SetActive(false);
                StartCoroutine(CooldownItemID1());
                holding = false;
                statusDevice1_1 = true;
            }
            else if (checkID == "1" && itemID1Check == true && holding == false)
            {
                document1Prefab.SetActive(true);
                itemID = "2";
                orderList = "2";
                itemID1 = false;
                itemID1Check = false;
                holding = true;
                statusDevice1_1 = false;
            }
            else if (checkID == "2" && itemID == "2" && itemID2 == false && statusDevice2_1 == false)
            {
                itemID2 = true;
                orderList = "0";
                itemID = "0";
                document1Prefab.SetActive(false);
                StartCoroutine(CooldownItemID2());
                holding = false;
                statusDevice2_1 = true;
            }
            else if (checkID == "2" && itemID2Check == true && holding == false)
            {
                document1Prefab.SetActive(true);
                itemID = "3";
                orderList = "3";
                itemID2 = false;
                itemID2Check = false;
                Doc1 = true;
                holding = true;
                statusDevice2_1 = false;
            }
            else if (checkID == "4" && itemID == "3" && itemID3 == false && statusDevice4_1 == false)
            {
                itemID3 = true;
                orderList = "0";
                itemID = "0";
                document1Prefab.SetActive(false);
                StartCoroutine(CooldownItemID3());
                holding = false;
                statusDevice4_1 = true;
            }
            else if (checkID == "4" && itemID3Check == true && holding == false)
            {
                document1Prefab.SetActive(true);
                itemID = "4";
                orderList = "4";
                itemID3 = false;
                itemID3Check = false;
                holding = true;
                statusDevice4_1 = false;
            }
            else if (checkID == "5" && itemID == "4" && itemID4 == false && statusDevice5_1 == false)
            {
                itemID4 = true;
                orderList = "0";
                itemID = "0";
                document1Prefab.SetActive(false);
                StartCoroutine(CooldownItemID4());
                Doc1 = false;
                holding = false;
                statusDevice5_1 = true;
            }
            else if (checkID == "5" && itemID4Check == true && holding == false)
            {
                itemID = "14";
                orderList = "5";
                itemID4 = false;
                itemID4Check = false;
                holding = true;
                document4Prefab.SetActive(true);
                statusDevice5_1 = false;
            }
            else if (checkID == "7" && itemID == "14")
            {
                score += 130;
                orderList = "0";
                itemID = "0";
                holding = false;
                document4Prefab.SetActive(false);
            }
            else if (checkID == "7" && itemID == "4")
            {
                Doc1 = false;
                score += 100;
                orderList = "0";
                itemID = "0";
                holding = false;
                document1Prefab.SetActive(false);
            }
            else if (itemID == "1" && checkID != "1" && Collision == true)
            {
                itemID = "100";
            }
            else if (itemID == "2" && checkID != "2" && Collision == true)
            {
                itemID = "100";
            }
            else if (itemID == "3" && checkID != "4" && Collision == true)
            {
                itemID = "100";
            }
            else if (itemID == "4" && checkID != "7" && checkID != "5" && Collision == true)
            {
                itemID = "100";
            }
            else if (itemID == "14" && checkID != "7" && Collision == true)
            {
                itemID = "100";
            }

            // 2
            if (orderList == "0" && checkID == "8" && itemID == "0" && itemID != "100"
                && Device8_1 == false && holding == false && statusDevice8_1 == false)
            {
                Device8_1 = true;
                StartCoroutine(CooldownDevice8_1());
                statusDevice8_1 = true;
            }
            if (orderList == "0" && checkID == "8" && itemID == "0" && itemID != "100"
                && Device8_1Check == true)
            {
                document2Prefab.SetActive(true);
                orderList = "1";
                itemID = "5";
                Device8_1 = false;
                Device8_1Check = false;
                holding = true;
                statusDevice8_1 = false;
            }
            else if (checkID == "5" && itemID == "5" && itemID5 == false && statusDevice5_1 == false)
            {
                itemID5 = true;
                orderList = "0";
                itemID = "0";
                document2Prefab.SetActive(false);
                StartCoroutine(CooldownItemID5());
                holding = false;
                statusDevice5_1 = true;
            }
            else if (checkID == "5" && itemID5Check == true && holding == false)
            {
                itemID = "6";
                orderList = "2";
                itemID5 = false;
                itemID5Check = false;
                holding = true;
                document2Prefab.SetActive(true);
                Doc2 = true;
                statusDevice5_1 = true;
            }
            else if (checkID == "3" && itemID == "6" && itemID6 == false && statusDevice3_1 == false && statusDevice3_1 == false)
            {
                itemID6 = true;
                orderList = "0";
                itemID = "0";
                document2Prefab.SetActive(false);
                StartCoroutine(CooldownItemID6());
                holding = false;
                statusDevice3_1 = true;
            }
            else if (checkID == "3" && itemID6Check == true && holding == false)
            {
                Doc2 = false;
                itemID = "7";
                orderList = "3";
                itemID6 = false;
                itemID6Check = false;
                holding = true;
                document2Prefab.SetActive(true);
                statusDevice3_1 = false;
            }
            else if(checkID == "1" && itemID == "7" && itemID7 == false && statusDevice1_1 == false)
            {
                itemID7 = true;
                orderList = "0";
                itemID = "0";
                document2Prefab.SetActive(false);
                StartCoroutine(CooldownItemID7());
                holding = false;
                statusDevice1_1 = true;
            }
            else if (checkID == "1" && itemID7Check == true && holding == false)
            {
                itemID = "8";
                orderList = "4";
                itemID7 = false;
                itemID7Check = false;
                holding = true;
                document2Prefab.SetActive(true);
                statusDevice1_1 = false;
            }
            else if(checkID == "2" && itemID == "8" && itemID8 == false && statusDevice2_1 == false)
            {
                itemID8 = true;
                orderList = "0";
                itemID = "0";
                document2Prefab.SetActive(false);
                StartCoroutine(CooldownItemID8());
                holding = false;
                statusDevice2_1 = true;
            }
            else if (checkID == "2" && itemID8Check == true && holding == false)
            {
                itemID = "9";
                orderList = "5";
                itemID8 = false;
                itemID8Check = false;
                holding = true;
                document2Prefab.SetActive(true);
                statusDevice2_1 = false;
            }
            else if(checkID == "7" && itemID == "9")
            {
                score += 130;
                orderList = "0";
                itemID = "0";
                holding = false;
                document2Prefab.SetActive(false);
            }
            else if(itemID == "5" && checkID != "5" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "6" && checkID != "3" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "7" && checkID != "1" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "8" && checkID != "2" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "9" && checkID != "7" && Collision == true)
            {
                itemID = "100";
            }
            
            // 3
            if (orderList == "0" && checkID == "4" && itemID == "0" && itemID != "100" && Doc1 == false
                && Device4_1 == false && holding == false && statusDevice4_1 == false)
            {
                Device4_1 = true;
                StartCoroutine(CooldownDevice4_1());
                statusDevice4_1 = true;
            }
            if (orderList == "0" && checkID == "4" && itemID == "0" && itemID != "100"
                && Device4_1Check == true)
            {
                document3Prefab.SetActive(true);
                orderList = "1";
                itemID = "10";
                Device4_1 = false;
                Device4_1Check = false;
                holding = true;
                statusDevice4_1 = false;
            }
            else if(checkID == "5" && itemID == "10" && itemID10 == false && statusDevice5_1 == false)
            {
                itemID10 = true;
                orderList = "0";
                itemID = "0";
                document3Prefab.SetActive(false);
                StartCoroutine(CooldownItemID10());
                holding = false;
                statusDevice5_1 = true;
            }
            else if (checkID == "5" && itemID10Check == true && holding == false)
            {
                itemID = "11";
                orderList = "2";
                itemID10 = false;
                itemID10Check = false;
                holding = true;
                document3Prefab.SetActive(true);
                statusDevice5_1 = false;
            }
            else if(checkID == "1" && itemID == "11" && itemID11 == false && statusDevice1_1 == false)
            {
                itemID11 = true;
                orderList = "0";
                itemID = "0";
                document3Prefab.SetActive(false);
                StartCoroutine(CooldownItemID11());
                holding = false;
                statusDevice1_1 = true;
            }
            else if (checkID == "1" && itemID11Check == true && holding == false)
            {
                itemID = "12";
                orderList = "3";
                itemID11 = false;
                itemID11Check = false;
                holding = true;
                document3Prefab.SetActive(true);
                statusDevice1_1 = false;
            }
            else if(checkID == "2" && itemID == "12" && itemID12 == false && statusDevice2_1 == false)
            {
                itemID12 = true;
                orderList = "0";
                itemID = "0";
                document3Prefab.SetActive(false);
                StartCoroutine(CooldownItemID12());
                holding = false;
                statusDevice2_1 = true;
            }
            else if (checkID == "2" && itemID12Check == true && holding == false)
            {
                itemID = "13";
                orderList = "4";
                itemID12 = false;
                itemID12Check = false;
                holding = true;
                document3Prefab.SetActive(true);
                statusDevice2_1 = false;
            }
            else if(checkID == "7" && itemID == "13")
            {
                score += 100;
                orderList = "0";
                itemID = "0";
                document3Prefab.SetActive(false);
                holding = false;
            }
            else if(itemID == "10" && checkID != "5" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "11" && checkID != "1" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "12" && checkID != "2" && Collision == true)
            {
                itemID = "100";
            }
            else if(itemID == "13" && checkID != "7" && Collision == true)
            {
                itemID = "100";
            }

            // Destroy
            if (checkID == "99" && Destroy1 == false && holding == true && statusDestroy1 == false)
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

                StartCoroutine(CooldownDestory1());
                Destroy1 = true;
                holding = false;

                if (Doc1 == true)
                {
                    Doc1 = false;
                }
                if (Doc2 == true)
                {
                    Doc2 = false;
                }

                statusDestroy1 = true;
            }
        }
    }

    public IEnumerator CooldownDestory1()
    {
        yield return new WaitForSeconds(4);
        statusDestroy1 = false;
        Destroy1 = false;
    }
    public IEnumerator CooldownDevice3_1()
    {
        yield return new WaitForSeconds(4);
        Device3_1Check = true;
    }
    public IEnumerator CooldownItemID1()
    {
        yield return new WaitForSeconds(4);
        itemID1Check = true;
    }
    public IEnumerator CooldownItemID2()
    {
        yield return new WaitForSeconds(4);
        itemID2Check = true;
    }
    public IEnumerator CooldownItemID3()
    {
        yield return new WaitForSeconds(4);
        itemID3Check = true;
    }
    public IEnumerator CooldownItemID4()
    {
        yield return new WaitForSeconds(4);
        itemID4Check = true;
    }
    // 2
    public IEnumerator CooldownDevice8_1()
    {
        yield return new WaitForSeconds(4);
        Device8_1Check = true;
    }
    public IEnumerator CooldownItemID5()
    {
        yield return new WaitForSeconds(4);
        itemID5Check = true;
    }
    public IEnumerator CooldownItemID6()
    {
        yield return new WaitForSeconds(4);
        itemID6Check = true;
    }
    public IEnumerator CooldownItemID7()
    {
        yield return new WaitForSeconds(4);
        itemID7Check = true;
    }
    public IEnumerator CooldownItemID8()
    {
        yield return new WaitForSeconds(4);
        itemID8Check = true;
    }
    public IEnumerator CooldownDevice4_1()
    {
        yield return new WaitForSeconds(4);
        Device4_1Check = true;
    }
    public IEnumerator CooldownItemID10()
    {
        yield return new WaitForSeconds(4);
        itemID10Check = true;
    }
    public IEnumerator CooldownItemID11()
    {
        yield return new WaitForSeconds(4);
        itemID11Check = true;
    }
    public IEnumerator CooldownItemID12()
    {
        yield return new WaitForSeconds(4);
        itemID12Check = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Table1" || collision.gameObject.name == "Table2"
            || collision.gameObject.name == "Table3" || collision.gameObject.name == "Table4"
            || collision.gameObject.name == "Table5" || collision.gameObject.name == "Table7"
            || collision.gameObject.name == "Table8")
        {
            checkID = collision.gameObject.GetComponent<DeviceSystem>().deviceID;
            Collision = true;
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
            Collision = false;
        }
        if (collision.gameObject.name == "Destroy")
        {
            checkID = "0";
        }
    }
}
