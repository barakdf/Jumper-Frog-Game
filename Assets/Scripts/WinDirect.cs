
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDirect : MonoBehaviour {
    [SerializeField] string sceneName;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Frog") {
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
        }
    }
}
