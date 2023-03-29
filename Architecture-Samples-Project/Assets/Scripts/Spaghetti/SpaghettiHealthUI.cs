using TMPro;
using UnityEngine;

namespace Spaghetti
{
    public class SpaghettiHealthUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI          healthText;
        [SerializeField] private SpaghettiPlayerCharacter player;

        private int _lastHealth;

        private void Awake()
        {
            _lastHealth = -1;
        }
        
        private void Update()
        {
            if (_lastHealth != player.Health) UpdateHealth(player.Health);
        }

        private void UpdateHealth(int newHealth)
        {
            healthText.SetText(newHealth.ToString("D"));
            _lastHealth = newHealth;
        }
    }
}