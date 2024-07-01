using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text text;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //  text.text = $"����ǥ (����/�ְ�)\n���� {player.grade[0]}/{player.bestGrade[0]}\n���� {player.grade[1]}/{player.bestGrade[1]}\n��ȸ {player.grade[2]}/{player.bestGrade[2]}\n���� {player.grade[3]}/{player.bestGrade[3]}\n���� {player.grade[4]}/{player.bestGrade[4]}\n��� {player.GetAverageGrade()}/{player.bestAverageGrade}";
        if (player.scores.Count == 0)
        {
            text.text = "����ǥ ����";
        }
        else
        {
            TestScore score = player.scores[player.sbindex];
            text.text = $"{score.date}\n����  ����  ��ȸ  ����  ����\n   { score.grade[0]}     {score.grade[1]}     {score.grade[2]}     {score.grade[3]}     {score.grade[4]}\n{score.rank[0],4}{score.rank[1],6}{score.rank[2],6}{score.rank[3],6}{score.rank[4],6}\n��� {score.grade.Average()}";
        }
    }
}
