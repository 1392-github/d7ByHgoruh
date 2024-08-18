using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    Player player;
    Text text;
    string TimeSpanToString(TimeSpan t) => $"{t.Days}�� {t.Hours}�ð� {t.Minutes}�� {t.Seconds}��";
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $@"���� �ð� : {player.startTime:yyyy�� M�� d�� H�� m�� s��}
��ü �÷��� Ÿ�� : {TimeSpanToString(DateTime.Now - player.startTime)}
���� �÷��� Ÿ�� : {TimeSpanToString(player.totalPlayTime)}
��� �ɷ�ġ �� : {player.studyExp.Sum()}";
    }
}
