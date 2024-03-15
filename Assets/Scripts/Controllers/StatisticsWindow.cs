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
    public class StatisticsWindow : MonoBehaviour
    {
        public GameData gameData;

        public TextMeshProUGUI username;

        public List<TextMeshProUGUI> results;

        private void OnEnable()
        {
            var time = gameData.results.OrderBy(t => t).ToList();

            for (int i = 0; i < 10; i++) 
            {
                if (i < gameData.results.Count) 
                {
                    results[i].SetText(time[i].FormatToTimerResult());
                }
                else
                {
                    results[i].SetText("-- : -- : ---");
                }
            }

            username.SetText(gameData.username);
        }
    }
}
