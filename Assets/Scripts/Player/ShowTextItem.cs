using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class ShowTextItem : MonoBehaviour
    {
        public Inventory PlayerInventory;
        private Image IconImage;
        private string CurrentItem;
        public IconInputSetting iconSprite;

        private void Start()
        {
            IconImage = GetComponentInChildren<Image>();
        }

        private void Update()
        {
            if (PlayerInventory.m_ItemInventory.Count != 0)
            {
                foreach (object o in PlayerInventory.m_ItemInventory)
                {
                    if (o.ToString() == "DestroyItem")
                    {
                        CurrentItem = "Trash";
                        IconImage.color = new Color(255, 255, 255, 255);
                        CheckSceneLevel();
                    }
                    else
                    {
                        CurrentItem = o.ToString().Substring(6, 1);
                        IconImage.color = new Color(255, 255, 255, 255);
                        CheckSceneLevel();
                    }
                }
            }
            else
            {
                CurrentItem = "";
                CheckSceneLevel();
            }
        }

        private void CheckSceneLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            if (sceneName == "Level1")
            {
                SetIconItemLevel1();
            }
            else if (sceneName == "Level2")
            {
                SetIconItemLevel2();
            }
        }

        private void SetIconItemLevel1()
        {
            switch (CurrentItem)
            {
                case "Trash":
                    IconImage.sprite = iconSprite.icon_9;
                    break;
                case "1":
                    IconImage.sprite = iconSprite.icon_1;
                    break;
                case "3":
                    IconImage.sprite = iconSprite.icon_2;
                    break;
                case "2":
                    IconImage.sprite = iconSprite.icon_5;
                    break;
                case "4":
                    IconImage.sprite = iconSprite.icon_4;
                    break;
                case "5":
                    IconImage.sprite = iconSprite.icon_7;
                    break;
                case "":
                    IconImage.color = new Color(0, 0, 0, 0);
                    break;
            }
        }

        private void SetIconItemLevel2()
        {
            switch (CurrentItem)
            {
                case "Trash":
                    IconImage.sprite = iconSprite.icon_9;
                    break;
                case "1":
                    IconImage.sprite = iconSprite.icon_1;
                    break;
                case "3":
                    IconImage.sprite = iconSprite.icon_2;
                    break;
                case "2":
                    IconImage.sprite = iconSprite.icon_5;
                    break;
                case "4":
                    IconImage.sprite = iconSprite.icon_4;
                    break;
                case "5":
                    IconImage.sprite = iconSprite.icon_7;
                    break;
                case "":
                    IconImage.color = new Color(0, 0, 0, 0);
                    break;
            }
        }
    }
}