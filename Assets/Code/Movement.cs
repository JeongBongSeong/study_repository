using System;
using UnityEngine;

namespace JBS
{
    public class Movement
    {
        public void Init()
        {
        }

        public void Move(Character character)
        {
            character.transform.Translate(Input.GetAxis("Horizontal") * character.speed, 0, 0);
        }
    }
}