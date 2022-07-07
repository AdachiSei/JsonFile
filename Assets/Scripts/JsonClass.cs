using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonClass : MonoBehaviour
{
	public int HP = 1;
	public int ATK = 3;
	public string name = "hello";

	void Start()
	{
		Debug.Log(JsonUtility.ToJson(this));
	}

	void Update()
	{

	}
}
