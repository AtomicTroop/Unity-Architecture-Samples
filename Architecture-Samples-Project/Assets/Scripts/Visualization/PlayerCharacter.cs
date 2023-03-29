using Logic.Player;
using UnityEngine;

namespace Visualization
{
    public class PlayerCharacter : MonoBehaviour
    {
        private IPlayerManager _playerManager;

        private void Start()
        {
            _playerManager = ServiceLocator.GetService<IPlayerManager>();
        }
        
        private void TakeDamage(int amount)
        {
            _playerManager.UpdateHealth(-amount);
        }

        private void OnTriggerEnter(Collider other)
        {
            var hurtbox = other.GetComponent<Hurtbox>();
            if (hurtbox != null) TakeDamage(hurtbox.Damage);
        }
    }
}