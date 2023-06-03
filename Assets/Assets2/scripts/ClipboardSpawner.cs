using UnityEngine;

public class ClipboardSpawner : MonoBehaviour
{
    public static int Count;
    public static int points = 0;
    [SerializeField] private GameObject clipboard;
    [SerializeField] private Transform clipboardParent;

    [SerializeField] private float spawnRadius;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        Count = 0;
        for (int i = 0; i < 5; i++)
        {
            Count++;
            Spawn();
        }
    }

    // Start is called before the first frame update
    void Spawn()
    {
        float r = Random.Range(0.1f, spawnRadius);
        float theta = Mathf.Deg2Rad * Random.Range(0f, 360f);

        Vector3 position = offset + new Vector3(r * Mathf.Cos(theta), 0, r * Mathf.Sin(theta));

        GameObject spawned = Instantiate(clipboard, position, Quaternion.identity, clipboardParent);
        //spawned.
        spawned.gameObject.tag = "Clipboard";
        spawned.gameObject.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Count == 0)
        {
            Start();
        }
    }
}
