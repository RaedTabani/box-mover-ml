using System.Security;
using JetBrains.Annotations;

namespace Config{
    public interface IConfig 
    {
        public float agentRunSpeed{get;}
        public float agentRotationSpeed{get;}
        public float spawnZoneMultiplier{get;} 
        public int maxTrainingSteps{get;}

        public float reward{get;}
        public float punishment{get;}
        public float existantial{get;}
    }
}