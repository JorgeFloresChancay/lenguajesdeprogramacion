using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    public GameObject objectPrefab;
    public float initialSpawnRate = 1f;
    public float increasedSpawnRate = 2f;
    public float fallSpeed = 5f;
    public Transform player; // Referencia al jugador
    public float timer = 30f; // Temporizador en segundos

    private float nextSpawnTime;
    private bool timerEnded = false;

    void Update()
    {
        // Actualizar el temporizador
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (!timerEnded)
        {
            timerEnded = true;
            initialSpawnRate = increasedSpawnRate; // Aumentar la velocidad de generación
        }

        // Generar objetos
        if (Time.time > nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + 1f / initialSpawnRate;
        }
    }

    void SpawnObject()
    {
        // Generar el objeto en la misma posición en el eje X que el jugador
        Vector3 spawnPos = new Vector3(player.position.x, transform.position.y, 0);
        GameObject fallingObject = Instantiate(objectPrefab, spawnPos, Quaternion.identity);
        fallingObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -fallSpeed);

        // Destruir el objeto después de 5 segundos
        Destroy(fallingObject, 5f);
    }
}
