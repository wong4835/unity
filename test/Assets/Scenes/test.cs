using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		int[] points = {12, 13, 42, 46};

		int sum = 0;
		for(int i = 0; i < points.Length; i++)
		{
			sum += points[i];
		}
		//Debug.Log(sum);

		double average = sum / (double)points.Length;		
		Debug.Log(average);

		/*2-24 조건을 만족하는 요소만 출력하기
	    int[] points = {83, 99, 52, 93, 15};

		for(int i = 0; i < points.Length; i++)
		{
			if(points[i] <= 90)
			{
				Debug.Log(points[i]);
			}	
		}
    
		/*2-23 배열 사용하기
		int[] array = new int[5];
		
		array[0] = 2;
		array[1] = 10;
		array[2] = 5;
		array[3] = 15;
		array[4] = 3;

		for(int i = 0; i < 5l i++)
		{
			Debug.Log(array[i);
		}
		*/
		/*2-22 합계 구하기
		int sum = 0;
		for(int i = 1; i <= 10; i++)
		{
			sum += i;
		}
		Debug.Log(sum);
		*/

		/*2-21 카운트 다운하기
		for(int i = 13; i >= 0; i--)
		{
			Debug.Log(i);
		}
		*/
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}