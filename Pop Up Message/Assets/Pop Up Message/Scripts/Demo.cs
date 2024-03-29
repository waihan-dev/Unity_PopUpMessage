using UnityEngine;
using PopUpMessage.Service;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    [TextArea (5, 20)]public string longText ;
    public void Button1()
    {
        NotificationService.ShowGeneral(
            "Notice",
            longText,
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

    public void Button3()
    {
        NotificationService.ShowSuccess(
            "Success",
            "Welcome to world!",
            "Success",
            () => ChangeScene(),
            "Close",
            null
        );
    }

    public void Button4()
    {
        NotificationService.ShowError(
            "Error",
            "Danger world!",
            "Error",
            null,
            "Close",
            null
        );
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Demo2",LoadSceneMode.Single);
    }
}
