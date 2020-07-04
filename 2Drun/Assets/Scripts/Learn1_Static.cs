﻿using UnityEngine;

public class Learn1_Static : MonoBehaviour
{
    private void Start()
    {
        //靜態成員用法
        //靜態屬性 property = 欄位 Field (儲存資料)
        //語法:類別名稱.靜態屬性名稱
        print(Mathf.PI);
        print(Mathf.Infinity);

        print(Random.value);  //0-1的隨機值

        //靜態方法 Method
        //語法:類別名稱.靜態方法名稱(對應參數)
        print(Mathf.Abs(-999));

        // 取得100-500隨機值
        print(Random.Range(100, 501));
    }

    private void Update()
    {
        print(Time.time);
    }

}


