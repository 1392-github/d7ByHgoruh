using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPBlock : MonoBehaviour
{
    Player player;
    GameObject ok;
    GameObject err;
    Tab tab;
    Text errText;
    public void Run()
    {
        if (player == null)
        {
            player = GameObject.Find("Player").GetComponent<Player>();
            ok = transform.Find("GetClass").gameObject;
            err = transform.Find("GetClassError").gameObject;
            errText = err.GetComponent<Text>();
            tab = GetComponent<Tab>();
        }
        ok.SetActive(!player.duringClassPlacement);
        err.SetActive(player.duringClassPlacement);
        errText.text = $"������ �� ������ ��ȸ�� �� �����ϴ�\n{player.endClassPlacement.ToString("yyyy-MM-dd")} ���� 8�ú��� ��ȸ �����մϴ�";
        tab.tabs[0] = player.duringClassPlacement ? err : ok;
    }
}
