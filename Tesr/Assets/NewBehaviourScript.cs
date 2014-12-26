using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (transform.position.x < 5f)
            transform.position = transform.position + new Vector3(5f, 0, 5f) * Time.deltaTime;
    }
}
