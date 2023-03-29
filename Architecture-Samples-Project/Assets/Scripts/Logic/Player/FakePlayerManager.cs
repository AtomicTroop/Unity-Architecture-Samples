using System;

namespace Logic.Player
{
    class FakePlayerManager : IPlayerManager
    {
        public event Action<int> HealthChanged;

        public int GetHealth()
        {
            return 50;
        }

        public void UpdateHealth(int change)
        {
            HealthChanged?.Invoke(change);
        }
    }
}