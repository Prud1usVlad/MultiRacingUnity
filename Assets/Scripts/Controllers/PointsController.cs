using Assets.Scripts.AreaScripts;
using Assets.Scripts.DataContainers;
using Assets.Scripts.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class PointsController : AreaCollisionsReciever
    {
        public static PointsController Instance;

        public List<UserGameData> users;

        private float timer;

        public bool lapInit = false;
        public bool lapPreFinish = false;
        public bool lapFinish = false;

        public TextMeshProUGUI timerText;
        public TextMeshProUGUI fastestLap;
        public UserGameData currentPlayer;

        public void Awake()
        {
            if (Instance == null)
            {
                users = new List<UserGameData>();
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public override void RecieveCollision(string tag)
        {
            switch (tag)
            {
                case "FinishArea":
                    if (!lapInit)
                    {
                        lapInit = true;
                        lapPreFinish = false;
                    }
                    else
                    {
                        if (lapPreFinish)
                        {
                            lapFinish = true;
                            lapPreFinish = false;
                            lapInit = true;

                            currentPlayer.AddResult(timer);
                            fastestLap.SetText(currentPlayer.fastestLap.FormatToTimerResult());
                        }
                        else
                        {
                            lapInit = false;
                            lapPreFinish = false;
                            lapFinish = false;
                        }

                        timer = 0;
                    }
                        

                    break;

                case "PreFinishArea":
                    lapPreFinish = true;
                    break;
            }
        }

        public void OnOtherInstantiated(UserGameData data)
        {
            Debug.Log("Other car: " + data.username);
            users.Add(data);
            fastestLap.SetText(data.fastestLap.FormatToTimerResult());
        }

        public void OnOtherDestroyed(UserGameData data)
        {
            Debug.Log("Destroyed: " + data.username);
            users.Remove(data);
            //fastestLap.SetText(data.fastestLap.FormatToTimerResult());
        }

        private void Update()
        {
            if (lapInit)
            {
                timer += Time.deltaTime;

                timerText.SetText(timer.FormatToTimerResult());
            }

            currentPlayer.currentTimer = timer;
            users = users.OrderBy(u => u.fastestLap).ToList();
        }
    }
}
