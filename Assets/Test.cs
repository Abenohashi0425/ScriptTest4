﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 50;
        points[1] = 100;
        points[2] = 200;
        points[3] = 300;
        points[4] = 400;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        //Debug.Log(points[4]);
        //Debug.Log(points[3]);
        //Debug.Log(points[2]);
        //Debug.Log(points[1]);
        //Debug.Log(points[0]);

        // 逆を表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}