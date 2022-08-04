using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class OrderManager : MonoBehaviour
    {
        static public int RanOrder1 = 0;
        static public int RanOrder2 = 0;
        public int _RanOrder1 = 0;
        public int _RanOrder2 = 0;

        static public bool RandomOrder1 = true;
        static public bool RandomOrder2 = true;
        static public bool RandomOrder3 = true;
        static public bool RandomOrder4 = true;
        static public bool Order1Enable = false;
        static public bool Order2Enable = false;
        static public bool Order3Enable = false;
        static public bool Order4Enable = false;

        public bool _Order1Enable = false;
        public bool _Order2Enable = false;
        public bool _Order3Enable = false;
        public bool _Order4Enable = false;

        void Update()
        {
            _RanOrder1 = RanOrder1;
            _RanOrder2 = RanOrder2;

            _Order1Enable = Order1Enable;
            _Order2Enable = Order2Enable;
            _Order3Enable = Order3Enable;
            _Order4Enable = Order4Enable;

            if (RanOrder1 == 0 && RandomOrder1 == true)
            {
                RanOrder1 = Random.Range(1, 5);
                while (RandomOrder1 == true)
                {
                    if (RanOrder1 == RanOrder2)
                    {
                        RanOrder1 = Random.Range(1, 5);
                    }
                    else if (RanOrder1 != RanOrder2)
                    {
                        Debug.Log("ran1 :" + RanOrder1);
                        RandomOrder1 = false;
                    }
                }

            }
            else if (RanOrder2 == 0 && RandomOrder2 == true)
            {
                RanOrder2 = Random.Range(1, 5);
                while (RandomOrder2 == true)
                {
                    if (RanOrder2 == RanOrder1)
                    {
                        RanOrder2 = Random.Range(1, 5);
                    }
                    else if (RanOrder2 != RanOrder1)
                    {
                        Debug.Log("ran2 :" + RanOrder2);
                        RandomOrder2 = false;
                    }
                }
            }

            if (RandomOrder1 == false)
            {
                switch (RanOrder1)
                {
                    case 1:
                        Order1Enable = true;
                        break;
                    case 2:
                        Order2Enable = true;
                        break;
                    case 3:
                        Order3Enable = true;
                        break;
                    case 4:
                        Order4Enable = true;
                        break;
                }
            }

            if (RandomOrder2 == false)
            {
                switch (RanOrder2)
                {
                    case 1:
                        Order1Enable = true;
                        break;
                    case 2:
                        Order2Enable = true;
                        break;
                    case 3:
                        Order3Enable = true;
                        break;
                    case 4:
                        Order4Enable = true;
                        break;
                }
            }
        }
    }
}