using Events;
using UnityEngine;

namespace Control{
    [RequireComponent(typeof(BoxCollider))]
    public class GoalController : MonoBehaviour
    {
        public string targetTag;
        private void OnTriggerEnter(Collider other) {
            if(other.CompareTag(targetTag)){
                EventBus.Publish(TrainingEventType.Gamewin);
            }    
        }
    }
}