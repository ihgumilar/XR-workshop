using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    //public Vector3[] positions;
    public float range= 3;
    bool pressedSpace = false;

    //void Start()
    //{
    //    range= 3; //maxRange = 10;
    //}

    //private void OnCollisionEnter(Collision other)
    //{
    //    //if (other.gameObject.tag == "Player")
    //    // PUT 

    //}
    
    private void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Space) && gameObject.tag == "Player" && !pressedSpace)
        {
            print("in fal");
            float randomNumber_x = Random.Range( -range, range);
            float randomNumber_y = Random.Range(4, range* 5);
            float randomNumber_z = Random.Range(-range, range);

            transform.position = new Vector3(randomNumber_x, randomNumber_y, randomNumber_z);
            gameObject.AddComponent<BoxCollider>();
            Rigidbody fall = GetComponent<Rigidbody>();
            fall = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
            fall.useGravity = true;
            pressedSpace = true;
        }
    }
}

// To do
// 1. Counting children (done)
// 2. Tag for each child (done)
// 3. Add rigibody for each tagged child (done)
// 4. Try with the real design
// 4.1. Replace the start function
// 4.2. Assign the rigidbody
// 4.3. Create a tag
// 5. Add colision
// 6. Put it back to original position
// 7. If the distance is less, then attach it



//{
//    // Start is called before the first frame update
//    //public Vector3[] positions;
//    public Vector3 minRange;
//    public Vector3 maxRange;

//    void Start()
//    {
//        float randomNumber_x = Random.Range(minRange.x, maxRange.x);
//        float randomNumber_y = Random.Range(minRange.y, maxRange.y);
//        float randomNumber_z = Random.Range(minRange.z, maxRange.z);

//        transform.position = new Vector3(randomNumber_x, randomNumber_y, randomNumber_z);
//    }

//    private void OnCollisionEnter(Collision other)
//    {
//        //if (other.gameObject.tag == "Player")
//        //{

//        }
//    }

//}

