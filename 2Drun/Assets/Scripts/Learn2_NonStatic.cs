using UnityEngine;

public class Learn2_NonStatic : MonoBehaviour
{

    //儲存場景上物件或元件
    public GameObject ninja;

    public Transform ninjaTran;

    public Camera cam;

    public ParticleSystem ps;

    //靜態與非靜態差異
    //非靜態需要有物件或元件

    // 存取
    // 非靜態成員

    private void Start()
    {
        //取得
        print(ninja.tag);
        print(ninja.layer);

        //存放
        ninjaTran.position = new Vector3(0, 7, 0);
        //ninjaTran.position = new Vector3(6, 6, 6);
    }

    private void Update()
    {
        //非靜態方法
        //ninjaTran.Rotate(0, 0, 60);
        ninjaTran.Translate(0.1f, 0, 0);
    }

}




