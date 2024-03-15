using Assets.Scripts.Controllers;
using Assets.Scripts.Network;
using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.DataContainers
{
    public class UserGameData : MonoBehaviour
    {
        private bool networkInstance = true;
        [SerializeField]

        public GameData gameData;

        public string username;
        public int colorSchemeIndex;
        public float fastestLap = float.MaxValue;
        public float currentTimer;

        public void OnEnable()
        {
            if (!gameObject.name.Contains("Clone"))
            {
                networkInstance = false;
                username = gameData.username;
                //fastestLap = gameData.results.Count > 0 ? gameData.results.Min() : float.MaxValue;
            }
        }

        public void AddResult(float timer)
        {
            //gameData.results.Add(timer);
            //fastestLap = gameData.results.Min();
            fastestLap = Mathf.Min(fastestLap, timer);
        }

        public void OnInstantiate()
        {
            Debug.Log("other added");
            PointsController.Instance.OnOtherInstantiated(this);
        }

        public void OnDissconect()
        {
            Debug.Log(username + " destroyed");
            PointsController.Instance.OnOtherDestroyed(this);

            if (!networkInstance && fastestLap != 0 && fastestLap < 100000) 
            {
                gameData.results.Add(fastestLap);
                HttpService.Instance.UpdateResults(gameData.userId, gameData.results);
            }

            SceneManager.LoadScene(0);
        }
    }
}
