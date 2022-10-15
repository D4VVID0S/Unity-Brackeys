using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void playAgain ()
    {
        SceneManager.LoadScene("Level_1");
    }
}
