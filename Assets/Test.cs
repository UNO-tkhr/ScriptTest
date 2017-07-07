using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//arrayを初期化
		int[] array = {1,2,4,8,16};

		//arrayの各要素の値を順番に表示
		for(int i = 0; i < array.Length; i++){
			Debug.Log(array[i]);
		}

		//arrayの各要素の値を逆順に表示
		for(int i = 0; i < array.Length; i++){
			Debug.Log(array[array.Length-i-1]);
		}

		//Bossクラスの魔法攻撃を10回使う
		Boss boss = new Boss();
		for(int i = 0; i < 10; i++){
			boss.Magic();
		}
		//11回目の魔法攻撃でmpが足りないメッセージが表示されることを確認
		Debug.Log("11回目の魔法攻撃");
		boss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
