using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace JBS
{
    public class Player : Character
    {
        [FormerlySerializedAs("missile")] public PlayerMissileManager missileManager;
        
        void Start()
        {
            missileManager = new PlayerMissileManager();
            speed = 0.01f;
        }

        public void Update()
        {
            //이동
            Game.Instance.movement.Move(this);
            missileManager.Fire(this);
        }
    }
}