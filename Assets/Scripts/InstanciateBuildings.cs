using UnityEngine;
using System.Collections;

public class InstanciateBuildings : MonoBehaviour
{
	public GameObject m_gameObject;
    public GameObject[] m_gameObjects;
	public float m_minScaleX,m_maxScaleX,m_minScaleZ,m_maxScaleZ;
	// Use this for initialization
	void Start () {
	    foreach (GameObject building in m_gameObjects)
	    {		
			var rndScaleX = Random.Range(m_minScaleX,m_maxScaleX);
			var rndScaleZ = Random.Range(m_minScaleZ,m_maxScaleZ);			
			building.transform.localScale = new Vector3(rndScaleX,1,rndScaleZ);			
			//Instantiate(building);
			Debug.Log("Create Building");
	    }
	}
	
	// Update is called once per frame
	void Update () {	
	}
}
