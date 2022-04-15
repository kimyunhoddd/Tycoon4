using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coffee : MonoBehaviour
{
    public GameObject coffeeMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))       // ���콺 Ŭ����
        {
            // ���콺�� Ŭ���� ��ǥ���� ������
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // �ش� ��ǥ�� �ִ� ������Ʈ�� ã��
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            //�±װ� "computer"�� ������Ʈ Ŭ����
            if (hit.transform.gameObject.tag == "coffee")
            {
                // null ���� �ƴ϶��
                if (hit.collider != null)
                {
                    // �޴� â�� ���ų� Ŵ
                    //if (MenuSet.activeSelf)
                    //    MenuSet.SetActive(false);
                    //else
                    //    MenuSet.SetActive(true);
                    coffeeMenu.SetActive(true);

                }
            }
        }
    }
}
