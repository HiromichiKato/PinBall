using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour {

    GameObject pointText;
    int point = 0;

    public void TouchLargeStar() {
        this.point += 20;
    }

    public void TouchLargeCloud() {
        this.point += 20;
    }

    public void TouchSmallStar() {
        this.point += 10;
    }

    public void TouchSmallCloud() {
        this.point += 10;
    }


	// Use this for initialization
	void Start () {
        this.pointText = GameObject.Find("PointText");
	}
	
	// Update is called once per frame
	void Update () {
        this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";
	}
}