using UnityEngine;



public class MosquitoVerdeController : MonoBehaviour
{
    [SerializeField] public float _movespeedMosquito;
    private Rigidbody2D _rigidbody2DMosquito;
    public Vector2 _mosquitoDirection;

    public DetectionController _detectionControllerArea;
    private SpriteRenderer _spriteRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2DMosquito = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        _mosquitoDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if (_detectionControllerArea.detectedObjs.Count > 0)
        {
            _mosquitoDirection = (_detectionControllerArea.detectedObjs[0].transform.position - transform.position).normalized;
            _rigidbody2DMosquito.MovePosition(_rigidbody2DMosquito.position +  _mosquitoDirection * _movespeedMosquito *Time.fixedDeltaTime);

            if(_mosquitoDirection.x > 0)
            {
                _spriteRenderer.flipX = true;
            }else if (_mosquitoDirection.x < 0)
            {
                _spriteRenderer.flipX = false;
            }
        }

    }
}
