using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class CameraController : MonoBehaviour
    {
        public Transform target;
        public float smoothSpeed = 0.125f;
        public Vector3 offset = new Vector3(0, 0, 10);

        private void LateUpdate()
        {
            var newPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, newPosition, smoothSpeed);

            transform.LookAt(target);
        }
    }
}
