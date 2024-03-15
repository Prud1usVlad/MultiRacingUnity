using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.DataContainers
{
    public class CarControllerData : MonoBehaviour
    {
        public float accelerationInput;
        public float steeringInput;

        public float rotationAngle;

        public float velocityVsUp;

        public bool isTireScreeching;
        public float lateralVelocity;
        public bool isbraking;
    }
}
