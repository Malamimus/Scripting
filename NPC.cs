using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    
    public int speed = 1;
    public int level = 1;
    public float health = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Здоровье: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        //Создаём переменную вида Vector3 и сохраняем в неё позицию NPC
        Vector3 newPosition = transform.position;
        //Меняем позицию NPC по оси z согласно скорости NPC и времени между кадрами
        newPosition.z += speed * Time.deltaTime;
        //Меняем позицию NPC на новое значение, рассчитанное выше
        transform.position = newPosition;
    }
}
