using UnityEngine;

public class BonusAppearance : MonoBehaviour
{
    private int bonusCount = 2;
    public GameObject[] bonuses;
    public float bonusChance = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Random.value < bonusChance) {
            int bonusID = Random.Range(0, bonusCount);
            GameObject bonus = Instantiate(bonuses[bonusID], transform);
            bonus.transform.localPosition = new Vector3(0f, 1.5f, 0f);
            bonus.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
