using UnityEngine;

[System.Serializable]
public class NotificationColorScheme
{
   public Color panelColor = Color.white;
    public Color headerColor = Color.white;
    public Color titleColor = Color.black;
    public Color descriptionColor = Color.black;
    public Color buttonTextColor = Color.white;
    public Color buttonBackgroundColor = Color.gray;

    // Default scheme
    public static NotificationColorScheme Default => new NotificationColorScheme();
}
