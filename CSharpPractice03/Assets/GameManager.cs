using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ship ship01 = new Ship();  //實作一個Ship物件，命名為ship
    public Ship ship02 = new Ship( 27.5M, 5.2M, 4.8M);  //實作一個Ship物件，命名為ship

    // Start is called before the first frame update
    void Start()
    {
        ship01.knot = 10.5M;                                          //寫入欄位
        Debug.Log("船艦01的速度：" + ship01.knot);        //讀取欄位

        ship01.length = 30.8M;                                        //寫入屬性
        Debug.Log("船艦01的長度：" + ship01.length);      //讀取屬性

        //ship.width = 4.3f;                                        //唯讀屬性不可寫
        Debug.Log("船艦01的寬度：" + ship01.width);      //讀取唯讀屬性

        Debug.Log("船艦01的高度：" + ship01.height);
        Debug.Log("船艦01的體積：" + ship01.volume);


        Debug.Log("船艦02的速度：" + ship02.knot);  
        Debug.Log("船艦02的長度：" + ship02.length); 
        Debug.Log("船艦02的寬度：" + ship02.width);  
        Debug.Log("船艦02的高度：" + ship02.height);
        Debug.Log("船艦02的體積：" + ship02.volume);
    }
}
