using Assets.Scripts.DataContainers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
    public class ColorSchemeController : MonoBehaviour
    {
        public UserGameData user;

        public List<Color> indicatorColors;
        public List<Sprite> sprites;

        public SpriteRenderer indicator;
        public SpriteRenderer car;

        public void Start()
        {
            StartCoroutine(ChangeColorRoutine());
        }

        private IEnumerator ChangeColorRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);

                if (user.colorSchemeIndex > 0)
                {
                    indicator.color = indicatorColors[user.colorSchemeIndex];
                    car.sprite = sprites[user.colorSchemeIndex];
                }
            }
        }

    }
}
