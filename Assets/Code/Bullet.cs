using System;
using UnityEngine;

namespace JBS
{
    public class Bullet : MonoBehaviour
    {
        private int lifeTime = 3;

        private void Start()
        {
            Destroy(gameObject, lifeTime);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}