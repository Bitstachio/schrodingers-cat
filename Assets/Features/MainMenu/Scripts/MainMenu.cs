using UnityEngine;

namespace Features.MainMenu.Scripts
{
    // TODO: This is not best practice, so consider refactoring it in the future
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject backButton;
        [SerializeField] private GameObject[] pages;

        private void OpenPage(string target, bool hasBackButton = true)
        {
            backButton.SetActive(hasBackButton);
            foreach (var page in pages) page.SetActive(page.name == target);
        }

        public void BackToMain() => OpenPage("Main", false);

        public void OpenGuide() => OpenPage("Guide");

        public void OpenCredits() => OpenPage("Credits");
    }
}