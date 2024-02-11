using UnityEngine;
using PopUpMessage.UI;
using System;

namespace PopUpMessage.Service
{
    public class NotificationService
    {
        #region  Init
        private static Sprite generalIcon = Resources.Load<Sprite>("info");
        private static Sprite warningIcon = Resources.Load<Sprite>("warning");
        private static Sprite successIcon = Resources.Load<Sprite>("success");
        private static Sprite errorIcon = Resources.Load<Sprite>("error");
        private static PopUpMessageBox popUpMessageBox;

        private static PopUpMessageBox InitializeUIManager()
        {
            if (popUpMessageBox == null || popUpMessageBox.Equals(null))
            {
                PopUpMessageBox prefab = Resources.Load<PopUpMessageBox>("PopUpMessageBox");
                if (prefab != null)
                {
                    popUpMessageBox = GameObject.Instantiate(prefab);
                    popUpMessageBox.gameObject.name = "Notification";
                }
                else
                {
                    Debug.LogError("PopUpMessageBox not found in Resources!");
                }
            }
            return popUpMessageBox;
        }
        #endregion

        //------------------------------------------------------------------------------------------------------------------//

        #region Services
        public static void ShowGeneral(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, generalColorScheme,generalIcon);
        }

        public static void ShowWarning(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, warningColorScheme,warningIcon);
        }

        public static void ShowSuccess(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, successColorScheme,successIcon);
        }

        public static void ShowError(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, errorColorScheme,errorIcon);
        }
        #endregion

        //------------------------------------------------------------------------------------------------------------------//

        #region Color
        private static readonly NotificationColorScheme generalColorScheme = new NotificationColorScheme
        {
            panelColor = new Color32(231,245,255, 255),//Super Light Blue
            titleColor = Color.black,
            descriptionColor = new Color32(105, 105, 105, 255),//Dim Grey
            buttonTextColor = Color.white,
            buttonBackgroundColor =new Color32(0, 84, 183, 255)
        };

        private static readonly NotificationColorScheme warningColorScheme = new NotificationColorScheme
        {
            panelColor = new Color32(254,248,219, 255),//Super Light Yellow
            titleColor = Color.black,
            descriptionColor = new Color32(105, 105, 105, 255),//Dim Grey
            buttonTextColor = Color.black,
            buttonBackgroundColor = new Color32(254, 171, 1, 255)
        };

        private static readonly NotificationColorScheme successColorScheme = new NotificationColorScheme
        {
            panelColor =new Color32(235, 251, 238, 255), //Super Light Green
            titleColor =  Color.black,
            descriptionColor = new Color32(0, 100, 0, 255), //Dark Green
            buttonTextColor = Color.white,
            buttonBackgroundColor = new Color32(0, 100, 0, 255), //Dark Green
        };

        private static readonly NotificationColorScheme errorColorScheme = new NotificationColorScheme
        {
            panelColor = new Color32(254, 244, 245, 255), //Super Light Red
            titleColor =  Color.black,
            descriptionColor = Color.red,
            buttonTextColor = Color.white,
            buttonBackgroundColor = Color.red
        };
        #endregion
    }
}

