using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    static List<AABB> aabbs = new List<AABB>(); //list of all AABB objects, static list to have infinite AABBs but only have 1 list
    
    static public void Add(AABB obj) //adds object to AABB list
    {
        aabbs.Add(obj);
        //print("there are " + aabbs.Count + " AABBS registered");
    }
    static public void Remove(AABB obj) //removes object from AABB list
    {
        aabbs.Remove(obj);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () { //to make sure collision detection happens last, use LateUpdate to check after other game objects have moved


		foreach(AABB a in aabbs)
        {
            foreach(AABB b in aabbs)
            {
                if (a == b) continue; //to prevent checking against itself
                if (a.isDoneChecking || b.isDoneChecking) continue; //to prevent double checking

                if(a.CheckOverlap(b))
                {
                    //is overlapping
                    a.BroadcastMessage("OverlappingAABB", b);
                    b.BroadcastMessage("OverlappingAABB", a); //sending a message to the B object with reference to A, or "what it collided with"
                }
            }
            a.isDoneChecking = true; //finished checking against every other object
        }
	}
}
