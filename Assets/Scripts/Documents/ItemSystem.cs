using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

namespace GameDev3.Project
{
    public class ItemSystem : MonoBehaviour
    {
        static public int score = 0;
        static public int m_score
        {
            get
            {
                return score;
            }
            set
            {
                if (value >= 0)
                {
                    score += value;
                }
                else if (value < 0 && score > 0)
                {
                    score += value;
                }
            }
        }

        public string checkID = "0";
        public string itemID = "0";
        static public string orderList1 = "0";
        static public string orderList2 = "0";
        public string _orderList1;
        public string _orderList2;
        public GameObject document1Prefab;
        public GameObject document2Prefab;
        public GameObject document3Prefab;
        public GameObject document4Prefab;
        public GameObject trashPrefab;

        public bool holding = false;
        public float speedDevice = 4f;
        private bool Collision = false;
        private bool Doc1 = false;
        private bool Doc2 = false;

        public bool isPlayer1 = false;
        public bool isPlayer2 = false;

        static public bool Destroy1 = false;
        static public bool Destroy2 = false;

        static private bool statusDestroy1 = false;
        static private bool statusDestroy2 = false;
        static private bool statusDevice1_1 = false;
        static private bool statusDevice1_2 = false;
        static private bool statusDevice2_1 = false;
        static private bool statusDevice2_2 = false;
        static private bool statusDevice2_3 = false;
        static private bool statusDevice3_1 = false;
        static private bool statusDevice3_2 = false;
        static private bool statusDevice3_3 = false;
        static private bool statusDevice4_1 = false;
        static private bool statusDevice4_2 = false;
        static private bool statusDevice5_1 = false;
        static private bool statusDevice5_2 = false;
        static private bool statusDevice5_3 = false;
        static private bool statusDevice8_1 = false;

        static public bool Device3_1 = false;
        static private bool Device3_1Check = false;
        static public bool Device3_2 = false;
        static private bool Device3_2Check = false;
        static public bool Device3_3 = false;
        static private bool Device3_3Check = false;

        static public bool itemID1_1 = false;
        static private bool itemID1_1Check = false;
        static public bool itemID1_2 = false;
        static private bool itemID1_2Check = false;

        static public bool itemID2_1 = false;
        static private bool itemID2_1Check = false;
        static public bool itemID2_2 = false;
        static private bool itemID2_2Check = false;
        static public bool itemID2_3 = false;
        static private bool itemID2_3Check = false;

        static public bool itemID3_1 = false;
        static private bool itemID3_1Check = false;
        static public bool itemID3_2 = false;
        static private bool itemID3_2Check = false;

        static public bool itemID4_1 = false;
        static private bool itemID4_1Check = false;
        static public bool itemID4_2 = false;
        static private bool itemID4_2Check = false;
        static public bool itemID4_3 = false;
        static private bool itemID4_3Check = false;

        static public bool Device8_1 = false;
        static private bool Device8_1Check = false;

        static public bool itemID5_1 = false;
        static private bool itemID5_1Check = false;
        static public bool itemID5_2 = false;
        static private bool itemID5_2Check = false;
        static public bool itemID5_3 = false;
        static private bool itemID5_3Check = false;

        static public bool itemID6_1 = false;
        static private bool itemID6_1Check = false;
        static public bool itemID6_2 = false;
        static private bool itemID6_2Check = false;
        static public bool itemID6_3 = false;
        static private bool itemID6_3Check = false;

        static public bool itemID7_1 = false;
        static private bool itemID7_1Check = false;
        static public bool itemID7_2 = false;
        static private bool itemID7_2Check = false;

        static public bool itemID8_1 = false;
        static private bool itemID8_1Check = false;
        static public bool itemID8_2 = false;
        static private bool itemID8_2Check = false;
        static public bool itemID8_3 = false;
        static private bool itemID8_3Check = false;

        static public bool Device4_1 = false;
        static private bool Device4_1Check = false;
        static public bool Device4_2 = false;
        static private bool Device4_2Check = false;

        static public bool itemID10_1 = false;
        static private bool itemID10_1Check = false;
        static public bool itemID10_2 = false;
        static private bool itemID10_2Check = false;
        static public bool itemID10_3 = false;
        static private bool itemID10_3Check = false;

        static public bool itemID11_1 = false;
        static private bool itemID11_1Check = false;
        static public bool itemID11_2 = false;
        static private bool itemID11_2Check = false;

        static public bool itemID12_1 = false;
        static private bool itemID12_1Check = false;
        static public bool itemID12_2 = false;
        static private bool itemID12_2Check = false;
        static public bool itemID12_3 = false;
        static private bool itemID12_3Check = false;

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
            if (score <= 0)
            {
                score = 0;
            }
            _orderList1 = orderList1;
            _orderList2 = orderList2;
            if (itemID == "100")
            {
                document1Prefab.SetActive(false);
                document2Prefab.SetActive(false);
                document3Prefab.SetActive(false);
                document4Prefab.SetActive(false);
                trashPrefab.SetActive(true);
            }
        }

