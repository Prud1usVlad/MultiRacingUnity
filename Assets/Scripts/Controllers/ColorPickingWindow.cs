using Assets.Scripts.DataContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
    public class ColorPickingWindow : MonoBehaviour
    {
        private List<Button> buttons;

        public Transform buttonsParent;
        public ColorSchemeController carColor;

        public UserGameData user;

        public void OnConnected()
        {
            StartCoroutine(InitRoutine());
        }

        public void ColorPicked(int index)
        {
            user.colorSchemeIndex = index;
            gameObject.SetActive(false);
        }

        private IEnumerator InitRoutine()
        {
            yield return new WaitForSeconds(1);

            buttons = new List<Button>();
            var count = 0;
            var used = PointsController.Instance.users.Select(u => u.colorSchemeIndex).ToHashSet();

            foreach (Transform child in buttonsParent)
            {
                var btn = child.GetComponent<Button>();
                //btn.onClick.AddListener(() => ColorPicked(count));

                buttons.Add(btn);

                //Debug.Log("Button: " + btn.name + " Count: " + count);

                if (used.Contains(count))
                    btn.enabled = false;

                count++;
            }
        }

    }
}
