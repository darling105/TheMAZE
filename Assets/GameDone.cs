using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDone : MonoBehaviour
{
    public void GameHasDone() {
        SceneManager.LoadScene("Thank");
    }
}
