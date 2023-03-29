using Logic.Player;
using UnityEngine;

namespace Visualization
{
    public class ServiceContext : MonoBehaviour
    {
        [SerializeField] private Data.Player initialPlayerState;
        
        private void Awake()
        {
            RegisterServices();
        }

        private void OnDestroy()
        {
            ServiceLocator.Reset();
        }

        private void RegisterServices()
        {
            ServiceLocator.RegisterService<IPlayerManager, PlayerManager>(new PlayerManager(initialPlayerState));
        }
    }
}