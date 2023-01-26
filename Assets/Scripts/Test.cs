using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;

    [SerializeField]    // 인스펙트창에 띄우기 위함 
    private GameObject go_camera;
    private void Start()
    {
        rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        // 공전
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
        //transform.RotateAround(태양, 축, 얼마만큼)



        if (Input.GetKey(KeyCode.W))
        {
            // 이동
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;  // 60프레임 정도이므로 대략 1/60   1초에 1식 이동 
            /* 1
            this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); // 위와 같다
            */



            // 정규화 벡터
            //int moveSpeed = 1;
            //moveSpeed * this.transform.forward * Time.deltaTime; // forward 정규화 벡터 (방향만을 알려주는 녀석) forward ==> new Vector3(0, 0, 1) , 스피드 만금 이동//
            //this.transform.right
            //this.transform.up

            // 특정대상을 바라보기
            //this.transform.LookAt(go_camera.transform.position);    // LookAt 특정대상을 바라본다

        }

        if (Input.GetKey(KeyCode.A))
        {
            // 회전
            /*
            this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            Debug.Log(transform.eulerAngles);  // 90도 이상일경우 떨림현상으로 에러발생
            */
            /*  1.            
            rotation += new Vector3(90, 0, 0) * Time.deltaTime; 
            this.transform.eulerAngles = rotation;  
            Debug.Log(transform.eulerAngles);   
            */
            /*  2.
            this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
            */
            /*  3.
            this.transform.rotation = new Quaternion(0.3f, 0.4f, 0, 0); // 이렇게도 사용가능하나 유니티에서 사용하지마라고 권장함
            */
            /*  4.
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);  // Quaternion 사용시 Euler 매서드이용
                                                                   // Quaternion 사용이유 euler를 사용시 한축을 고정시킨후 rotation했을떄 나머지 두축이 같은 방향으로 회전하는 에러 발생 ==> 짐볼락 현상
                                                                   //       짐볼락 현상을 방지하기위해 Quaternion을 사용한다
            */        
         }

        // 크기조절
        /*
        if (Input.GetKey(KeyCode.F1))
        {
            this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        }
        */
    }
}
