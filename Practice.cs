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

        animal[0].name = "�۸���";
        animal[0].type = "��";
        animal[0].weight = 30;
        animal[0].roar = "�۸�!";

        animal[1].name = "�ɳ���";
        animal[1].type = "�����";
        animal[1].weight = 20;
        animal[1].roar = "�ɳ�!";

        animal[2].name = "����";
        animal[2].type = "��";
        animal[2].weight = 10;
        animal[2].roar = "�۸�!";

        animal[3].name = "����";
        animal[3].type = "�����";
        animal[3].weight = 50;
        animal[3].roar = "�ɳ�!";

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
