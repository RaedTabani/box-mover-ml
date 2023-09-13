namespace Config{
    public class TrainingConfig : IConfig
    {
        //Speed
        public float agentRunSpeed => _agentRunSpeed;
        public float agentMaxSpeed =>_agentRunSpeed;
        //Rotation
        public float agentRotationSpeed => _agentRotationSpeed;
        public float agentMaxAngularSpeed => _agentRotationSpeed;

        public float spawnZoneMultiplier => _spawnZoneMultiplier;
        public int maxTrainingSteps => _maxTrainingSteps;

        private float _agentRunSpeed = 80;
        private float _agentMaxSpeed = 3;        
        private float _agentRotationSpeed = 50;
        private float _agentMaxAngularSpeed = 4;
        private float _spawnZoneMultiplier = .9f;
        private int _maxTrainingSteps = 25000;
    }
}