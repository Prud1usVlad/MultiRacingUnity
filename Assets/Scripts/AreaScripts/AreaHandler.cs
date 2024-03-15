using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.AreaScripts
{
    class AreaHandler : MonoBehaviour
    {
        public AreaCollisionsReciever reciever;
        public string areaTag;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision != null && collision.gameObject.tag == "Player")
            {
                Debug.Log("Collision: " + areaTag);
                reciever.RecieveCollision(areaTag);
            }
        }
    }
}
