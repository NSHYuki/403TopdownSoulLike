using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSkillData : ScriptableObject
{
    //������Ҫ��ʾ��UI�ϵ�����
    
    [Tooltip("���ȼ�")] public int maxSkillLevel;
    [Tooltip("�����ܵ�")] public int skillPointCost;//�����ܵ�
    [Tooltip("�ڵ���ͼ")] public Sprite skillSpite;
    [Tooltip("�츳����")]  public string skillName;

    //�ڲ�����
    [Tooltip("ID")] public int skillTreeID;//�ڵ�ID
    [Tooltip("�츳����")] public SkillType skillType;//�ڵ��츳����
    [Tooltip("��ֵ����")] public ValueType skillValueType;//�ڵ���ֵ����
    [Tooltip("�ı���ֵ��С")] public float[] skillValue;//�ڵ���ֵ���ֵȼ���
    [Tooltip("��������ID")] public int skillID;//����ħ��ID


    //��������
    [TextArea(1,8)]
    public string skillDescription;//�̶�����������    
}

public class LocalSkillData
{
    public int id;
    public int currentSkillLevel;
    public bool canUnlock;
    public bool isUnlocked;
    public LocalSkillData(int id,int currentSkillLevel = 0,bool canUnlock = false,bool isUnlocked = false)
    {
        this.currentSkillLevel = currentSkillLevel;
        this.id = id;
        this.canUnlock = canUnlock;
        this.isUnlocked = isUnlocked;
    }

}
public enum SkillType
{
    Value,Unlock
}
public enum ValueType
{
    MaxHealth, MaxMana, MaxEnergy,Damage,CritRate,CritDamage,ReductionRate,DamageRate
}
