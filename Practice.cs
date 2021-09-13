using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    struct Animal
    {
        public string name;
        public string type;
        public int weight;
        public string roar;
    }
    // Start is called before the first frame update
    void Start()
    {
        Animal[] animal = new Animal[4];

        animal[0].name = "港港捞";
        animal[0].type = "俺";
        animal[0].weight = 30;
        animal[0].roar = "港港!";

        animal[1].name = "成成捞";
        animal[1].type = "绊剧捞";
        animal[1].weight = 20;
        animal[1].roar = "成成!";

        animal[2].name = "喊捞";
        animal[2].type = "俺";
        animal[2].weight = 10;
        animal[2].roar = "港港!";

        animal[3].name = "唱厚";
        animal[3].type = "绊剧捞";
        animal[3].weight = 50;
        animal[3].roar = "成成!";

        for (int i = 0; i < 4; i++)
        {
            Debug.Log(animal[i].roar);
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
