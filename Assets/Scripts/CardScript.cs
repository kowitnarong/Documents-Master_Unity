using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class CardScript : MonoBehaviour
    {
        public bool Card1;
        public bool Card2;
        public bool Card3;
        public bool Card4;

        private bool Card1In = false;
        private bool _Card1In = false;
        private bool Card1IdleCheck = false;

        private bool Card2In = false;
        private bool _Card2In = false;
        private bool Card2IdleCheck = false;

        private bool Card3In = false;
        private bool _Card3In = false;
        private bool Card3IdleCheck = false;

        private bool Card4In = false;
        private bool _Card4In = false;
        private bool Card4IdleCheck = false;

        public Animator animatorCard1;
        public Animator animatorCard2;
        public Animator animatorCard3;
        public Animator animatorCard4;

        public TimerOrder Timer1;
        public TimerOrder Timer2;
        public TimerOrder Timer3;
        public TimerOrder Timer4;

        static public bool Card1Finish = false;
        static public bool Card2Finish = false;
        static public bool Card3Finish = false;
        static public bool Card4Finish = false;

        Coroutine ControlCard1TimeOut;
        Coroutine ControlCard2TimeOut;
        Coroutine ControlCard3TimeOut;
        Coroutine ControlCard4TimeOut;

        // Update is called once per frame
        void Update()
        {
            //1
            if (OrderManager.Order1Enable == true)
            {
                Card1 = true;
            }
            else if (OrderManager.Order1Enable == false)
            {
                Card1 = false;
            }
            if (Card1 == true && Card1In == false)
            {
                Card1In = true;
            }
            if (Card1In == true && _Card1In == false)
            {
                animatorCard1.SetBool("Card1In", true);
                animatorCard1.Play("Card1In", -1, 0f);
                animatorCard1.SetBool("Card1Out", false);
                animatorCard1.SetBool("Card1Idle", false);
                _Card1In = true;
                Card1IdleCheck = true;
                StartCoroutine(Card1Idle());
            }
            if (Card1 == false && Card1IdleCheck == true)
            {
                animatorCard1.SetBool("Card1In", false);
                animatorCard1.SetBool("Card1Out", true);
                animatorCard1.Play("Card1Out", -1, 0f);
                animatorCard1.SetBool("Card1Idle", false);
                StartCoroutine(Card1Out());
            }

            //2
            if (OrderManager.Order2Enable == true)
            {
                Card2 = true;
            }
            else if (OrderManager.Order2Enable == false)
            {
                Card2 = false;
            }
            if (Card2 == true && Card2In == false)
            {
                Card2In = true;
            }
            if (Card2In == true && _Card2In == false)
            {
                animatorCard2.SetBool("Card2In", true);
                animatorCard2.Play("Card2In", -1, 0f);
                animatorCard2.SetBool("Card2Out", false);
                animatorCard2.SetBool("Card2Idle", false);
                _Card2In = true;
                Card2IdleCheck = true;
                StartCoroutine(Card2Idle());
            }
            if (Card2 == false && Card2IdleCheck == true)
            {
                animatorCard2.SetBool("Card2In", false);
                animatorCard2.SetBool("Card2Out", true);
                animatorCard2.Play("Card2Out", -1, 0f);
                animatorCard2.SetBool("Card2Idle", false);
                StartCoroutine(Card2Out());
            }

            //3
            if (OrderManager.Order3Enable == true)
            {
                Card3 = true;
            }
            else if (OrderManager.Order3Enable == false)
            {
                Card3 = false;
            }
            if (Card3 == true && Card3In == false)
            {
                Card3In = true;
            }
            if (Card3In == true && _Card3In == false)
            {
                animatorCard3.SetBool("Card3In", true);
                animatorCard3.Play("Card3In", -1, 0f);
                animatorCard3.SetBool("Card3Out", false);
                animatorCard3.SetBool("Card3Idle", false);
                _Card3In = true;
                Card3IdleCheck = true;
                StartCoroutine(Card3Idle());
            }
            if (Card3 == false && Card3IdleCheck == true)
            {
                animatorCard3.SetBool("Card3In", false);
                animatorCard3.SetBool("Card3Out", true);
                animatorCard3.Play("Card3Out", -1, 0f);
                animatorCard3.SetBool("Card3Idle", false);
                StartCoroutine(Card3Out());
            }

            //4
            if (OrderManager.Order4Enable == true)
            {
                Card4 = true;
            }
            else if (OrderManager.Order4Enable == false)
            {
                Card4 = false;
            }
            if (Card4 == true && Card4In == false)
            {
                Card4In = true;
            }
            if (Card4In == true && _Card4In == false)
            {
                animatorCard4.SetBool("Card4In", true);
                animatorCard4.Play("Card4In", -1, 0f);
                animatorCard4.SetBool("Card4Out", false);
                animatorCard4.SetBool("Card4Idle", false);
                _Card4In = true;
                Card4IdleCheck = true;
                StartCoroutine(Card4Idle());
            }
            if (Card4 == false && Card4IdleCheck == true)
            {
                animatorCard4.SetBool("Card4In", false);
                animatorCard4.SetBool("Card4Out", true);
                animatorCard4.Play("Card4Out", -1, 0f);
                animatorCard4.SetBool("Card4Idle", false);
                StartCoroutine(Card4Out());
            }

            // Card finish before time up
            if (Card1Finish == true)
            {
                StopCoroutine(ControlCard1TimeOut);
                StartCoroutine(Card1Random());
                Card1Finish = false;
            }
            if (Card2Finish == true)
            {
                StopCoroutine(ControlCard2TimeOut);
                StartCoroutine(Card2Random());
                Card2Finish = false;
            }
            if (Card3Finish == true)
            {
                StopCoroutine(ControlCard3TimeOut);
                StartCoroutine(Card3Random());
                Card3Finish = false;
            }
            if (Card4Finish == true)
            {
                StopCoroutine(ControlCard4TimeOut);
                StartCoroutine(Card4Random());
                Card4Finish = false;
            }
        }

        //1
        public IEnumerator Card1Idle()
        {
            ControlCard1TimeOut = StartCoroutine(Card1TimeOut());
            Timer1.TimerOn = true;
            yield return new WaitForSeconds(1.2f);
            animatorCard1.SetBool("Card1In", false);
            animatorCard1.SetBool("Card1Idle", true);
            animatorCard1.SetBool("Card1Out", false);
        }
        public IEnumerator Card1Out()
        {
            yield return new WaitForSeconds(0.1f);
            animatorCard1.SetBool("Card1In", false);
            animatorCard1.SetBool("Card1Out", false);
            animatorCard1.SetBool("Card1Idle", false);
            Card1In = false;
            _Card1In = false;
            Card1IdleCheck = false;
        }

        public IEnumerator Card1TimeOut()
        {
            yield return new WaitForSeconds(TimeDocumentSet.Timer1);
            if (OrderManager.RanOrder1 == 1)
            {
                OrderManager.RanOrder1 = 0;
                OrderManager.Order1Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
                ItemSystem.score -= 50;
            }
            else if (OrderManager.RanOrder2 == 1)
            {
                OrderManager.RanOrder2 = 0;
                OrderManager.Order1Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
                ItemSystem.score -= 50;
            }
        }
        public IEnumerator Card1Random()
        {
            yield return new WaitForSeconds(2f);
            if (OrderManager.RanOrder1 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
            }
            else if (OrderManager.RanOrder2 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
            }
        }

        //2
        public IEnumerator Card2Idle()
        {
            ControlCard2TimeOut = StartCoroutine(Card2TimeOut());
            Timer2.TimerOn = true;
            yield return new WaitForSeconds(1.2f);
            animatorCard2.SetBool("Card2In", false);
            animatorCard2.SetBool("Card2Idle", true);
            animatorCard2.SetBool("Card2Out", false);
        }
        public IEnumerator Card2Out()
        {
            yield return new WaitForSeconds(0.1f);
            animatorCard2.SetBool("Card2In", false);
            animatorCard2.SetBool("Card2Out", false);
            animatorCard2.SetBool("Card2Idle", false);
            Card2In = false;
            _Card2In = false;
            Card2IdleCheck = false;
        }

        public IEnumerator Card2TimeOut()
        {
            yield return new WaitForSeconds(TimeDocumentSet.Timer2);
            if (OrderManager.RanOrder1 == 2)
            {
                OrderManager.RanOrder1 = 0;
                OrderManager.Order2Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
                ItemSystem.score -= 50;
            }
            else if (OrderManager.RanOrder2 == 2)
            {
                OrderManager.RanOrder2 = 0;
                OrderManager.Order2Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
                ItemSystem.score -= 50;
            }
        }
        public IEnumerator Card2Random()
        {
            yield return new WaitForSeconds(2f);
            if (OrderManager.RanOrder1 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
            }
            else if (OrderManager.RanOrder2 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
            }
        }

        //3
        public IEnumerator Card3Idle()
        {
            ControlCard3TimeOut = StartCoroutine(Card3TimeOut());
            Timer3.TimerOn = true;
            yield return new WaitForSeconds(1.2f);
            animatorCard3.SetBool("Card3In", false);
            animatorCard3.SetBool("Card3Idle", true);
            animatorCard3.SetBool("Card3Out", false);
        }
        public IEnumerator Card3Out()
        {
            yield return new WaitForSeconds(0.1f);
            animatorCard3.SetBool("Card3In", false);
            animatorCard3.SetBool("Card3Out", false);
            animatorCard3.SetBool("Card3Idle", false);
            Card3In = false;
            _Card3In = false;
            Card3IdleCheck = false;
        }

        public IEnumerator Card3TimeOut()
        {
            yield return new WaitForSeconds(TimeDocumentSet.Timer3);
            if (OrderManager.RanOrder1 == 3)
            {
                OrderManager.RanOrder1 = 0;
                OrderManager.Order3Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
                ItemSystem.score -= 50;
            }
            else if (OrderManager.RanOrder2 == 3)
            {
                OrderManager.RanOrder2 = 0;
                OrderManager.Order3Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
                ItemSystem.score -= 50;
            }
        }
        public IEnumerator Card3Random()
        {
            yield return new WaitForSeconds(2f);
            if (OrderManager.RanOrder1 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
            }
            else if (OrderManager.RanOrder2 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
            }
        }

        //3
        public IEnumerator Card4Idle()
        {
            ControlCard4TimeOut = StartCoroutine(Card4TimeOut());
            Timer4.TimerOn = true;
            yield return new WaitForSeconds(1.2f);
            animatorCard4.SetBool("Card4In", false);
            animatorCard4.SetBool("Card4Idle", true);
            animatorCard4.SetBool("Card4Out", false);
        }
        public IEnumerator Card4Out()
        {
            yield return new WaitForSeconds(0.1f);
            animatorCard4.SetBool("Card4In", false);
            animatorCard4.SetBool("Card4Out", false);
            animatorCard4.SetBool("Card4Idle", false);
            Card4In = false;
            _Card4In = false;
            Card4IdleCheck = false;
        }

        public IEnumerator Card4TimeOut()
        {
            yield return new WaitForSeconds(TimeDocumentSet.Timer4);
            if (OrderManager.RanOrder1 == 4)
            {
                OrderManager.RanOrder1 = 0;
                OrderManager.Order4Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
                ItemSystem.score -= 50;
            }
            else if (OrderManager.RanOrder2 == 4)
            {
                OrderManager.RanOrder2 = 0;
                OrderManager.Order4Enable = false;
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
                ItemSystem.score -= 50;
            }
        }
        public IEnumerator Card4Random()
        {
            yield return new WaitForSeconds(2f);
            if (OrderManager.RanOrder1 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder1 = true;
            }
            else if (OrderManager.RanOrder2 == 0)
            {
                yield return new WaitForSeconds(2f);
                OrderManager.RandomOrder2 = true;
            }
        }
    }
}