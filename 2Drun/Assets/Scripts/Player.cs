using UnityEngine;

public class Player : MonoBehaviour
{
    // 單行註解 2020.07.04 hank
    // 說明:

    /*
     * 多行註解
     * 多行註解
     * 多行註解
     * */

    #region 欄位區域
    /*說明區域
    // 命名規則
    // 1.用有意義的名稱
    // 2.不要使用數字開頭
    // 3.不要使用特殊符號包含:@#$/* 空格
    // 4.可以使用中文

    //欄位語法
    //修飾詞 類型 欄位名稱 = 值;
    //沒有 = 值
    //整數 浮點數 預設值為0
    //字串預設值為 ""
    //布林值預設值為 false

    //私人 private - 僅限與此類別使用｜不會顯示 - 為預設值
    //私人 public - 所有類別皆可使用｜會顯示

    //欄位屬性 [屬性名稱()]
    //標題 Header
    //提示 Tooltip
    //範圍 Range
    */


    [Header("速度"), Tooltip("角色的移動速度"), Range(10, 1500)]
    public int speed = 50;
    [Header("血量"), Tooltip("角色的血量"), Range(0, 1000)]
    public float hp = 999.9f;
    [Header("金幣數量"), Tooltip("儲存角色吃了的金幣")]
    public int coin;
    [Header("跳躍高度"), Range(100, 3000)]
    public int height = 500;
    [Header("音效區域")]
    public AudioClip soundJump;
    public AudioClip soundslide;
    public AudioClip soundHit;
    [Header("角色是否死亡"), Tooltip("True 代表死亡，False 代表尚未死亡")]
    public bool dead;


    #endregion



    #region 方法區域
    // C# 括號符號都是成對出現的:() [] {} "" ''
    //摘要:方法的說明
    //在方法上添加三條/
    //自訂方法、不會執行的，需要呼叫
    //API-功能倉庫
    //輸出功能 print("字串")

    /// <summary>
    /// 角色的跳躍功能:跳躍動畫，播放音效與往上跳
    /// </summary>

    private void Jump()
    {
        print("跳躍");
    }

    /// <summary>
    /// 角色的滑行功能:滑行動畫、播放音效、縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        print("滑行");
    }

    /// <summary>
    /// 碰到隱藏物時受傷:扣血
    /// </summary>
    private void Hit()
    {
        print("碰撞");
    }

    /// <summary>
    /// 吃金幣:金幣數量增加、更新介面、金幣音效
    /// </summary>
    private void EatCoin()
    {
        print("吃金幣");
    }

    /// <summary>
    /// 死亡:動畫、遊戲結束
    /// </summary>
    private void Dead()
    {

    }
    #endregion


    #region 事件區域
    // 開始 start
    // 播放遊戲時執行一次
    private void Start()
    {
        //呼叫跳躍方法
        Jump();
    }
    // 更新 update
    //播放遊戲後直行約60次 - 60fps
    //移動、監聽玩家鍵盤、滑鼠與觸控
    private void Update()
    {
        Slide();
    }
    #endregion
}

