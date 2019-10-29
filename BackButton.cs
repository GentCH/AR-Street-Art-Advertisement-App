//Code to back to previous screen or change scene using device "back key"

public class BackButton : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("WMainScene");
        }
    }
}
