using UnityEngine;

public class Bullet : MonoBehaviour{
    public float speed = 10f;
    private float timeSinceLastFrame;

    void Update(){
        timeSinceLastFrame += Time.deltaTime;
        Move();
    }

    public void Move(){
        transform.position += transform.forward * speed * timeSinceLastFrame;
    }
}
