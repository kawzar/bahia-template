using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   [SerializeField] private int playSceneOrder = 1;
   [SerializeField] private int creditsSceneOrder = 2;
   [SerializeField] private int menuSceneOrder = 0;
   
   public MenuManager Instance { get; private set; }

   private void Awake()
   {
      if (Instance == null)
      {
         Instance = this;
      }
   }

   public void GoToPlayScene()
   {
      SceneManager.LoadScene(playSceneOrder);
   }

   public void GoToCreditsScene()
   {
      SceneManager.LoadScene(creditsSceneOrder);
   }

   public void GoToMenuScene()
   {
      SceneManager.LoadScene(menuSceneOrder);
   }
}
