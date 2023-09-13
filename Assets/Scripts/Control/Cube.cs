using UnityEngine;
using Events;

namespace Control{
    [RequireComponent(typeof(PositionController))]
    public class Cube : MonoBehaviour
    {
        private PositionController controller;

        private void OnEnable(){
            EventBus.Subscribe(TrainingEventType.Gamewin,Reset);
            EventBus.Subscribe(TrainingEventType.Gamelose,Reset);
        }
        private void OnDisable(){
            EventBus.Subscribe(TrainingEventType.Gamewin,Reset);
            EventBus.Subscribe(TrainingEventType.Gamelose,Reset);
        }
        private void Awake(){
            controller = GetComponent<PositionController>();
        }

        private void Reset(){
            controller.Reset();
        }
    }
}