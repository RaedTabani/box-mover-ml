namespace Config{
    public interface IConfig 
    {
        public float agentRunSpeed{get;}
        public float agentMaxSpeed{get;}
        public float agentRotationSpeed{get;}
        public float agentMaxAngularSpeed{get;}
        public float spawnZoneMultiplier{get;} 
        public int maxTrainingSteps{get;}
    }
}