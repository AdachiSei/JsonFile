using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    PlayerData _player1;
    PlayerData _player2;


    string _jsondata;

    void Start()
    {
        _player1 = new PlayerData();
        _player2 = new PlayerData();
        _player1.ChangeName("タカシ");
        _player1.ChangeHP(300);
        _player1.ChangeAttack(15);
        _player1.ChangeDefense(2);

        //_player1._name = "タカシ";
        //_player1._hp = 300;
        //_player1._attack = 15;
        //_player1._defense = 3;

        _jsondata = JsonUtility.ToJson(_player1); //JSONデータはC#上で文字列として扱う

        Debug.Log(_jsondata);

        _player2 = JsonUtility.FromJson<PlayerData>(_jsondata);

        Debug.Log("名前:" + _player2._name + " HP:" + _player2._hp + " Attack:" + _player2._attack + " Defense:" + _player2._defense);
    }
    


    [System.Serializable]
    public class PlayerData
    {
        public string Name => _name;
        public int HP => _hp;
        public int Attack => _attack;
        public int Defense => _defense;

        //なぜpublicじゃないと動かない?
        public string _name;
        public int _hp;
        public int _attack = 5;
        public int _defense;

        public string ChangeName(string name) => _name = name;
        public int ChangeHP(int hp) => _hp = hp;
        public int ChangeAttack(int attack) => _attack = attack;
        public int ChangeDefense(int defense) => _defense = defense;
    }
}
