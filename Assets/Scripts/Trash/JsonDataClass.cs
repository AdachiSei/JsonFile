using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �f�[�^�i�[�N���X
/// </summary>
namespace JsonData
{
    public class JsonDataClass : MonoBehaviour
    {
        public int HP => _hp;
        public int Attack => _attack;
        public string Name => _name;

        int _hp;
        int _attack;
        string _name;
    }
}
