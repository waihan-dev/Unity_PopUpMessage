using UnityEngine;
using PopUpMessage.UI;
using System;

namespace PopUpMessage.Service
{
    public class NotificationService
    {
        #region  Init
        private static PopUpMessageBox popUpMessageBox;

        private static PopUpMessageBox InitializeUIManager()
        {
            if (popUpMessageBox == null || popUpMessageBox.Equals(null))
            {
                PopUpMessageBox prefab = Resources.Load<PopUpMessageBox>("PopUpMessageBox");
                if (prefab != null)
                {
                    popUpMessageBox = GameObject.Instantiate(prefab);
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
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, generalColorScheme);
        }

        public static void ShowWarning(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, warningColorScheme);
        }

        public static void ShowSuccess(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, successColorScheme);
        }

        public static void ShowError(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction, errorColorScheme);
        }
        #endregion

        //------------------------------------------------------------------------------------------------------------------//

        #region Color
        private static readonly NotificationColorScheme generalColorScheme = new NotificationColorScheme
        {
            panelColor = Color.white,
            headerColor = new Color32(169, 169, 169, 255), //Dark Grey
            titleColor = Color.black,
            descriptionColor = new Color32(105, 105, 105, 255),//Dim Grey
            buttonTextColor = Color.white,
            buttonBackgroundColor = Color.blue
        };

        private static readonly NotificationColorScheme warningColorScheme = new NotificationColorScheme
        {
            panelColor = Color.yellow,
            headerColor = Color.red,
            titleColor = Color.white,
            descriptionColor = Color.red,
            buttonTextColor = Color.black,
            buttonBackgroundColor = Color.yellow
        };

        private static readonly NotificationColorScheme successColorScheme = new NotificationColorScheme
        {
            panelColor = Color.green,
            headerColor = new Color32(0, 100, 0, 255), //Dark Green
            titleColor = Color.white,
            descriptionColor = new Color32(144, 238, 144, 255), //Light Green
            buttonTextColor = Color.white,
            buttonBackgroundColor = new Color32(0, 100, 0, 255), //Dark Green
        };

        private static readonly NotificationColorScheme errorColorScheme = new NotificationColorScheme
        {
            panelColor = Color.red,
            headerColor =  new Color32(139, 0, 0, 255), //Dark red
            titleColor = Color.white,
            descriptionColor = Color.red,
            buttonTextColor = Color.white,
            buttonBackgroundColor = Color.red
        };
        #endregion
    }
}

