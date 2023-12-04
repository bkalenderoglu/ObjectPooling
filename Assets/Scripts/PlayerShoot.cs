using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Bullet bulletPrefab;
    public int fireRate = 5;
    private ObjectPool bulletPool;

    private void Awake() {
        // bulletPool = ObjectPool.CreateInstance(bulletPrefab, 100);
    }

    private void Start() {
        StartCoroutine(Shoot()); 
    }

    private IEnumerator Shoot() {
        WaitForSeconds wait = new WaitForSeconds(1f / fireRate);

        while (true) {
            // PoolableObject instance = bulletPool.GetObject();
            Bullet instance = Instantiate(bulletPrefab);

            if (instance != null) {
                instance.transform.SetParent(transform, false);
                instance.transform.localPosition = Vector2.zero;
            }

            yield return wait;
        }
    }
}
