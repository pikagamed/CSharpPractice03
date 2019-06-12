using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public decimal A = 10, B = 3, C = 7, D = 99, E = 5;

    public bool BoolA = true;
    public bool BoolB = true;
    public bool BoolC = false;

    public int ScoreA = 70, ScoreB = 90;

    void Start()
    {
        #region 練習數學運算子
        // 加減乘除餘 + - * / %   

        Debug.Log("A+B=" + (A + B));
        Debug.Log("A-B=" + (A - B));
        Debug.Log("A×B=" + (A * B));
        Debug.Log("A÷B=" + (A / B));
        Debug.Log("AmodB=" + (A % B));

        Debug.Log(C++);
        Debug.Log(C);
        Debug.Log(++C);
        Debug.Log(--D);

        //複合指派
        Debug.Log(E+=7);
        #endregion

        #region 邏輯運算子

        //否定  !
        Debug.Log("BoolA=" + BoolA);
        Debug.Log("!BoolA=" + !BoolA);

        //AND & 
        Debug.Log("BoolB & BoolC=" + (BoolB & BoolC));  //作為運算元的兩布林值均為true時，結果為true；否則結果為false

        //OR | 
        Debug.Log("BoolB | BoolC=" + (BoolB | BoolC));  //作為運算元的兩布林值其中之一為true時，結果為true；否則結果為false

        //XOR ^ 
        Debug.Log("BoolB ^ BoolC=" + (BoolB ^ BoolC));  //作為運算元的兩布林值不同時，結果為true；否則結果為false

        //條件邏輯運算子 && ||
        Debug.Log("BoolB && BoolC=" + (BoolB && BoolC)); //只要第一個檢查出是false，後續的就不再檢查，直接回傳false；否則回傳true
        Debug.Log("BoolB || BoolC=" + (BoolB || BoolC));    //只要檢查出一個true，後續的就不再檢查，直接回傳true；否則回傳false

        #endregion

        #region 比較運算子 - 傳回布林值

        //相等 ==
        Debug.Log("ScoreA == ScoreB 結果為" + (ScoreA == ScoreB)); 

        //不相等 !=
        Debug.Log("ScoreA != ScoreB 結果為" + (ScoreA != ScoreB));

        //小於 < 、 大於> 、 小於等於 <= 、 大於等於 >=

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
