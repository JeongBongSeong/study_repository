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
            // 싱글톤 패턴 구현
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);  // 씬 전환 시에도 객체가 파괴되지 않도록
            }
            else
            {
                Destroy(gameObject);  // 이미 존재하는 인스턴스가 있으면, 새로운 인스턴스를 파괴
            }
            
            movement = new Movement();
            character = GameObject.Find("Player").GetComponent<Player>();
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
    
}
