using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bird : MonoBehaviour
{
    public int vitesse = 3;
    [SerializeField] Transform fruitSpawn;
    public GameObject[] fruitTables;
    GameObject fruit;

    // Start is called before the first frame update
    void Start()
    {
        //Initialiser le fruit
        ShowFruit();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //Faire une copie de la position du joueur
        Vector3 playerPosition = transform.position;

        //Appliquer le deplacement a la copie
        playerPosition += new Vector3(x, y, 0) *Time.deltaTime*vitesse;

        //Ajuster la position pour rester entre le minimum et le maximum
        playerPosition.x = Mathf.Clamp(playerPosition.x, -6.62f, 7.0f);
        playerPosition.y = Mathf.Clamp(playerPosition.y, 3.2f, 4.20f);

        //Appliquer la nouvelle position
        transform.position = playerPosition;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            fruit.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            fruit.transform.parent = null;
            Invoke("ShowFruit", 1.0f) ;
        }
    }

    public void ShowFruit()
    {
        int fruitRandomTable = Random.Range(0, fruitTables.Length);
        GameObject fruitTable = fruitTables[fruitRandomTable];
        fruit = Instantiate(fruitTable, fruitSpawn.position, Quaternion.identity, fruitSpawn);
    }
}
