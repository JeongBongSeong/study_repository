using System.Collections.Generic;
using UnityEngine;

namespace JBS
{
    public class PlayerMissileManager : MonoBehaviour
    {
        public List<Bullet> bullets = new List<Bullet>();
        
        public void Fire(Character character)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                GameObject bullet = Instantiate(character.Bullet_A, character.transform.position, character.transform.rotation);
                Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
                rigid.AddForce(Vector2.right * 10, ForceMode2D.Impulse);
                
                bullets.Add(bullet.GetComponent<Bullet>());
            }
        }
    }
}