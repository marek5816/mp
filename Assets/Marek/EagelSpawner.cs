using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagelspawn : MonoBehaviour
{
    public GameObject eagleNormalPrefab;
    public GameObject eagleElitePrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEagleEveryTwoSeconds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEagleEveryTwoSeconds()
    {
        // Infinite loop to keep spawning eagles
        while (true)
        {
            // Call your spawn method here
            // Example: Spawning a normal eagle at a random position
            Vector3 randomPosition = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
            SpawnEagle(randomPosition, "normal"); // Change "normal" to "elite" for elite eagles
            
            // Wait for 2 seconds before spawning the next eagle
            yield return new WaitForSeconds(2f);
        }
    }

    public void SpawnEagle(Vector3 position, string eagleType)
    {
        GameObject eaglePrefab = eagleType == "elite" ? eagleElitePrefab : eagleNormalPrefab;

        if (eaglePrefab != null)
        {
            Instantiate(eaglePrefab, position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Eagle prefab is not assigned.");
        }
    }
}
