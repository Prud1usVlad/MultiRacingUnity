using Assets.Scripts.DataContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Effects
{
    public class SkidmarksHandler : MonoBehaviour
    {
        public CarController controller;
        public List<TrailRenderer> trails;

        private void Awake()
        {
            SetTrailsEmiting(false);
        }

        private void SetTrailsEmiting(bool emiting)
        {
            foreach (var trail in trails)
            {
                trail.emitting = emiting;
            }
        }

        private void Update()
        {
            if (controller.IsTireScreeching(out var vel, out var br))
                SetTrailsEmiting(true);
            else
                SetTrailsEmiting(false);
        
        }
    }
}
