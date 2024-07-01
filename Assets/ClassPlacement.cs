using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ClassPlacement : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }
    public void OnSubmit(string text)
    {
        player.clas = Enumerable.Repeat(-1, 1000).ToArray();
        List<int> students = new List<int>();
        if (text != "")
        {
            foreach (string s in text.Split(' '))
            {
                if (int.TryParse(s, out int a))
                {
                    if (a <= 0 || a >= 330)
                    {
                        player.OpenDialog("1~329 ���̿��� �Է��ϼ���\n(�� : 123 ����, 456 �Ұ���)");
                        return;
                    }
                    if (students.Contains(a))
                    {
                        player.OpenDialog("���� ���ڸ� ���� �� �Է����� ������");
                        return;
                    }
                    students.Add(a);
                }
                else
                {
                    player.OpenDialog("���ڿ� ���鸸 �Է��ϼ���\n(�� : 1 2 3 ����, a b c �Ұ���)");
                    return;
                }
            }
            if (students.Count > 32)
            {
                player.OpenDialog("�ִ� 32�������� �Է��ϼ���");
                return;
            }
        }
        player.clas[0] = Random.Range(0, 10);
        foreach (int s in students)
        {
            if (Random.Range(0, 100) < player.classPlacementChance)
            {
                player.clas[s] = player.clas[0];
            }
            else
            {
                player.clas[s] = Random.Range(0, 9);
                if (player.clas[s] == player.clas[0])
                {
                    player.clas[s] = 9;
                }
            }
        }
        for (int i = 1; i < 330; i++)
        {
            if (students.Contains(i))
            {
                continue;
            }
            do
            {
                player.clas[i] = Random.Range(0, 10);
            } while (player.clas.Count(c => c == player.clas[i]) > 33);
        }
        for (int i = 330; i < 660; i++)
        {
            do
            {
                player.clas[i] = Random.Range(10, 20);
            } while (player.clas.Count(c => c == player.clas[i]) > 33);
        }
        for (int i = 660; i < 1000; i++)
        {
            do
            {
                player.clas[i] = Random.Range(20, 30);
            } while (player.clas.Count(c => c == player.clas[i]) > 34);
        }
        player.timeSpeed = new System.TimeSpan(0, 0, 30);
        transform.parent.gameObject.SetActive(false);
    }
}
