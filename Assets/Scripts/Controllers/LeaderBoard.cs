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
    public class LeaderBoard : MonoBehaviour
    {
        private Dictionary<int, (TextMeshProUGUI bestLap, TextMeshProUGUI currentLap, TextMeshProUGUI name)> textFields;

        public PointsController pointsController;

        public List<GameObject> places;

        private void Awake()
        {
            textFields = new();

            foreach (var (place, i) in places.Select((p, i) => (p, i)))
            {
                var data = (place.transform.Find("Best/BestLap").GetComponent<TextMeshProUGUI>(),
                    place.transform.Find("Current/CurrentLap").GetComponent<TextMeshProUGUI>(),
                    place.transform.Find("Name").GetComponent<TextMeshProUGUI>());

                textFields.Add(i, data);
            }
        }

        private void Update()
        {
            foreach(var (user, i) in pointsController.users.Select((u, i) => (u, i)))
            {
                var fields = textFields[i];

                places[i].gameObject.SetActive(true);

                fields.bestLap.SetText(user.fastestLap.FormatToTimerResult());
                fields.currentLap.SetText(user.currentTimer.FormatToTimerResult());
                fields.name.SetText(user.username);
            }

            for (int i = pointsController.users.Count; i < 10; i++) 
            {
                places[i].gameObject.SetActive(false);
            }
        }

    }
}
