using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cubes : MonoBehaviour
{
    //public GameObject lvl1pyramid;
    //public GameObject newparentgameobject;
    // Start is called before the first frame update
    void Start()
    {
     //   int numberOfChildre = lvl1pyramid.transform.childCount;
     //   GameObject[] pyramidpieces = lvl1pyramid.gameObject.transform.all;
        //for (int fchild = 0; fchild < pyramidpieces.Length; fchild++)
      //      for (int fchild = 0; fchild <numberOfChildre-1; fchild++)
       //     {
        //    lvl1pyramid.transform.GetChild(fchild).SetParent(transform);
        //    lvl1pyramid.transform.GetChild(fchild).gameObject.AddComponent<RandomPosition>();
         //   pyramidpieces[fchild].AddComponent<RandomPosition>();
         //   pyramidpieces[fchild].transform.SetParent(transform);
         
       // }


        //Transform[] children;

        //children = lvl1pyramid. GetComponentsInChildren< Transform>();
        ////Debug.Log(children.Length);


        //for (int nchild = 0; nchild < children.Length; nchild++)
        //{
        //    children[nchild].SetParent(transform);
        //    children[nchild].gameObject.AddComponent<RandomPosition>();
        //    children[nchild].gameObject.tag = "Player";
        //    //Debug.Log("Success");
        //}

        foreach (Transform child in this.transform)
        {
            //child.SetParent(transform);
            child.gameObject.AddComponent<RandomPosition>();
            child.gameObject.tag = "Player";
        }


    }

    //public void Update()
    //{
    //    Transform[] children;
    
    //    children = gameObject.GetComponentsInChildren<Transform>();
    //    //Debug.Log(children.Length);
    //    for (int nchild = 0; nchild < children.Length; nchild++)
    //    {
    //        children[nchild].gameObject.tag = "Player";
    //        //Debug.Log("Success");
    //    }
    //}




////ORIGINAL SCRIPT
//public class cubes : MonoBehaviour
//{
//    int size = 10;
//    // Start is called before the first frame update
//    void Start()
//    {
//        for (int x = 0; x < size; x++)
//            for (int y = 0; y < size; y++)
//                for (int z = 0; z < size; z++)
//                {
//                    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
//                    go.AddComponent<RandomPosition>();
//                    //RandomPosition rp= go.GetComponent< Ra>
//                    go.transform.position = new Vector3(x - size / 2, y + .5f, z - size / 2);
//                    go.transform.localScale = new Vector3(.9f, .9f, .9f);
//                    go.transform.SetParent(transform);

//                }
//    }
//    private void Update()
//    {
//        Transform[] children;
//        children = gameObject.GetComponentsInChildren<Transform>();
//        //Debug.Log(children.Length);
//        for (int nchild = 0; nchild < children.Length; nchild++)
//        {
//            children[nchild].gameObject.tag = "Player";
//            //Debug.Log("Success");
//        }
//    }


}
