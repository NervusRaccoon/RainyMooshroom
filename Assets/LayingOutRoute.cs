using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class LayingOutRoute : MonoBehaviour
{

    // Use this for initialization
    public Texture2D image;
	public Rigidbody rb;
    public bool[,] map = new bool[10, 10];
	public GameObject player;
	RaycastHit hit;

    void Start()
    {
        for (int i = 0; i < image.width; i++)
        {
            for (int j = 0; j < image.height; j++)
            {
                if (image.GetPixel(i, j) == Color.white)
                {
                    map[i, j] = false;
                }
                else
                {
                    map[i, j] = true;
                }
            }
        }
		player = GameObject.Find ("Player");
		rb = player.GetComponent<Rigidbody> ();
		//rb = GetComponent<Rigidbody>();
    }

    PathFinder Path = new PathFinder();

    private Vector3 PointerPosition;
	public Vector3 teleportPoint;
    private bool StartExists;
    GameObject StartMark;
    GameObject FinishMark;
    Vector2Int startPos = Vector2Int.zero;
    List<Vector3> path;

    // Update is called once per frame

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {                
				startPos = new Vector2Int((int)player.transform.position.x, (int)player.transform.position.z);
                PointerPosition = hit.collider.transform.position;
				Vector2Int goal = new Vector2Int((int)PointerPosition.x, (int)PointerPosition.z);
                var path = Path.FindPath(map, startPos, goal);

                if (path != null)
                {
					player.GetComponent<CharacterMovement> ().SetPath (path);
                }
                else
                {
                    Debug.Log("No route available");
                }
            }
        }
    }
}
