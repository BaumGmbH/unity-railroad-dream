using UnityEngine;

public class DirectionChanger : MonoBehaviour
{
    //Public Variables
    public Rigidbody rigidbody;

    public GameObject turnLeft;
    //Private Variables
    private float moveToX;
    private float moveToY;

    private Vector3 moveTo;
    //Unity Methodes

    void Update()
    {
        moveToX = transform.position.x - turnLeft.transform.position.x;
        moveToY = transform.position.y - turnLeft.transform.position.y;

        moveTo = new Vector3(moveToX, 0, moveToY);

        transform.position = moveTo;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Cube") collision.gameObject.SetActive(false);
    }
}