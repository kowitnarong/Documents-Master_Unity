using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class SelectPlayer : MonoBehaviour
    {
        public int Player;
        static public int countOfPlayer;
        // Start is called before the first frame update
        public void SetPlayerThenMove(int sceneID)
        {
            SceneManager.LoadScene(sceneID);
            countOfPlayer = Player;
        }

    }
}