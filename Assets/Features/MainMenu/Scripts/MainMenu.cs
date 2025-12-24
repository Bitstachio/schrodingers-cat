using UnityEngine;

namespace Features.MainMenu.Scripts
{
    // TODO: This works, but I'm not sure if it's best practice; especially for panels game object array
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject backButton;
        [SerializeField] private GameObject[] pages;

        public void BackToMain()
        {
            backButton.SetActive(false);
            // TODO: I don't like using a magic string here
            foreach (var page in pages) page.SetActive(page.name == "Main");
        }
    }
}