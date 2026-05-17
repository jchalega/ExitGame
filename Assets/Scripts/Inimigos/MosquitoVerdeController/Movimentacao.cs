using UnityEngine;

public class MosquitoAnimationController : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;

    public MosquitoVerdeController controller;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // velocidade do mosquito
        _animator.SetBool("isRunning", true);

       
    }
}