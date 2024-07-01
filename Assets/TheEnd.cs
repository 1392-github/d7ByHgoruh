using UnityEngine;

public class TheEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.DateTime end = GameObject.Find("EndDatePass").GetComponent<EndDatePass>().endDate;
        System.TimeSpan end2 = end - new System.DateTime(2024, 3, 4);
        Destroy(GameObject.Find("EndDatePass"));
        GetComponent<UnityEngine.UI.Text>().text = $@"���ϰ��ϴ�! ����� �� ������ Ŭ���� �߽��ϴ�
{end:yyyy�� M�� d�� H�� m�� s��}
({end2.Days}�� {end2.Hours}�ð� {end2.Minutes}�� {end2.Seconds}�� �Ҹ�)
[Enter]�� ���� ȭ������ �̵�
(�ð��� ���� �ð��Դϴ�)";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SelectSaveScene");
        }
    }
}
