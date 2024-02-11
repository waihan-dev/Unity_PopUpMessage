using UnityEngine;
using PopUpMessage.Service;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    public void Button1()
    {
        NotificationService.ShowGeneral(
            "Success",
            "Hello world!",
            "Action",
            () => ChangeScene(),
            "Close",
            null
        );
    }

    public void Button2()
    {
        NotificationService.ShowWarning(
            "Warning",
            "Alert world!",
            "Close",
            null,
            "",
            null
        );
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Demo2",LoadSceneMode.Single);
    }
}
