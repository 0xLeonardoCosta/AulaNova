using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float _move, _speed;
    public string _tagCheckPoint;
    Rigidbody _rb;
    GameManager _gameManager;
    Vector3 _posSave;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _gameManager = Camera.main.GetComponent<GameManager>();
        _posSave.x = PlayerPrefs.GetFloat("PosX");
        _posSave.y = PlayerPrefs.GetFloat("PosY");
        _posSave.z = PlayerPrefs.GetFloat("PosZ");

        if (_posSave != Vector3.zero)
        {
            transform.position = _posSave;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _move = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_move * _speed, _rb.velocity.y);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_tagCheckPoint))
        {
            Debug.Log("Posição CheckPoint"+other.transform.position);
            _gameManager.CheckPointSalvar(other.transform.position);
        }
    }
}
