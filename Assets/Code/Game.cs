using UnityEngine;


namespace JBS
{
    public class Game : MonoBehaviour
    {
        public static Game Instance;
        public Movement movement;
        public Character character;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Game.Instance = this;
            movement = new Movement();
            
            character = character.GetComponent<Player>();
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
    
}
