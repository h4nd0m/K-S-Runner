using UnityEngine;
public class MapGenerator : MonoBehaviour
{
    public Transform spawnPos; public GameObject loc1;
    public GameObject loc2; private float score = 0f;
    private float mapGen = 0f; private Vector2 spawn;
    private float x; private float y;

    void Start()
    {
        x = spawnPos.transform.position.x + 94f;
        y = spawnPos.transform.position.y; spawn = new Vector2(x, y);
    }
    void Update()
    {
        score += Time.deltaTime;
        if (score > mapGen)
        {
            int randomNum = Random.Range(0, 2); Debug.Log(randomNum);
            if (randomNum == 0)
            {
                Instantiate(loc1, spawn, Quaternion.identity); mapGen += 13f;
                x += 94f; spawn = new Vector2(x, y);
            }
            else
            {
                spawn = new Vector2(x - 3f, y + 21f);
                Instantiate(loc2, spawn, Quaternion.identity); mapGen += 13f;
                x += 94f; spawn = new Vector2(x, y);
            }
        }
    }
}
