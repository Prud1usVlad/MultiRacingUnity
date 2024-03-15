using System;
using System.Collections.Generic;

namespace Assets.Scripts.Network.Models
{
    [Serializable]
    public class UserModel
    {
        public string id;
        public string name;
        public List<float> results;
    }
}
