using UnityEngine;

public class NPC_Talk : MonoBehaviour
{
    [System.Serializable]
    public class DialougeData
    {

        //�̸� -���ڿ�

        public Sprite Portrait;
        public string NPCname;
        [TextArea]
        public string[] Text;
        public int TextIndex;

    }
    public DialougeData dialougeData;
    public bool IsTalkLoop;
    public int CurrentTextIndex() => dialougeData.TextIndex;
    public void IncreaseTextIndex()
    {
        dialougeData.TextIndex = dialougeData.TextIndex + 1;

        if (dialougeData.TextIndex == dialougeData.Text.Length)
        {
            if (IsTalkLoop)
            {
                dialougeData.TextIndex = 0; //������ ��縦 ��� �ݺ��϶�
            }

            else
            {
                dialougeData.TextIndex = dialougeData.Text.Length - 1; //������ ��縦 ��� �ݺ��ض�
            }
        }
    }
}

