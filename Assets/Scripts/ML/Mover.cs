using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Control;
using Unity.Mathematics;

namespace AI{
    [RequireComponent(typeof(PositionController))]
    public class Mover : Agent
    {
        private PositionController controller;

        public override void Initialize(){
            controller = GetComponent<PositionController>();    
        }
        public override void OnEpisodeBegin()
        {
            
        }
        public override void OnActionReceived(ActionBuffers actions){
            ActionSegment<float> continousActions = actions.ContinuousActions;
            Vector3 direction = new Vector3(continousActions[0],0,continousActions[1]);
            Vector3 rotation = new Vector3(0,continousActions[2],0);

            controller.Move(direction);
            controller.Rotate(rotation);

        }
        public override void CollectObservations(VectorSensor sensor)
        {
           
        }

        public override void Heuristic(in ActionBuffers actionsOut)
        {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            float y = Input.GetAxis("Fire1");

            Vector3 direction = new Vector3(x,0,z);
            Vector3 rotation = new Vector3(0,y,0);

            controller.Move(direction);
            controller.Rotate(rotation);
        }

    }
}