using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class Device4_2 : DeviceEnd
    {
        public OrderManager2 orderManager;
        public CardScript2 cardScript;

        public override void AddScore1()
        {
            if (orderManager.Order1Enable == true)
            {
                Score.ScoreGame += ScorePath1;
                PopupScorePlus(ScorePath1);
                FindObjectOfType<AudioManager>().Play("SentDevice");
                if (orderManager.RanOrder1 == 1)
                {
                    orderManager.RanOrder1 = 0;
                }
                if (orderManager.RanOrder2 == 1)
                {
                    orderManager.RanOrder2 = 0;
                }
                cardScript.Card1Finish = true;
                orderManager.Order1Enable = false;
            }
            else if (orderManager.Order1Enable == false)
            {
                Score.ScoreGame -= (ScorePath1 / 2);
                PopupScoreMinus(ScorePath1 / 2);
            }
        }
        public override void AddScore2()
        {
            if (orderManager.Order2Enable == true)
            {
                Score.ScoreGame += ScorePath2;
                PopupScorePlus(ScorePath2);
                FindObjectOfType<AudioManager>().Play("SentDevice");
                if (orderManager.RanOrder1 == 2)
                {
                    orderManager.RanOrder1 = 0;
                }
                if (orderManager.RanOrder2 == 2)
                {
                    orderManager.RanOrder2 = 0;
                }
                cardScript.Card2Finish = true;
                orderManager.Order2Enable = false;
            }
            else if (orderManager.Order2Enable == false)
            {
                Score.ScoreGame -= (ScorePath2 / 2);
                PopupScoreMinus(ScorePath2 / 2);
            }
        }
        public override void AddScore3()
        {
            if (orderManager.Order3Enable == true)
            {
                Score.ScoreGame += ScorePath3;
                PopupScorePlus(ScorePath3);
                FindObjectOfType<AudioManager>().Play("SentDevice");
                if (orderManager.RanOrder1 == 3)
                {
                    orderManager.RanOrder1 = 0;
                }
                if (orderManager.RanOrder2 == 3)
                {
                    orderManager.RanOrder2 = 0;
                }
                cardScript.Card3Finish = true;
                orderManager.Order3Enable = false;
            }
            else if (orderManager.Order3Enable == false)
            {
                Score.ScoreGame -= (ScorePath3 / 2);
                PopupScoreMinus(ScorePath3 / 2);
            }
        }
        public override void AddScore4()
        {
            if (orderManager.Order4Enable == true)
            {
                Score.ScoreGame += ScorePath4;
                PopupScorePlus(ScorePath4);
                FindObjectOfType<AudioManager>().Play("SentDevice");
                if (orderManager.RanOrder1 == 4)
                {
                    orderManager.RanOrder1 = 0;
                }
                if (orderManager.RanOrder2 == 4)
                {
                    orderManager.RanOrder2 = 0;
                }
                cardScript.Card4Finish = true;
                orderManager.Order4Enable = false;
            }
            else if (orderManager.Order4Enable == false)
            {
                Score.ScoreGame -= (ScorePath4 / 2);
                PopupScoreMinus(ScorePath4 / 2);
            }
        }
    }
}