//using UnityEngine;

public class Ship 
{
    #region 欄位、屬性
    //欄位
    public decimal knot;  //船的速度海浬／小時≡節來定義

    //屬性
    public decimal length { get; set; }
    //唯讀屬性
    //public float width { get; }

    //唯寫屬性，但自動實作的屬性必須有get存取子
    //public string password { set; }

    //封裝欄位
    private decimal _width = 4.3M;
    public decimal width { get { return _width; } set { _width = value; } }

    private decimal _height = 3.4M;
    public decimal height { get => _height; set => _height = value; }       //使用λ運算子

    private decimal _volume = 450.296M;
    public decimal volume
    {
        get
        {
            _volume = length * width * height;
            return _volume;
        }
    }
    #endregion

    /// <summary>
    /// 類別Ship建構子
    /// </summary>
    /// <param name="length">船艦長度</param>
    /// <param name="width">船艦寬度</param>
    /// <param name="height">船艦高度</param>
    public Ship(decimal length, decimal width, decimal height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public Ship()
    {
        this.length = 30.8M;
        this.width = 4.3M;
        this.height = 3.4M;
    }
}
