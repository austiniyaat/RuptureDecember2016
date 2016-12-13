using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class DisplayConstructionCosts : MonoBehaviour {

	public GameObject officeCost;
	public GameObject hireCost;
	public GameObject networkCost;
	public GameObject cursoryCost;
	public GameObject thoroughCost;
	public Text constructionCost;

	Transform target;

	int officeCount;
	int hireCount;
	int networkCount;

	PlayerController player;
	public float t;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController>();
		officeCount = player.allOffices.Count + 1;
		hireCount = player.allNodes.Count;
		networkCount = player.allNetworkTies.Count;

		t = 0;
	}

	// Update is called once per frame
	void Update () {
		
		//keep track of and update offices
		if (player.allOffices.Count == officeCount + 1 && !officeCost.activeSelf) {
			int targetOffice = player.allOffices.Count - 1;
			target = player.allOffices [targetOffice].transform;

			officeCost.transform.position = SetPositionOfCostDisplay (target);

			officeCost.SetActive (true); 
			t = Time.time + 1f;
			constructionCost.text = "-" + player.officeCost.ToString();
		}

		if (officeCost.activeSelf && Time.time > t) {
			officeCost.SetActive (false);
			officeCount = player.allOffices.Count;
		}


		//keep track of and update nodes
		if (player.allNodes.Count == hireCount + 1 && !hireCost.activeSelf) {

			int targetNode = player.allNodes.Count - 1;
			target = player.allNodes [targetNode].transform;

			hireCost.transform.position = SetPositionOfCostDisplay (target);

			hireCost.SetActive (true); 
			t = Time.time + 0.3f;
			constructionCost.text = "-" + player.hireCost.ToString();
			hireCount = player.allNodes.Count;
		}

		if (officeCost.activeSelf && Time.time > t) {
			hireCost.SetActive (false);
		}


		//keep track of and update networks
		if (player.allNetworkTies.Count == networkCount + 1 && !networkCost.activeSelf) {

			int targetNetworkTie = player.allNetworkTies.Count - 1;
			target = player.allNetworkTies [targetNetworkTie].transform;

			networkCost.transform.position = SetPositionOfCostDisplay (target);

			networkCost.SetActive (true);
			t = Time.time + 0.5f;
			constructionCost.text = "-" + player.networkCost.ToString ();
			networkCount = player.allNetworkTies.Count;
		}

		if (networkCost.activeSelf && Time.time > t) {
			networkCost.SetActive (false);
		}
	
	}

	void DisplayCursoryCost(){
		
	}

	Vector3 SetPositionOfCostDisplay(Transform target){
		Vector3 screenPos = Camera.main.WorldToScreenPoint (target.position);
		Vector3 temp = screenPos;

		if (screenPos.x < 800) {
			temp.x += 50f;
		} else if (screenPos.x > 800) {
			temp.x -= 50;
		}

		if (screenPos.y < 120) {
			temp.y += 50f;
		} else if (screenPos.y > 300) {
			temp.y -= 50f;
		}
		return temp;
	}
		
}
