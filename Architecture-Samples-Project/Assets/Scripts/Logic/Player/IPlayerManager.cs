using System;

namespace Logic.Player
{
    public interface IPlayerManager
    {
        event Action<int> HealthChanged;
        int               GetHealth();
        void              UpdateHealth(int change);
    }
}