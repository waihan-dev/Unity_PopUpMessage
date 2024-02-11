using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PopUpMessage.UI
{
    public class PopUpMessageBox : MonoBehaviour
    {
        [Header("UI Variables")]
        [SerializeField] private GraphicRaycaster graphicRaycaster;
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private GameObject titleHeader;
        [SerializeField] private TextMeshProUGUI titleText;
        [SerializeField] private TextMeshProUGUI descriptionText;
        [SerializeField] private Button actionOneButton;
        [SerializeField] private Button actionTwoButton;
        [SerializeField] private TextMeshProUGUI buttonOneText;
        [SerializeField] private TextMeshProUGUI buttonTwoText;
        [SerializeField] private Image buttonOneImage;
        [SerializeField] private Image buttonTwoImage;

        [Header("Fade Duration")]
        [Range(.1f, 1f)][SerializeField] private float fadeInDuration = .3f;
        [Range(.1f, 1f)][SerializeField] private float fadeOutDuration = .3f;

        void Start()
        {
            Init();
        }

        private void Init()
        {
            canvasGroup.alpha = 0f;
        }

        public void Show(string title, string description, string buttonOneText, Action actionOne, string buttonTwoText, Action actionTwo)
        {
            this.titleText.text = title;
            this.descriptionText.text = description;
            SetupButton(actionOneButton, this.buttonOneText, buttonOneText, actionOne);
            SetupButton(actionTwoButton, this.buttonTwoText, buttonTwoText, actionTwo);

            canvasGroup.alpha = 0;
            StartCoroutine(FadeIn(fadeInDuration));
        }

        private void SetupButton(Button button, TextMeshProUGUI buttonText, string text, Action action)
        {
            button.gameObject.SetActive(!string.IsNullOrEmpty(text));

            if (!string.IsNullOrEmpty(text))
            {
                buttonText.text = text;
                button.onClick.RemoveAllListeners();

                // If no specific action is provided, default to HideNotification
                Action finalAction = action ?? (() => HideNotification());

                button.onClick.AddListener(() =>
                {
                    finalAction.Invoke();
                    StartCoroutine(FadeOut(fadeOutDuration));
                });
            }
            else
            {
                button.gameObject.SetActive(false);
            }
        }

        private IEnumerator FadeIn(float duration)
        {
            float startTime = Time.time;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;

            while (Time.time < startTime + duration)
            {
                canvasGroup.alpha = Mathf.Lerp(0, 1, (Time.time - startTime) / duration);
                yield return null;
            }

            canvasGroup.alpha = 1f;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            graphicRaycaster.enabled = true;
        }

        private IEnumerator FadeOut(float duration)
        {
            float startTime = Time.time;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
            graphicRaycaster.enabled = false;

            while (Time.time < startTime + duration)
            {
                canvasGroup.alpha = Mathf.Lerp(1, 0, (Time.time - startTime) / duration);
                yield return null;
            }
            canvasGroup.alpha = 0f;
        }

        public void HideNotification()
        {
            StartCoroutine(FadeOut(fadeOutDuration));
        }

        private void OnDestroy()
        {

        }
    }

}