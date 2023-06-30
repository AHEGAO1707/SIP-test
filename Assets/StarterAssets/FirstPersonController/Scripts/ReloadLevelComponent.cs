using UnityEngine;
using UnityEngine.SceneManagement;

namespace StarterAssets
{
    public class ReloadLevelComponent : MonoBehaviour
    {
        public static void Reload()
        {
            Debug.Log("Перезагрузка уровня");
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
