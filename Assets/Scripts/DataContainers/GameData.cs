using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.DataContainers
{
    [CreateAssetMenu(menuName = "SO/GameData")]
    public class GameData : ScriptableObject
    {
        public string userId;
        public string token;
        public string username;
        public List<float> results; 

        private void OnEnable()
        {
            userId = string.Empty;
            token = string.Empty;
            username = string.Empty;
        }
    }
}
