using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;

    private float _timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        var SpawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange),
            Random.Range(-_heightRange, _heightRange));
        var pipe = Instantiate(_pipe, SpawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}