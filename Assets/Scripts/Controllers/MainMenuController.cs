using Assets.Scripts.DataContainers;
using Assets.Scripts.Network;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controllers
{
    public class MainMenuController : MonoBehaviour
    {
        public TMP_InputField nameField_L;
        public TMP_InputField passField_L;

        public TMP_InputField nameField_R;
        public TMP_InputField passField_R;

        public TextMeshProUGUI usernameField;
        public TextMeshProUGUI errorText;

        public GameObject notLoginedModal;
        public GameObject loginModal;
        public GameObject registerModal;
        public GameObject statisticsModal;
        public GameObject errorModal;
        public GameObject loadingPanel;

        public GameData gameData;

        public void OnStartGame()
        {
            if (gameData.userId != string.Empty)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                notLoginedModal.SetActive(true);
            }
        }

        public void OnStatistic()
        {
            if (gameData.userId != string.Empty)
            {
                ToggleStatistic();
            }
            else
            {
                notLoginedModal.SetActive(true);
            }
        }

        public void OnLogin()
        {
            loadingPanel.SetActive(true);
            HttpService.Instance.Login(
                nameField_L.text, 
                passField_L.text, 
                OnAuthorized, 
                OpenError
            );
        }

        public void OnRegister()
        {
            loadingPanel.SetActive(true);
            HttpService.Instance.Register(
                nameField_R.text, 
                passField_R.text, 
                OnAuthorized,
                OpenError
            );
        }

        public void ShowLogin()
        {
            loginModal.SetActive(true);

            registerModal.SetActive(false);
            notLoginedModal.SetActive(false);
        }

        public void ShowRegister()
        {
            registerModal.SetActive(true);

            loginModal.SetActive(false);
            notLoginedModal.SetActive(false);
        }

        public void ToggleStatistic()
        {
            statisticsModal.SetActive(!statisticsModal.activeSelf);
        }

        public void OpenError(string message)
        {
            errorModal.SetActive(true);
            errorText.SetText(message);
        }

        public void CloseError()
        {
            errorModal.SetActive(false);
        }

        private void OnAuthorized()
        {
            if (gameData.userId != string.Empty && gameData.token != string.Empty)
            {
                HttpService.Instance.SetToken(gameData.token);
                HttpService.Instance.GetUserData(
                    gameData.userId,
                    () => usernameField.SetText(gameData.username),
                    OpenError
                );
            }

            loginModal.SetActive(false);
            registerModal.SetActive(false);
            loadingPanel.SetActive(false);

        }
    }
}
