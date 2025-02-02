using UnityEngine;

namespace JBS
{
    public class Opponent : Character
    {
        public void takeDamage(int damage)
        {
            health += damage;
        }

        public void chackHealth()
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}