using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rigidbody;
    public float destroyTime = 1f;
    public Vector2 speed = new Vector2(200, 0);

    private const string destroyMethodName = "Destroy";

    private void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnEnable() {
        rigidbody.velocity = speed;
        Invoke(destroyMethodName, destroyTime);
    }

    public void Destroy() {
        GameObject.Destroy(this.gameObject);
    }
}
