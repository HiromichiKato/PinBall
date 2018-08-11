﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;
    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    GameObject pointcontroller;

	// Use this for initialization
	void Start () {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointcontroller = GameObject.Find("PointController");
	}

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "LargeStarTag") {
            this.pointcontroller.GetComponent<PointController>().TouchLargeStar();
        } else if (other.gameObject.tag == "LargeCloudTag") {
            this.pointcontroller.GetComponent<PointController>().TouchLargeCloud();
        } else if (other.gameObject.tag == "SmallStarTag") {
            this.pointcontroller.GetComponent<PointController>().TouchSmallStar();
        } else if (other.gameObject.tag == "SmallCloudTag") {
            this.pointcontroller.GetComponent<PointController>().TouchSmallCloud();
        }
    }

    // Update is called once per frame
    void Update () {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ) {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
	}
}
