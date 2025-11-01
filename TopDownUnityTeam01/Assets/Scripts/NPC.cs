using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    NPC_Talk npcTalk;
    //NPC_Move
    //NPC_Battle

    private void Awake()
    {
        npcTalk = GetComponent<NPC_Talk>();
    }
}