        public void OnPickItem1(InputValue value)
        {
            var v = value.Get<float>();
            if (value.isPressed && isPlayer1 == true)
            {
                Debug.Log("Player1");
                if (checkID == "3_1" && itemID == "0" && itemID != "100"
                    && Device3_1 == false && holding == false && Doc2 == false && statusDevice3_1 == false)
                {
                    Device3_1 = true;
                    StartCoroutine(CooldownDevice3_1());
                    statusDevice3_1 = true;
                }
                else if (checkID == "3_1" && itemID == "0" && itemID != "100" && Device3_1Check == true && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    orderList1 = "1";
                    itemID = "1";
                    Device3_1 = false;
                    Device3_1Check = false;
                    holding = true;
                    statusDevice3_1 = false;
                }
                else if (checkID == "3_2" && itemID == "0" && itemID != "100"
                    && Device3_2 == false && holding == false && Doc2 == false && statusDevice3_2 == false)
                {
                    Device3_2 = true;
                    StartCoroutine(CooldownDevice3_2());
                    statusDevice3_2 = true;
                }
                else if (checkID == "3_2" && itemID == "0" && itemID != "100" && Device3_2Check == true && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    orderList1 = "1";
                    itemID = "1";
                    Device3_2 = false;
                    Device3_2Check = false;
                    holding = true;
                    statusDevice3_2 = false;
                }
                else if (checkID == "3_3" && itemID == "0" && itemID != "100"
                    && Device3_3 == false && holding == false && Doc2 == false && statusDevice3_3 == false)
                {
                    Device3_3 = true;
                    StartCoroutine(CooldownDevice3_3());
                    statusDevice3_3 = true;
                }
                else if (checkID == "3_3" && itemID == "0" && itemID != "100" && Device3_3Check == true && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    orderList1 = "1";
                    itemID = "1";
                    Device3_3 = false;
                    Device3_3Check = false;
                    holding = true;
                    statusDevice3_3 = false;
                }
                else if (checkID == "1_1" && itemID == "1" && itemID1_1 == false && statusDevice1_1 == false)
                {
                    itemID1_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID1_1());
                    holding = false;
                    statusDevice1_1 = true;
                }
                else if (checkID == "1_1" && itemID1_1Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "2";
                    orderList1 = "2";
                    itemID1_1 = false;
                    itemID1_1Check = false;
                    holding = true;
                    statusDevice1_1 = false;
                }
                else if (checkID == "1_2" && itemID == "1" && itemID1_2 == false && statusDevice1_2 == false)
                {
                    itemID1_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID1_2());
                    holding = false;
                    statusDevice1_2 = true;
                }
                else if (checkID == "1_2" && itemID1_2Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "2";
                    orderList1 = "2";
                    itemID1_2 = false;
                    itemID1_2Check = false;
                    holding = true;
                    statusDevice1_2 = false;
                }
                else if (checkID == "2_1" && itemID == "2" && itemID2_1 == false && statusDevice2_1 == false)
                {
                    itemID2_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID2_1());
                    holding = false;
                    statusDevice2_1 = true;
                }
                else if (checkID == "2_1" && itemID2_1Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "3";
                    orderList1 = "3";
                    itemID2_1 = false;
                    itemID2_1Check = false;
                    Doc1 = true;
                    holding = true;
                    statusDevice2_1 = false;
                }
                else if (checkID == "2_2" && itemID == "2" && itemID2_2 == false && statusDevice2_2 == false)
                {
                    itemID2_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID2_2());
                    holding = false;
                    statusDevice2_2 = true;
                }
                else if (checkID == "2_2" && itemID2_2Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "3";
                    orderList1 = "3";
                    itemID2_2 = false;
                    itemID2_2Check = false;
                    Doc1 = true;
                    holding = true;
                    statusDevice2_2 = false;
                }
                else if (checkID == "2_3" && itemID == "2" && itemID2_3 == false && statusDevice2_3 == false)
                {
                    itemID2_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID2_3());
                    holding = false;
                    statusDevice2_3 = true;
                }
                else if (checkID == "2_3" && itemID2_3Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "3";
                    orderList1 = "3";
                    itemID2_3 = false;
                    itemID2_3Check = false;
                    Doc1 = true;
                    holding = true;
                    statusDevice2_3 = false;
                }
                else if (checkID == "4_1" && itemID == "3" && itemID3_1 == false && statusDevice4_1 == false)
                {
                    Doc1 = false;
                    itemID3_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID3_1());
                    holding = false;
                    statusDevice4_1 = true;
                }
                else if (checkID == "4_1" && itemID3_1Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "4";
                    orderList1 = "4";
                    itemID3_1 = false;
                    itemID3_1Check = false;
                    holding = true;
                    statusDevice4_1 = false;
                }
                else if (checkID == "4_2" && itemID == "3" && itemID3_2 == false && statusDevice4_2 == false)
                {
                    Doc1 = false;
                    itemID3_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID3_2());
                    holding = false;
                    statusDevice4_2 = true;
                }
                else if (checkID == "4_2" && itemID3_2Check == true && holding == false && isPlayer1 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "4";
                    orderList1 = "4";
                    itemID3_2 = false;
                    itemID3_2Check = false;
                    holding = true;
                    statusDevice4_2 = false;
                }
                else if (checkID == "5_1" && itemID == "4" && itemID4_1 == false && statusDevice5_1 == false)
                {
                    itemID4_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID4_1());
                    holding = false;
                    statusDevice5_1 = true;
                }
                else if (checkID == "5_1" && itemID4_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "14";
                    orderList1 = "5";
                    itemID4_1 = false;
                    itemID4_1Check = false;
                    holding = true;
                    document4Prefab.SetActive(true);
                    statusDevice5_1 = false;
                }
                else if (checkID == "5_2" && itemID == "4" && itemID4_2 == false && statusDevice5_2 == false)
                {
                    itemID4_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID4_2());
                    holding = false;
                    statusDevice5_2 = true;
                }
                else if (checkID == "5_2" && itemID4_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "14";
                    orderList1 = "5";
                    itemID4_2 = false;
                    itemID4_2Check = false;
                    holding = true;
                    document4Prefab.SetActive(true);
                    statusDevice5_2 = false;
                }
                else if (checkID == "5_3" && itemID == "4" && itemID4_3 == false && statusDevice5_3 == false)
                {
                    itemID4_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID4_3());
                    holding = false;
                    statusDevice5_3 = true;
                }
                else if (checkID == "5_3" && itemID4_3Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "14";
                    orderList1 = "5";
                    itemID4_3 = false;
                    itemID4_3Check = false;
                    holding = true;
                    document4Prefab.SetActive(true);
                    statusDevice5_3 = false;
                }
                else if (checkID == "7" && itemID == "14")
                {
                    if (OrderManager.Order4Enable == true)
                    {
                        m_score = 130;
                        if (OrderManager.RanOrder1 == 4)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 4)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card4Finish = true;
                        OrderManager.Order4Enable = false;
                    }
                    else if (OrderManager.Order4Enable == false)
                    {
                        m_score = -130;
                    }
                    orderList1 = "0";
                    itemID = "0";
                    holding = false;
                    document4Prefab.SetActive(false);
                }
                else if (checkID == "7" && itemID == "4")
                {
                    Doc1 = false;
                    if (OrderManager.Order1Enable == true)
                    {
                        m_score = 100;
                        if (OrderManager.RanOrder1 == 1)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 1)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card1Finish = true;
                        OrderManager.Order1Enable = false;
                    }
                    else if (OrderManager.Order1Enable == false)
                    {
                        m_score = -100;
                    }
                    orderList1 = "0";
                    itemID = "0";
                    holding = false;
                    document1Prefab.SetActive(false);
                }
                else if (itemID == "1" && checkID != "1_1" && checkID != "1_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "2" && checkID != "2_1" && checkID != "2_2" && checkID != "2_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "3" && checkID != "4_1" && checkID != "4_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "4" && checkID != "7" && checkID != "5_1" && checkID != "5_2" && checkID != "5_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "14" && checkID != "7" && Collision == true)
                {
                    itemID = "100";
                }

                // 2
                if (checkID == "8" && itemID == "0" && itemID != "100"
                    && Device8_1 == false && holding == false && statusDevice8_1 == false)
                {
                    Device8_1 = true;
                    StartCoroutine(CooldownDevice8_1());
                    statusDevice8_1 = true;
                }
                if (checkID == "8" && itemID == "0" && itemID != "100"
                    && Device8_1Check == true && isPlayer1 == true)
                {
                    document2Prefab.SetActive(true);
                    orderList1 = "1";
                    itemID = "5";
                    Device8_1 = false;
                    Device8_1Check = false;
                    holding = true;
                    statusDevice8_1 = false;
                }
                else if (checkID == "5_1" && itemID == "5" && itemID5_1 == false && statusDevice5_1 == false)
                {
                    itemID5_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID5_1());
                    holding = false;
                    statusDevice5_1 = true;
                }
                else if (checkID == "5_1" && itemID5_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "6";
                    orderList1 = "2";
                    itemID5_1 = false;
                    itemID5_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    Doc2 = true;
                    statusDevice5_1 = false;
                }
                else if (checkID == "5_2" && itemID == "5" && itemID5_2 == false && statusDevice5_2 == false)
                {
                    itemID5_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID5_2());
                    holding = false;
                    statusDevice5_2 = true;
                }
                else if (checkID == "5_2" && itemID5_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "6";
                    orderList1 = "2";
                    itemID5_2 = false;
                    itemID5_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    Doc2 = true;
                    statusDevice5_2 = false;
                }
                else if (checkID == "5_3" && itemID == "5" && itemID5_3 == false && statusDevice5_3 == false)
                {
                    itemID5_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID5_3());
                    holding = false;
                    statusDevice5_3 = true;
                }
                else if (checkID == "5_3" && itemID5_3Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "6";
                    orderList1 = "2";
                    itemID5_3 = false;
                    itemID5_3Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    Doc2 = true;
                    statusDevice5_3 = false;
                }
                else if (checkID == "3_1" && itemID == "6" && itemID6_1 == false && statusDevice3_1 == false)
                {
                    Doc2 = false;
                    itemID6_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID6_1());
                    holding = false;
                    statusDevice3_1 = true;
                }
                else if (checkID == "3_1" && itemID6_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "7";
                    orderList1 = "3";
                    itemID6_1 = false;
                    itemID6_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice3_1 = false;
                }
                else if (checkID == "3_2" && itemID == "6" && itemID6_2 == false && statusDevice3_2 == false)
                {
                    Doc2 = false;
                    itemID6_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID6_2());
                    holding = false;
                    statusDevice3_2 = true;
                }
                else if (checkID == "3_2" && itemID6_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "7";
                    orderList1 = "3";
                    itemID6_2 = false;
                    itemID6_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice3_2 = false;
                }
                else if (checkID == "3_3" && itemID == "6" && itemID6_3 == false && statusDevice3_3 == false)
                {
                    Doc2 = false;
                    itemID6_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID6_3());
                    holding = false;
                    statusDevice3_3 = true;
                }
                else if (checkID == "3_3" && itemID6_3Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "7";
                    orderList1 = "3";
                    itemID6_3 = false;
                    itemID6_3Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice3_3 = false;
                }
                else if (checkID == "1_1" && itemID == "7" && itemID7_1 == false && statusDevice1_1 == false)
                {
                    itemID7_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID7_1());
                    holding = false;
                    statusDevice1_1 = true;
                }
                else if (checkID == "1_1" && itemID7_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "8";
                    orderList1 = "4";
                    itemID7_1 = false;
                    itemID7_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice1_1 = false;
                }
                else if (checkID == "1_2" && itemID == "7" && itemID7_2 == false && statusDevice1_2 == false)
                {
                    itemID7_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID7_2());
                    holding = false;
                    statusDevice1_2 = true;
                }
                else if (checkID == "1_2" && itemID7_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "8";
                    orderList1 = "4";
                    itemID7_2 = false;
                    itemID7_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice1_2 = false;
                }
                else if (checkID == "2_1" && itemID == "8" && itemID8_1 == false && statusDevice2_1 == false)
                {
                    itemID8_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID8_1());
                    holding = false;
                    statusDevice2_1 = true;
                }
                else if (checkID == "2_1" && itemID8_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "9";
                    orderList1 = "5";
                    itemID8_1 = false;
                    itemID8_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice2_1 = false;
                }
                else if (checkID == "2_2" && itemID == "8" && itemID8_2 == false && statusDevice2_2 == false)
                {
                    itemID8_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID8_2());
                    holding = false;
                    statusDevice2_2 = true;
                }
                else if (checkID == "2_2" && itemID8_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "9";
                    orderList1 = "5";
                    itemID8_2 = false;
                    itemID8_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice2_2 = false;
                }
                else if (checkID == "2_3" && itemID == "8" && itemID8_3 == false && statusDevice2_3 == false)
                {
                    itemID8_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID8_3());
                    holding = false;
                    statusDevice2_3 = true;
                }
                else if (checkID == "2_3" && itemID8_3Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "9";
                    orderList1 = "5";
                    itemID8_3 = false;
                    itemID8_3Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice2_3 = false;
                }
                else if (checkID == "7" && itemID == "9")
                {
                    if (OrderManager.Order2Enable == true)
                    {
                        m_score = 150;
                        if (OrderManager.RanOrder1 == 2)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 2)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card2Finish = true;
                        OrderManager.Order2Enable = false;
                    }
                    else if (OrderManager.Order2Enable == false)
                    {
                        m_score = -150;
                    }
                    orderList1 = "0";
                    itemID = "0";
                    holding = false;
                    document2Prefab.SetActive(false);
                }
                else if (itemID == "5" && checkID != "5_1" && checkID != "5_2" && checkID != "5_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "6" && checkID != "3_1" && checkID != "3_2" && checkID != "3_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "7" && checkID != "1_1" && checkID != "1_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "8" && checkID != "2_1" && checkID != "2_2" && checkID != "2_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "9" && checkID != "7" && Collision == true)
                {
                    itemID = "100";
                }

                // 3
                if (checkID == "4_1" && itemID == "0" && itemID != "100" && Doc1 == false
                    && Device4_1 == false && holding == false && statusDevice4_1 == false)
                {
                    Device4_1 = true;
                    StartCoroutine(CooldownDevice4_1());
                    statusDevice4_1 = true;
                }
                else if (checkID == "4_1" && itemID == "0" && itemID != "100"
                    && Device4_1Check == true && isPlayer1 == true)
                {
                    document3Prefab.SetActive(true);
                    orderList1 = "1";
                    itemID = "10";
                    Device4_1 = false;
                    Device4_1Check = false;
                    holding = true;
                    statusDevice4_1 = false;
                }
                else if (checkID == "4_2" && itemID == "0" && itemID != "100" && Doc1 == false
                    && Device4_2 == false && holding == false && statusDevice4_2 == false)
                {
                    Device4_2 = true;
                    StartCoroutine(CooldownDevice4_2());
                    statusDevice4_1 = true;
                }
                else if (checkID == "4_2" && itemID == "0" && itemID != "100"
                    && Device4_2Check == true && isPlayer1 == true)
                {
                    document3Prefab.SetActive(true);
                    orderList1 = "1";
                    itemID = "10";
                    Device4_2 = false;
                    Device4_2Check = false;
                    holding = true;
                    statusDevice4_2 = false;
                }
                else if (checkID == "5_1" && itemID == "10" && itemID10_1 == false && statusDevice5_1 == false)
                {
                    itemID10_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID10_1());
                    holding = false;
                    statusDevice5_1 = true;
                }
                else if (checkID == "5_1" && itemID10_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "11";
                    orderList1 = "2";
                    itemID10_1 = false;
                    itemID10_1Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice5_1 = false;
                }
                else if (checkID == "5_2" && itemID == "10" && itemID10_2 == false && statusDevice5_2 == false)
                {
                    itemID10_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID10_2());
                    holding = false;
                    statusDevice5_2 = true;
                }
                else if (checkID == "5_2" && itemID10_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "11";
                    orderList1 = "2";
                    itemID10_2 = false;
                    itemID10_2Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice5_2 = false;
                }
                else if (checkID == "5_3" && itemID == "10" && itemID10_3 == false && statusDevice5_3 == false)
                {
                    itemID10_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID10_3());
                    holding = false;
                    statusDevice5_3 = true;
                }
                else if (checkID == "5_3" && itemID10_3Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "11";
                    orderList1 = "2";
                    itemID10_3 = false;
                    itemID10_3Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice5_3 = false;
                }
                else if (checkID == "1_1" && itemID == "11" && itemID11_1 == false && statusDevice1_1 == false)
                {
                    itemID11_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID11_1());
                    holding = false;
                    statusDevice1_1 = true;
                }
                else if (checkID == "1_1" && itemID11_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "12";
                    orderList1 = "3";
                    itemID11_1 = false;
                    itemID11_1Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice1_1 = false;
                }
                else if (checkID == "1_2" && itemID == "11" && itemID11_2 == false && statusDevice1_2 == false)
                {
                    itemID11_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID11_2());
                    holding = false;
                    statusDevice1_2 = true;
                }
                else if (checkID == "1_2" && itemID11_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "12";
                    orderList1 = "3";
                    itemID11_2 = false;
                    itemID11_2Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice1_2 = false;
                }
                else if (checkID == "2_1" && itemID == "12" && itemID12_1 == false && statusDevice2_1 == false)
                {
                    itemID12_1 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID12_1());
                    holding = false;
                    statusDevice2_1 = true;
                }
                else if (checkID == "2_1" && itemID12_1Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "13";
                    orderList1 = "4";
                    itemID12_1 = false;
                    itemID12_1Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice2_1 = false;
                }
                else if (checkID == "2_2" && itemID == "12" && itemID12_2 == false && statusDevice2_2 == false)
                {
                    itemID12_2 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID12_2());
                    holding = false;
                    statusDevice2_2 = true;
                }
                else if (checkID == "2_2" && itemID12_2Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "13";
                    orderList1 = "4";
                    itemID12_2 = false;
                    itemID12_2Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice2_2 = false;
                }
                else if (checkID == "2_3" && itemID == "12" && itemID12_3 == false && statusDevice2_3 == false)
                {
                    itemID12_3 = true;
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID12_3());
                    holding = false;
                    statusDevice2_3 = true;
                }
                else if (checkID == "2_3" && itemID12_3Check == true && holding == false && isPlayer1 == true)
                {
                    itemID = "13";
                    orderList1 = "4";
                    itemID12_3 = false;
                    itemID12_3Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice2_3 = false;
                }
                else if (checkID == "7" && itemID == "13")
                {
                    if (OrderManager.Order3Enable == true)
                    {
                        m_score = 100;
                        if (OrderManager.RanOrder1 == 3)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 3)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card3Finish = true;
                        OrderManager.Order3Enable = false;
                    }
                    else if (OrderManager.Order3Enable == false)
                    {
                        m_score = -100;
                    }
                    orderList1 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    holding = false;
                }
                else if (itemID == "10" && checkID != "5_1" && checkID != "5_2" && checkID != "5_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "11" && checkID != "1_1" && checkID != "1_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "12" && checkID != "2_1" && checkID != "2_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "13" && checkID != "7" && Collision == true)
                {
                    itemID = "100";
                }

                // Destroy_1
                if (checkID == "99" && Destroy1 == false && holding == true && statusDestroy1 == false)
                {
                    if (orderList1 == "1")
                    {
                        m_score = -20;
                    }
                    else if (orderList1 == "2")
                    {
                        m_score = -40;
                    }
                    else if (orderList1 == "3")
                    {
                        m_score = -60;
                    }
                    else if (orderList1 == "4")
                    {
                        m_score = -80;
                    }
                    else if (orderList1 == "5")
                    {
                        m_score = -100;
                    }

                    document1Prefab.SetActive(false);
                    document2Prefab.SetActive(false);
                    document3Prefab.SetActive(false);
                    document4Prefab.SetActive(false);
                    trashPrefab.SetActive(false);

                    orderList1 = "0";
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
                // Destroy_2
                if (checkID == "98" && Destroy2 == false && holding == true && statusDestroy2 == false)
                {
                    if (orderList1 == "1")
                    {
                        m_score = -20;
                    }
                    else if (orderList1 == "2")
                    {
                        m_score = -40;
                    }
                    else if (orderList1 == "3")
                    {
                        m_score = -60;
                    }
                    else if (orderList1 == "4")
                    {
                        m_score = -80;
                    }
                    else if (orderList1 == "5")
                    {
                        m_score = -100;
                    }

                    document1Prefab.SetActive(false);
                    document2Prefab.SetActive(false);
                    document3Prefab.SetActive(false);
                    document4Prefab.SetActive(false);
                    trashPrefab.SetActive(false);

                    orderList1 = "0";
                    itemID = "0";

                    StartCoroutine(CooldownDestory2());
                    Destroy2 = true;
                    holding = false;

                    if (Doc1 == true)
                    {
                        Doc1 = false;
                    }
                    if (Doc2 == true)
                    {
                        Doc2 = false;
                    }

                    statusDestroy2 = true;
                }
            }
        }
        public void OnPickItem2(InputValue value)
        {
            var v = value.Get<float>();
            if (value.isPressed && isPlayer2 == true)
            {
                Debug.Log("Player2");
                if (checkID == "3_1" && itemID == "0" && itemID != "100"
                    && Device3_1 == false && holding == false && Doc2 == false && statusDevice3_1 == false)
                {
                    Device3_1 = true;
                    StartCoroutine(CooldownDevice3_1());
                    statusDevice3_1 = true;
                }
                else if (checkID == "3_1" && itemID == "0" && itemID != "100" && Device3_1Check == true && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    orderList2 = "1";
                    itemID = "1";
                    Device3_1 = false;
                    Device3_1Check = false;
                    holding = true;
                    statusDevice3_1 = false;
                }
                else if (checkID == "3_2" && itemID == "0" && itemID != "100"
                    && Device3_2 == false && holding == false && Doc2 == false && statusDevice3_2 == false)
                {
                    Device3_2 = true;
                    StartCoroutine(CooldownDevice3_2());
                    statusDevice3_2 = true;
                }
                else if (checkID == "3_2" && itemID == "0" && itemID != "100" && Device3_2Check == true && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    orderList2 = "1";
                    itemID = "1";
                    Device3_2 = false;
                    Device3_2Check = false;
                    holding = true;
                    statusDevice3_2 = false;
                }
                else if (checkID == "3_3" && itemID == "0" && itemID != "100"
                    && Device3_3 == false && holding == false && Doc2 == false && statusDevice3_3 == false)
                {
                    Device3_3 = true;
                    StartCoroutine(CooldownDevice3_3());
                    statusDevice3_3 = true;
                }
                else if (checkID == "3_3" && itemID == "0" && itemID != "100" && Device3_3Check == true && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    orderList2 = "1";
                    itemID = "1";
                    Device3_3 = false;
                    Device3_3Check = false;
                    holding = true;
                    statusDevice3_3 = false;
                }
                else if (checkID == "1_1" && itemID == "1" && itemID1_1 == false && statusDevice1_1 == false)
                {
                    itemID1_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID1_1());
                    holding = false;
                    statusDevice1_1 = true;
                }
                else if (checkID == "1_1" && itemID1_1Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "2";
                    orderList2 = "2";
                    itemID1_1 = false;
                    itemID1_1Check = false;
                    holding = true;
                    statusDevice1_1 = false;
                }
                else if (checkID == "1_2" && itemID == "1" && itemID1_2 == false && statusDevice1_2 == false)
                {
                    itemID1_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID1_2());
                    holding = false;
                    statusDevice1_2 = true;
                }
                else if (checkID == "1_2" && itemID1_2Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "2";
                    orderList2 = "2";
                    itemID1_2 = false;
                    itemID1_2Check = false;
                    holding = true;
                    statusDevice1_2 = false;
                }
                else if (checkID == "2_1" && itemID == "2" && itemID2_1 == false && statusDevice2_1 == false)
                {
                    itemID2_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID2_1());
                    holding = false;
                    statusDevice2_1 = true;
                }
                else if (checkID == "2_1" && itemID2_1Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "3";
                    orderList2 = "3";
                    itemID2_1 = false;
                    itemID2_1Check = false;
                    Doc1 = true;
                    holding = true;
                    statusDevice2_1 = false;
                }
                else if (checkID == "2_2" && itemID == "2" && itemID2_2 == false && statusDevice2_2 == false)
                {
                    itemID2_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID2_2());
                    holding = false;
                    statusDevice2_2 = true;
                }
                else if (checkID == "2_2" && itemID2_2Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "3";
                    orderList2 = "3";
                    itemID2_2 = false;
                    itemID2_2Check = false;
                    Doc1 = true;
                    holding = true;
                    statusDevice2_2 = false;
                }
                else if (checkID == "2_3" && itemID == "2" && itemID2_3 == false && statusDevice2_3 == false)
                {
                    itemID2_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID2_3());
                    holding = false;
                    statusDevice2_3 = true;
                }
                else if (checkID == "2_3" && itemID2_3Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "3";
                    orderList2 = "3";
                    itemID2_3 = false;
                    itemID2_3Check = false;
                    Doc1 = true;
                    holding = true;
                    statusDevice2_3 = false;
                }
                else if (checkID == "4_1" && itemID == "3" && itemID3_1 == false && statusDevice4_1 == false)
                {
                    Doc1 = false;
                    itemID3_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID3_1());
                    holding = false;
                    statusDevice4_1 = true;
                }
                else if (checkID == "4_1" && itemID3_1Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "4";
                    orderList2 = "4";
                    itemID3_1 = false;
                    itemID3_1Check = false;
                    holding = true;
                    statusDevice4_1 = false;
                }
                else if (checkID == "4_2" && itemID == "3" && itemID3_2 == false && statusDevice4_2 == false)
                {
                    Doc1 = false;
                    itemID3_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID3_2());
                    holding = false;
                    statusDevice4_2 = true;
                }
                else if (checkID == "4_2" && itemID3_2Check == true && holding == false && isPlayer2 == true)
                {
                    document1Prefab.SetActive(true);
                    itemID = "4";
                    orderList2 = "4";
                    itemID3_2 = false;
                    itemID3_2Check = false;
                    holding = true;
                    statusDevice4_2 = false;
                }
                else if (checkID == "5_1" && itemID == "4" && itemID4_1 == false && statusDevice5_1 == false)
                {
                    itemID4_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID4_1());
                    holding = false;
                    statusDevice5_1 = true;
                }
                else if (checkID == "5_1" && itemID4_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "14";
                    orderList2 = "5";
                    itemID4_1 = false;
                    itemID4_1Check = false;
                    holding = true;
                    document4Prefab.SetActive(true);
                    statusDevice5_1 = false;
                }
                else if (checkID == "5_2" && itemID == "4" && itemID4_2 == false && statusDevice5_2 == false)
                {
                    itemID4_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID4_2());
                    holding = false;
                    statusDevice5_2 = true;
                }
                else if (checkID == "5_2" && itemID4_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "14";
                    orderList2 = "5";
                    itemID4_2 = false;
                    itemID4_2Check = false;
                    holding = true;
                    document4Prefab.SetActive(true);
                    statusDevice5_2 = false;
                }
                else if (checkID == "5_3" && itemID == "4" && itemID4_3 == false && statusDevice5_3 == false)
                {
                    itemID4_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document1Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID4_3());
                    holding = false;
                    statusDevice5_3 = true;
                }
                else if (checkID == "5_3" && itemID4_3Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "14";
                    orderList2 = "5";
                    itemID4_3 = false;
                    itemID4_3Check = false;
                    holding = true;
                    document4Prefab.SetActive(true);
                    statusDevice5_3 = false;
                }
                else if (checkID == "7" && itemID == "14")
                {
                    if (OrderManager.Order4Enable == true)
                    {
                        m_score = 130;
                        if (OrderManager.RanOrder1 == 4)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 4)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card4Finish = true;
                        OrderManager.Order4Enable = false;
                    }
                    else if (OrderManager.Order4Enable == false)
                    {
                        m_score = -130;
                    }
                    orderList2 = "0";
                    itemID = "0";
                    holding = false;
                    document4Prefab.SetActive(false);
                }
                else if (checkID == "7" && itemID == "4")
                {
                    Doc1 = false;
                    if (OrderManager.Order1Enable == true)
                    {
                        m_score = 100;
                        if (OrderManager.RanOrder1 == 1)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 1)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card1Finish = true;
                        OrderManager.Order1Enable = false;
                    }
                    else if (OrderManager.Order1Enable == false)
                    {
                        m_score = -100;
                    }
                    orderList2 = "0";
                    itemID = "0";
                    holding = false;
                    document1Prefab.SetActive(false);
                }
                else if (itemID == "1" && checkID != "1_1" && checkID != "1_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "2" && checkID != "2_1" && checkID != "2_2" && checkID != "2_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "3" && checkID != "4_1" && checkID != "4_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "4" && checkID != "7" && checkID != "5_1" && checkID != "5_2" && checkID != "5_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "14" && checkID != "7" && Collision == true)
                {
                    itemID = "100";
                }

                // 2
                if (checkID == "8" && itemID == "0" && itemID != "100"
                    && Device8_1 == false && holding == false && statusDevice8_1 == false)
                {
                    Device8_1 = true;
                    StartCoroutine(CooldownDevice8_1());
                    statusDevice8_1 = true;
                }
                if (checkID == "8" && itemID == "0" && itemID != "100"
                    && Device8_1Check == true && isPlayer2 == true)
                {
                    document2Prefab.SetActive(true);
                    orderList2 = "1";
                    itemID = "5";
                    Device8_1 = false;
                    Device8_1Check = false;
                    holding = true;
                    statusDevice8_1 = false;
                }
                else if (checkID == "5_1" && itemID == "5" && itemID5_1 == false && statusDevice5_1 == false)
                {
                    itemID5_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID5_1());
                    holding = false;
                    statusDevice5_1 = true;
                }
                else if (checkID == "5_1" && itemID5_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "6";
                    orderList2 = "2";
                    itemID5_1 = false;
                    itemID5_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    Doc2 = true;
                    statusDevice5_1 = false;
                }
                else if (checkID == "5_2" && itemID == "5" && itemID5_2 == false && statusDevice5_2 == false)
                {
                    itemID5_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID5_2());
                    holding = false;
                    statusDevice5_2 = true;
                }
                else if (checkID == "5_2" && itemID5_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "6";
                    orderList2 = "2";
                    itemID5_2 = false;
                    itemID5_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    Doc2 = true;
                    statusDevice5_2 = false;
                }
                else if (checkID == "5_3" && itemID == "5" && itemID5_3 == false && statusDevice5_3 == false)
                {
                    itemID5_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID5_3());
                    holding = false;
                    statusDevice5_3 = true;
                }
                else if (checkID == "5_3" && itemID5_3Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "6";
                    orderList2 = "2";
                    itemID5_3 = false;
                    itemID5_3Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    Doc2 = true;
                    statusDevice5_3 = false;
                }
                else if (checkID == "3_1" && itemID == "6" && itemID6_1 == false && statusDevice3_1 == false)
                {
                    Doc2 = false;
                    itemID6_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID6_1());
                    holding = false;
                    statusDevice3_1 = true;
                }
                else if (checkID == "3_1" && itemID6_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "7";
                    orderList2 = "3";
                    itemID6_1 = false;
                    itemID6_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice3_1 = false;
                }
                else if (checkID == "3_2" && itemID == "6" && itemID6_2 == false && statusDevice3_2 == false)
                {
                    Doc2 = false;
                    itemID6_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID6_2());
                    holding = false;
                    statusDevice3_2 = true;
                }
                else if (checkID == "3_2" && itemID6_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "7";
                    orderList2 = "3";
                    itemID6_2 = false;
                    itemID6_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice3_2 = false;
                }
                else if (checkID == "3_3" && itemID == "6" && itemID6_3 == false && statusDevice3_3 == false)
                {
                    Doc2 = false;
                    itemID6_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID6_3());
                    holding = false;
                    statusDevice3_3 = true;
                }
                else if (checkID == "3_3" && itemID6_3Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "7";
                    orderList2 = "3";
                    itemID6_3 = false;
                    itemID6_3Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice3_3 = false;
                }
                else if (checkID == "1_1" && itemID == "7" && itemID7_1 == false && statusDevice1_1 == false)
                {
                    itemID7_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID7_1());
                    holding = false;
                    statusDevice1_1 = true;
                }
                else if (checkID == "1_1" && itemID7_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "8";
                    orderList2 = "4";
                    itemID7_1 = false;
                    itemID7_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice1_1 = false;
                }
                else if (checkID == "1_2" && itemID == "7" && itemID7_2 == false && statusDevice1_2 == false)
                {
                    itemID7_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID7_2());
                    holding = false;
                    statusDevice1_2 = true;
                }
                else if (checkID == "1_2" && itemID7_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "8";
                    orderList2 = "4";
                    itemID7_2 = false;
                    itemID7_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice1_2 = false;
                }
                else if (checkID == "2_1" && itemID == "8" && itemID8_1 == false && statusDevice2_1 == false)
                {
                    itemID8_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID8_1());
                    holding = false;
                    statusDevice2_1 = true;
                }
                else if (checkID == "2_1" && itemID8_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "9";
                    orderList2 = "5";
                    itemID8_1 = false;
                    itemID8_1Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice2_1 = false;
                }
                else if (checkID == "2_2" && itemID == "8" && itemID8_2 == false && statusDevice2_2 == false)
                {
                    itemID8_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID8_2());
                    holding = false;
                    statusDevice2_2 = true;
                }
                else if (checkID == "2_2" && itemID8_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "9";
                    orderList2 = "5";
                    itemID8_2 = false;
                    itemID8_2Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice2_2 = false;
                }
                else if (checkID == "2_3" && itemID == "8" && itemID8_3 == false && statusDevice2_3 == false)
                {
                    itemID8_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document2Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID8_3());
                    holding = false;
                    statusDevice2_3 = true;
                }
                else if (checkID == "2_3" && itemID8_3Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "9";
                    orderList2 = "5";
                    itemID8_3 = false;
                    itemID8_3Check = false;
                    holding = true;
                    document2Prefab.SetActive(true);
                    statusDevice2_3 = false;
                }
                else if (checkID == "7" && itemID == "9")
                {
                    if (OrderManager.Order2Enable == true)
                    {
                        m_score = 150;
                        if (OrderManager.RanOrder1 == 2)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 2)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card2Finish = true;
                        OrderManager.Order2Enable = false;
                    }
                    else if (OrderManager.Order2Enable == false)
                    {
                        m_score = -150;
                    }
                    orderList2 = "0";
                    itemID = "0";
                    holding = false;
                    document2Prefab.SetActive(false);
                }
                else if (itemID == "5" && checkID != "5_1" && checkID != "5_2" && checkID != "5_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "6" && checkID != "3_1" && checkID != "3_2" && checkID != "3_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "7" && checkID != "1_1" && checkID != "1_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "8" && checkID != "2_1" && checkID != "2_2" && checkID != "2_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "9" && checkID != "7" && Collision == true)
                {
                    itemID = "100";
                }

                // 3
                if (checkID == "4_1" && itemID == "0" && itemID != "100" && Doc1 == false
                    && Device4_1 == false && holding == false && statusDevice4_1 == false)
                {
                    Device4_1 = true;
                    StartCoroutine(CooldownDevice4_1());
                    statusDevice4_1 = true;
                }
                else if (checkID == "4_1" && itemID == "0" && itemID != "100"
                    && Device4_1Check == true && isPlayer2 == true)
                {
                    document3Prefab.SetActive(true);
                    orderList2 = "1";
                    itemID = "10";
                    Device4_1 = false;
                    Device4_1Check = false;
                    holding = true;
                    statusDevice4_1 = false;
                }
                else if (checkID == "4_2" && itemID == "0" && itemID != "100" && Doc1 == false
                    && Device4_2 == false && holding == false && statusDevice4_2 == false)
                {
                    Device4_2 = true;
                    StartCoroutine(CooldownDevice4_2());
                    statusDevice4_1 = true;
                }
                else if (checkID == "4_2" && itemID == "0" && itemID != "100"
                    && Device4_2Check == true && isPlayer2 == true)
                {
                    document3Prefab.SetActive(true);
                    orderList2 = "1";
                    itemID = "10";
                    Device4_2 = false;
                    Device4_2Check = false;
                    holding = true;
                    statusDevice4_2 = false;
                }
                else if (checkID == "5_1" && itemID == "10" && itemID10_1 == false && statusDevice5_1 == false)
                {
                    itemID10_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID10_1());
                    holding = false;
                    statusDevice5_1 = true;
                }
                else if (checkID == "5_1" && itemID10_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "11";
                    orderList2 = "2";
                    itemID10_1 = false;
                    itemID10_1Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice5_1 = false;
                }
                else if (checkID == "5_2" && itemID == "10" && itemID10_2 == false && statusDevice5_2 == false)
                {
                    itemID10_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID10_2());
                    holding = false;
                    statusDevice5_2 = true;
                }
                else if (checkID == "5_2" && itemID10_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "11";
                    orderList2 = "2";
                    itemID10_2 = false;
                    itemID10_2Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice5_2 = false;
                }
                else if (checkID == "5_3" && itemID == "10" && itemID10_3 == false && statusDevice5_3 == false)
                {
                    itemID10_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID10_3());
                    holding = false;
                    statusDevice5_3 = true;
                }
                else if (checkID == "5_3" && itemID10_3Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "11";
                    orderList2 = "2";
                    itemID10_3 = false;
                    itemID10_3Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice5_3 = false;
                }
                else if (checkID == "1_1" && itemID == "11" && itemID11_1 == false && statusDevice1_1 == false)
                {
                    itemID11_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID11_1());
                    holding = false;
                    statusDevice1_1 = true;
                }
                else if (checkID == "1_1" && itemID11_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "12";
                    orderList2 = "3";
                    itemID11_1 = false;
                    itemID11_1Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice1_1 = false;
                }
                else if (checkID == "1_2" && itemID == "11" && itemID11_2 == false && statusDevice1_2 == false)
                {
                    itemID11_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID11_2());
                    holding = false;
                    statusDevice1_2 = true;
                }
                else if (checkID == "1_2" && itemID11_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "12";
                    orderList2 = "3";
                    itemID11_2 = false;
                    itemID11_2Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice1_2 = false;
                }
                else if (checkID == "2_1" && itemID == "12" && itemID12_1 == false && statusDevice2_1 == false)
                {
                    itemID12_1 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID12_1());
                    holding = false;
                    statusDevice2_1 = true;
                }
                else if (checkID == "2_1" && itemID12_1Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "13";
                    orderList2 = "4";
                    itemID12_1 = false;
                    itemID12_1Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice2_1 = false;
                }
                else if (checkID == "2_2" && itemID == "12" && itemID12_2 == false && statusDevice2_2 == false)
                {
                    itemID12_2 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID12_2());
                    holding = false;
                    statusDevice2_2 = true;
                }
                else if (checkID == "2_2" && itemID12_2Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "13";
                    orderList2 = "4";
                    itemID12_2 = false;
                    itemID12_2Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice2_2 = false;
                }
                else if (checkID == "2_3" && itemID == "12" && itemID12_3 == false && statusDevice2_3 == false)
                {
                    itemID12_3 = true;
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    StartCoroutine(CooldownItemID12_3());
                    holding = false;
                    statusDevice2_3 = true;
                }
                else if (checkID == "2_3" && itemID12_3Check == true && holding == false && isPlayer2 == true)
                {
                    itemID = "13";
                    orderList2 = "4";
                    itemID12_3 = false;
                    itemID12_3Check = false;
                    holding = true;
                    document3Prefab.SetActive(true);
                    statusDevice2_3 = false;
                }
                else if (checkID == "7" && itemID == "13")
                {
                    if (OrderManager.Order3Enable == true)
                    {
                        m_score = 100;
                        if (OrderManager.RanOrder1 == 3)
                        {
                            OrderManager.RanOrder1 = 0;
                        }
                        if (OrderManager.RanOrder2 == 3)
                        {
                            OrderManager.RanOrder2 = 0;
                        }
                        CardScript.Card3Finish = true;
                        OrderManager.Order3Enable = false;
                    }
                    else if (OrderManager.Order3Enable == false)
                    {
                        m_score = -100;
                    }
                    orderList2 = "0";
                    itemID = "0";
                    document3Prefab.SetActive(false);
                    holding = false;
                }
                else if (itemID == "10" && checkID != "5_1" && checkID != "5_2" && checkID != "5_3" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "11" && checkID != "1_1" && checkID != "1_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "12" && checkID != "2_1" && checkID != "2_2" && Collision == true)
                {
                    itemID = "100";
                }
                else if (itemID == "13" && checkID != "7" && Collision == true)
                {
                    itemID = "100";
                }

                // Destroy_1
                if (checkID == "99" && Destroy1 == false && holding == true && statusDestroy1 == false)
                {
                    if (orderList2 == "1")
                    {
                        m_score = -20;
                    }
                    else if (orderList2 == "2")
                    {
                        m_score = -40;
                    }
                    else if (orderList2 == "3")
                    {
                        m_score = -60;
                    }
                    else if (orderList2 == "4")
                    {
                        m_score = -80;
                    }
                    else if (orderList2 == "5")
                    {
                        m_score = -100;
                    }

                    document1Prefab.SetActive(false);
                    document2Prefab.SetActive(false);
                    document3Prefab.SetActive(false);
                    document4Prefab.SetActive(false);
                    trashPrefab.SetActive(false);

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
                // Destroy_2
                if (checkID == "98" && Destroy2 == false && holding == true && statusDestroy2 == false)
                {
                    if (orderList2 == "1")
                    {
                        m_score = -20;
                    }
                    else if (orderList2 == "2")
                    {
                        m_score = -40;
                    }
                    else if (orderList2 == "3")
                    {
                        m_score = -60;
                    }
                    else if (orderList2 == "4")
                    {
                        m_score = -80;
                    }
                    else if (orderList2 == "5")
                    {
                        m_score = -100;
                    }

                    document1Prefab.SetActive(false);
                    document2Prefab.SetActive(false);
                    document3Prefab.SetActive(false);
                    document4Prefab.SetActive(false);
                    trashPrefab.SetActive(false);

                    orderList2 = "0";
                    itemID = "0";

                    StartCoroutine(CooldownDestory2());
                    Destroy2 = true;
                    holding = false;

                    if (Doc1 == true)
                    {
                        Doc1 = false;
                    }
                    if (Doc2 == true)
                    {
                        Doc2 = false;
                    }

                    statusDestroy2 = true;
                }
            }
        }

        public IEnumerator CooldownDestory1()
        {
            yield return new WaitForSeconds(speedDevice);
            statusDestroy1 = false;
            Destroy1 = false;
        }
        public IEnumerator CooldownDestory2()
        {
            yield return new WaitForSeconds(speedDevice);
            statusDestroy2 = false;
            Destroy2 = false;
        }
        public IEnumerator CooldownDevice3_1()
        {
            yield return new WaitForSeconds(speedDevice);
            Device3_1Check = true;
        }
        public IEnumerator CooldownDevice3_2()
        {
            yield return new WaitForSeconds(speedDevice);
            Device3_2Check = true;
        }
        public IEnumerator CooldownDevice3_3()
        {
            yield return new WaitForSeconds(speedDevice);
            Device3_3Check = true;
        }
        public IEnumerator CooldownItemID1_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID1_1Check = true;
        }
        public IEnumerator CooldownItemID1_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID1_2Check = true;
        }
        public IEnumerator CooldownItemID2_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID2_1Check = true;
        }
        public IEnumerator CooldownItemID2_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID2_2Check = true;
        }
        public IEnumerator CooldownItemID2_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID2_3Check = true;
        }
        public IEnumerator CooldownItemID3_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID3_1Check = true;
        }
        public IEnumerator CooldownItemID3_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID3_2Check = true;
        }
        public IEnumerator CooldownItemID4_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID4_1Check = true;
        }
        public IEnumerator CooldownItemID4_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID4_2Check = true;
        }
        public IEnumerator CooldownItemID4_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID4_3Check = true;
        }
        // 2
        public IEnumerator CooldownDevice8_1()
        {
            yield return new WaitForSeconds(speedDevice);
            Device8_1Check = true;
        }
        public IEnumerator CooldownItemID5_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID5_1Check = true;
        }
        public IEnumerator CooldownItemID5_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID5_2Check = true;
        }
        public IEnumerator CooldownItemID5_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID5_3Check = true;
        }
        public IEnumerator CooldownItemID6_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID6_1Check = true;
        }
        public IEnumerator CooldownItemID6_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID6_2Check = true;
        }
        public IEnumerator CooldownItemID6_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID6_3Check = true;
        }
        public IEnumerator CooldownItemID7_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID7_1Check = true;
        }
        public IEnumerator CooldownItemID7_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID7_2Check = true;
        }
        public IEnumerator CooldownItemID8_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID8_1Check = true;
        }
        public IEnumerator CooldownItemID8_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID8_2Check = true;
        }
        public IEnumerator CooldownItemID8_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID8_3Check = true;
        }
        public IEnumerator CooldownDevice4_1()
        {
            yield return new WaitForSeconds(speedDevice);
            Device4_1Check = true;
        }
        public IEnumerator CooldownDevice4_2()
        {
            yield return new WaitForSeconds(speedDevice);
            Device4_2Check = true;
        }
        public IEnumerator CooldownItemID10_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID10_1Check = true;
        }
        public IEnumerator CooldownItemID10_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID10_2Check = true;
        }
        public IEnumerator CooldownItemID10_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID10_3Check = true;
        }
        public IEnumerator CooldownItemID11_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID11_1Check = true;
        }
        public IEnumerator CooldownItemID11_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID11_2Check = true;
        }
        public IEnumerator CooldownItemID12_1()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID12_1Check = true;
        }
        public IEnumerator CooldownItemID12_2()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID12_2Check = true;
        }
        public IEnumerator CooldownItemID12_3()
        {
            yield return new WaitForSeconds(speedDevice);
            itemID12_3Check = true;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Table1_1" || collision.gameObject.name == "Table1_2" || collision.gameObject.name == "Table2_1"
                || collision.gameObject.name == "Table2_2" || collision.gameObject.name == "Table2_3" || collision.gameObject.name == "Table3_1"
                || collision.gameObject.name == "Table3_2" || collision.gameObject.name == "Table3_3" || collision.gameObject.name == "Table4_1"
                || collision.gameObject.name == "Table4_2" || collision.gameObject.name == "Table5_1" || collision.gameObject.name == "Table5_2"
                || collision.gameObject.name == "Table5_3" || collision.gameObject.name == "Table7"
                || collision.gameObject.name == "Table8")
            {
                checkID = collision.gameObject.GetComponent<DeviceSystem>().deviceID;
                Collision = true;
            }
            if (collision.gameObject.name == "Destroy_1" || collision.gameObject.name == "Destroy_2")
            {
                checkID = collision.gameObject.GetComponent<DeviceSystem>().deviceID;
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.name == "Table1_1" || collision.gameObject.name == "Table1_2" || collision.gameObject.name == "Table2_1"
                || collision.gameObject.name == "Table2_2" || collision.gameObject.name == "Table2_3" || collision.gameObject.name == "Table3_1"
                || collision.gameObject.name == "Table3_2" || collision.gameObject.name == "Table3_3" || collision.gameObject.name == "Table4_1"
                || collision.gameObject.name == "Table4_2" || collision.gameObject.name == "Table5_1" || collision.gameObject.name == "Table5_2"
                || collision.gameObject.name == "Table5_3" || collision.gameObject.name == "Table7"
                || collision.gameObject.name == "Table8")
            {
                checkID = "0";
                Collision = false;
            }
            if (collision.gameObject.name == "Destroy_1" || collision.gameObject.name == "Destroy_2")
            {
                checkID = "0";
            }
        }
    }
}