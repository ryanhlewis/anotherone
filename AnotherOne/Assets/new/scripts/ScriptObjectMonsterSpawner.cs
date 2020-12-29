using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
  
 public class ScriptObjectMonsterSpawner : MonoBehaviour
 {
  
     public GameObject monster;
     public GameObject[] spawnPoints;
     //public GameObject particle;
     public List<GameObject> Children;
     public int spawnAmount = 5;
     public float spawnRate = 5.0f;
     private bool spawning;
  
     // Use this for initialization
     void Start()
     {
         Children = new List<GameObject>();
         //^ Could initialise the size of this with the max number of enemies there would be too (if this is fixed)
 
         spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
         //^ Moved this from the coroutine as you only need to find the spawn points once (and it's expensive)
 
        // particle.SetActive(false);
     }
  
     // Update is called once per frame
     void Update()
     {
  
         if (Children.Count < spawnAmount && spawning == false)
         {
             StartCoroutine(SpawnMonster());
             Debug.Log("Spawning");        
             
              }
     }
  
     public IEnumerator SpawnMonster()
     {
         spawning = true;
         //particle.SetActive(true);
         var index = Random.Range(0, spawnPoints.Length);
         var currentPoint = spawnPoints[index];
         var newmonster = Instantiate(monster, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
         //^Note that we could simplify the above since we don't use index or currentPoint for anything else, like so:
         //var newmonster = Instantiate(monster, spawnPoints[Random.Range(0, spawnPoints.Length].transform.position
         Children.Add(newmonster);
         newmonster.transform.parent = gameObject.transform;
         yield return new WaitForSeconds(spawnRate);
         //particle.SetActive(false);
         spawning = false;
     }
 }