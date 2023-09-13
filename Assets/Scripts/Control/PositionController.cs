using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Config;

namespace Control{
    public class PositionController : MonoBehaviour
    {
        private IConfig config;
        
        [Inject]
        public void Init(IConfig config)
        {
            this.config = config;
            Debug.Log($"CONFIG CONNECTED TO {gameObject.name}");
        }

    }
}