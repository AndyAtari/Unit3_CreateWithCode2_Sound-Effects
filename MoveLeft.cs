using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerController playerControllerScript;

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
    }
}