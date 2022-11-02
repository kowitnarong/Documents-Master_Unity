using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GameDev3.Project
{
    public class PopupScore : MonoBehaviour
    {
        public int CurrentScorePopup;
        public TextMeshProUGUI ScoreText;
        public GameObject renderCanvas;

        private void Start()
        {
            //PopupScoreText();
        }

        public void PopupScoreTextPlus()
        { 
            TextMeshProUGUI tempTextBox = Instantiate(ScoreText, new Vector3(60, -20, 0), Quaternion.identity);
            tempTextBox.SetText("+" + CurrentScorePopup.ToString());
            tempTextBox.transform.SetParent(renderCanvas.transform, false);
        }

        public void PopupScoreTextMinus()
        {
            TextMeshProUGUI tempTextBox = Instantiate(ScoreText, new Vector3(60, -20, 0), Quaternion.identity);
            tempTextBox.SetText("-" + CurrentScorePopup.ToString());
            tempTextBox.transform.SetParent(renderCanvas.transform, false);
        }
    }
}