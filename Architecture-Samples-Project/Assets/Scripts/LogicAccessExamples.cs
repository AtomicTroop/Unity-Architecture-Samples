using Logic.Player;
using UnityEngine;

namespace DefaultNamespace
{
    public class LogicAccessExamples
    {
        private static PlayerManager _singleton;

        public static IPlayerManager Singleton
        {
            get
            {
                if (_singleton == null) _singleton = new PlayerManager();
                return _singleton;
            }
        }

        public PlayerManager FindPlayerManager()
        {
            return GameObject.Find("PlayerManager")?.GetComponent<PlayerManager>();
        }
    }
}