using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int _fase, _partFase, _life;
    [SerializeField] Transform _posPlayer;
    [SerializeField] Transform[] _pos;

    void Start()
    {
        Carregar();
        _posPlayer.localPosition = _pos[_partFase].transform.position;
    }

    public void AumentarFase()
    {
        _fase++;
    }
    public void CheckPointSalvar(Vector3 pos)
    {
        PlayerPrefs.SetFloat("PosX", pos.x);
        PlayerPrefs.SetFloat("PosY", pos.y);
        PlayerPrefs.SetFloat("PosZ", pos.z);
    }
    public void Salvar()
    {
        PlayerPrefs.SetInt("Fase", _fase);
    }
    public void Carregar()
    {
        _fase = PlayerPrefs.GetInt("Fase", _fase);
    }
    public void DeletarSave()
    {
        PlayerPrefs.DeleteAll();
    }
}