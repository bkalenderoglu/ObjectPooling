using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : AutoDestroyPoolableObject
{
    [HideInInspector]
    public Rigidbody2D rigidbody;
    public Vector2 speed = new Vector2(200, 0);

    private void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public override void OnEnable() {
        base.OnEnable();
        rigidbody.velocity = speed;
    }

    public override void OnDisable() {
        base.OnDisable();

        rigidbody.velocity = Vector2.zero;
    }
}
