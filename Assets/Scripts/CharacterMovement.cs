using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{


    [SerializeField] string _Aliança;
    [SerializeField] string _Sidekick1;
    [SerializeField] string _Sidekick2;
    [SerializeField] Rigidbody2D _rig;
    [SerializeField] Vector2 _move;
   
    [SerializeField] float _speed = 10f;


    // Start is called before the first frame update
    void Start()
    {


        _Aliança = "Decepticon";
        _Sidekick1 = "Ravage";
        _Sidekick2 = "Laserbeak";


    }

    // Update is called once per frame
    void Update()
    {



        _move.x = Input.GetAxisRaw("Horizontal");



        _rig.velocity = new Vector2 (_move.x * _speed, 0);







    }
}
