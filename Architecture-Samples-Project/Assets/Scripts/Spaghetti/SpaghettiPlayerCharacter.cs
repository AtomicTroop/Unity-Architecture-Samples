using UnityEngine;
using Visualization;

namespace Spaghetti
{
    public class SpaghettiPlayerCharacter : MonoBehaviour
    {
        [SerializeField] private int maxHealth;

        [field: SerializeField] public int Health { get; private set; }
        
        private void Awake()
        {
            Health = maxHealth;
        }

        private void Update()
        {
            // handle inputs
            // move player around
        }

        private void Die()
        {
            // handle dying
            Debug.Log("Dead");
        }

        private void TakeDamage(int amount)
        {
            Health = Mathf.Clamp(Health - amount, 0, maxHealth);
            Debug.Log($"Damage {amount}!");
            if (Health == 0) Die();
        }

        private void OnTriggerEnter(Collider other)
        {
            var hurtbox = other.GetComponent<Hurtbox>();
            if (hurtbox != null) TakeDamage(hurtbox.Damage);
        }
    }
}