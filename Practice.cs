using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //nested class 즉, 안에 클래스를 정의하면 value로만 메소드를 불러올 수 있으므로
        //지양하는 것이 좋다
        Animal[] animal = new Animal[4];

        animal[0].name = "멍멍이";
        animal[0].type = "개";
        animal[0].weight = 30;
        animal[0].roar = "멍멍!";

        animal[1].name = "냥냥이";
        animal[1].type = "고양이";
        animal[1].weight = 20;
        animal[1].roar = "냥냥!";

        animal[2].name = "별이";
        animal[2].type = "개";
        animal[2].weight = 10;
        animal[2].roar = "멍멍!";

        animal[3].name = "나비";
        animal[3].type = "고양이";
        animal[3].weight = 50;
        animal[3].roar = "냥냥!";

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

public class Animal
{
    public string name;
    public string type;
    public int weight;
    public string roar;
}
