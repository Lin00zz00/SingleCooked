using UnityEngine;

public class ShowegganimationElementsOnAppear : MonoBehaviour
{
    public GameObject egganimation;
    public GameObject followTextegg;

    private void OnBecameVisible()
    {
        // 当 ChopTomatoesElement 可见时执行的逻辑
        if (egganimation != null)
        {
            // 将 tomatoanim1 设为可见
            egganimation.SetActive(true);
        }

        if (followTextegg != null)
        {
            // 将 followText 设为可见
            followTextegg.SetActive(true);
        }
    }
}
