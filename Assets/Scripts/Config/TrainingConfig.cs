namespace Config{
    public class TrainingConfig : IConfig
    {
        public float agentRunSpeed => _agentRunSpeed;

        public float agentRotationSpeed => _agentRotationSpeed;

        public float spawnZoneMultiplier => _spawnZoneMultiplier;

        private float _agentRunSpeed = 3;
        private float _agentRotationSpeed = 2;
        private float _spawnZoneMultiplier = .9f;
    }
}