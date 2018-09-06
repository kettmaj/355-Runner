using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABB : MonoBehaviour {
    

    MeshRenderer _mesh; //reference to our mesh renderer, currently a 'private field' // private c# field

    public MeshRenderer mesh //making a "function" called properties in unity  //C# property
    {
        get
          {
            if (!_mesh) _mesh = GetComponent<MeshRenderer>(); //lazy initialization
            return _mesh;
        }
    }

    public Bounds bounds //c# property
    {
        get
        {
            return mesh.bounds;
        }
    }

    [HideInInspector] public bool isDoneChecking = false;

    bool isOverlapping = false;

	// Use this for initialization
	void Start () {
        CollisionController.Add(this);
	}

    void OnDestroy()
    {
        CollisionController.Remove(this);
    }
	
	// Update is called once per frame
	void Update () {
        isDoneChecking = false;
        isOverlapping = false;
	}

    void OnDrawGizmos()
    {
        Gizmos.color = isOverlapping ? Color.red :  Color.green; //tertiary operator, 1 line if/else
        Gizmos.DrawWireCube(transform.position, mesh.bounds.size); //only shows in editor while the game is running
    }

    /// <summary>
    /// Checks to see if some other AABB overlaps with this AABB
    /// </summary>
    /// <param name="othr">The other AABB component to check against.</param>
    /// <returns>If true, the ottwo AABBs overlap</returns>
    public bool CheckOverlap(AABB othr)
    {
        if (othr.bounds.min.x > this.bounds.max.x) return false;
        if (othr.bounds.max.x < this.bounds.min.x) return false;

        if (othr.bounds.min.y > this.bounds.max.y) return false;
        if (othr.bounds.max.y < this.bounds.min.y) return false;

        if (othr.bounds.min.z > this.bounds.max.z) return false;
        if (othr.bounds.max.z < this.bounds.min.z) return false;


        return true;
    }

    void OverlappingAABB (AABB other)
    {
        //print("ouch");
        isOverlapping = true;
    }
        
 }
