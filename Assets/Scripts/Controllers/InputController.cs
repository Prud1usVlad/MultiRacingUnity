using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class InputController : MonoBehaviour
    {
        private CarController carController;

        private void Awake()
        {
            carController = GetComponent<CarController>();
        }

        private void Update()
        {
            var input = Vector2.zero;

            input.x = Input.GetAxis("Horizontal");
            input.y = Input.GetAxis("Vertical");

            carController.SetInput(input);
        }
    }
}
