using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityLife : MonoBehaviour, IHitable
{
    [SerializeField] int lifes;

    public void TakeDamage(int _damage){
        lifes -= _damage;
    }
}
