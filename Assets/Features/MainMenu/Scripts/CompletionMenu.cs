using UnityEngine;
using UnityEngine.SceneManagement;

namespace Features.MainMenu.Scripts
{
    public class CompletionMenu : MonoBehaviour
    {
        public void OpenMainMenu()
        {
            Debug.Log("I was clicked");
            SceneManager.LoadScene("MainMenuScene");
        }
    }
}