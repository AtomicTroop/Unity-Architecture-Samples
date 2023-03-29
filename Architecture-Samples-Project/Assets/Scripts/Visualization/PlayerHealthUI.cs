using Logic.Player;
using TMPro;
using UnityEngine;

namespace Visualization
{
    public class PlayerHealthUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI healthText;

        private IPlayerManager _playerManager;

        private void Awake()
        {
            _playerManager = ServiceLocator.GetService<IPlayerManager>();
        }

        private void OnEnable()
        {
            _playerManager.HealthChanged += UpdateHealth;
            UpdateHealth(_playerManager.GetHealth());
        }
        
        private void OnDisable()
        {
            _playerManager.HealthChanged -= UpdateHealth;
        }

        private void UpdateHealth(int newHealth)
        {
            healthText.SetText(newHealth.ToString("D"));
        }
    }
}
