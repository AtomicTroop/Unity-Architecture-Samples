using System;
using UnityEngine;

namespace Logic.Player
{
    public class PlayerManager : IPlayerManager
    {
        private Data.Player _state;

        public PlayerManager() : this(new Data.Player()) { }

        public PlayerManager(Data.Player initialState)
        {
            _state = initialState;
        }

        public event Action<int> HealthChanged;

        public int GetHealth()
        {
            return _state.health;
        }

        public void UpdateHealth(int change)
        {
            Debug.Log($"Damage in PlayerManager: {change}!");
            _state.health = Mathf.Clamp(_state.health + change, 0, _state.maxHealth);
            HealthChanged?.Invoke(_state.health);
        }

        public void SaveState()
        {
            JsonUtility.ToJson(_state);
            // write state to file
        }

        public void LoadState()
        {
            // read file
            var stateFromFile = "";
            _state = JsonUtility.FromJson<Data.Player>(stateFromFile);
        }
    }
}