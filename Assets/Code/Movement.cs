using System;
using UnityEngine;

namespace JBS
{
    public class Movement : MonoBehaviour
    {
        public float speed;

        public void Init(float speed)
        {
            speed = speed;
        }

        public void Move(Character character)
        {
            character.transform.Translate(Input.GetAxis("Horizontal") * speed, 0, 0);
        }
    }
}