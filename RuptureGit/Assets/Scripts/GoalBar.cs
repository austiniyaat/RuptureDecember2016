using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoalBar : MonoBehaviour {

	public Image fundsBar;
	public float goal = 1000000;

	float funds;
	float percentageOfGoal;
	PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController>();
		fundsBar.fillAmount = 0;
		funds = (float)player.startingFunds;
	}

	// Update is called once per frame
	void Update () {

		funds = (float)player.currentFunds;
		percentageOfGoal = funds / goal;

		fundsBar.fillAmount = percentageOfGoal;
	}
}
