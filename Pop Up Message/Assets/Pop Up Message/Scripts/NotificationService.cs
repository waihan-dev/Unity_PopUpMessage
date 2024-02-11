using System.Collections;
using System.Collections.Generic;
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
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction);
        }

        public static void ShowWarning(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction);
        }

        public static void ShowSuccess(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction);
        }

        public static void ShowError(string title, string description, string buttonOneText, Action buttonOneAction, string buttonTwoText, Action buttonTwoAction)
        {
            InitializeUIManager();
            popUpMessageBox.Show(title, description, buttonOneText, buttonOneAction, buttonTwoText, buttonTwoAction);
        }
    }
    #endregion
}

