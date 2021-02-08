
using UnityEngine;

public class MoveTransformPositionWithInputSmoothlyAndRotation : MonoBehaviour
{
    int direction;
    [SerializeField] private float _moveSpeed = 5;
    [SerializeField] private bool _polarized = true; // polarized feild has normal direction

    void Start()
    {


        if (_polarized == true)
        {
            direction = 1;

        }
        else
        {
            direction = -1;

        }


    }
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.D))
            transform.position +=Time.deltaTime * _moveSpeed * transform.right ;

        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _moveSpeed * -transform.right ;// negative right gives us left

        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _moveSpeed * transform.up  * direction;

        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _moveSpeed * -transform.up * direction; // negative up gives us down

        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(0, 0, 0);
        



    }
}
