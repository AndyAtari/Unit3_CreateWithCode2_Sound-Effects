using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerController playerControllerScript;
    private float leftBound = -13;

    // Start is called before the first frame update
    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerControllerScript.gameOverMan == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //Destroys object if it is an Obstacle and it's past the left boundary 
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}