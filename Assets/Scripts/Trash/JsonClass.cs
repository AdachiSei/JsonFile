using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JsonData;
/// <summary>
/// jsonUtility使用クラス
/// </summary>
public class JsonClass : MonoBehaviour
{
    [SerializeField]
    int _hp = 1;

    [SerializeField]
    int _attack = 3;

    [SerializeField]
    string _name = "hello";

    void Start()
    {
        JsonDataClass jsonDataClass;

        string jsonString = "{\"HP\":12,\"ATK\":6,\"name\":\"asdf\"}";
        jsonDataClass = JsonUtility.FromJson<JsonDataClass>(jsonString);

        Debug.Log(jsonDataClass.Attack);
        Debug.Log(jsonDataClass.Name);
        Debug.Log(jsonDataClass.HP);
    }
}
