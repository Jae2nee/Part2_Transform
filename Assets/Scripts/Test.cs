using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;

    [SerializeField]    // �ν���Ʈâ�� ���� ���� 
    private GameObject go_camera;
    private void Start()
    {
        rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        // ����
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
        //transform.RotateAround(�¾�, ��, �󸶸�ŭ)



        if (Input.GetKey(KeyCode.W))
        {
            // �̵�
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;  // 60������ �����̹Ƿ� �뷫 1/60   1�ʿ� 1�� �̵� 
            /* 1
            this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); // ���� ����
            */



            // ����ȭ ����
            //int moveSpeed = 1;
            //moveSpeed * this.transform.forward * Time.deltaTime; // forward ����ȭ ���� (���⸸�� �˷��ִ� �༮) forward ==> new Vector3(0, 0, 1) , ���ǵ� ���� �̵�//
            //this.transform.right
            //this.transform.up

            // Ư������� �ٶ󺸱�
            //this.transform.LookAt(go_camera.transform.position);    // LookAt Ư������� �ٶ󺻴�

        }

        if (Input.GetKey(KeyCode.A))
        {
            // ȸ��
            /*
            this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            Debug.Log(transform.eulerAngles);  // 90�� �̻��ϰ�� ������������ �����߻�
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
            this.transform.rotation = new Quaternion(0.3f, 0.4f, 0, 0); // �̷��Ե� ��밡���ϳ� ����Ƽ���� ������������ ������
            */
            /*  4.
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);  // Quaternion ���� Euler �ż����̿�
                                                                   // Quaternion ������� euler�� ���� ������ ������Ų�� rotation������ ������ ������ ���� �������� ȸ���ϴ� ���� �߻� ==> ������ ����
                                                                   //       ������ ������ �����ϱ����� Quaternion�� ����Ѵ�
            */        
         }

        // ũ������
        /*
        if (Input.GetKey(KeyCode.F1))
        {
            this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        }
        */
    }
}
