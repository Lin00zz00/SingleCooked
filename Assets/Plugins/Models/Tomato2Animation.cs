using UnityEngine;

public class ShowTomato2animationElementsOnAppear : MonoBehaviour
{
    public GameObject Tomato2animation;
    public GameObject followTexttomato2;

    private void OnBecameVisible()
    {
        // 当 ChopTomatoesElement 可见时执行的逻辑
        if (Tomato2animation != null)
        {
            // 将 tomatoanim1 设为可见
            Tomato2animation.SetActive(true);
        }

        if (followTexttomato2 != null)
        {
            // 将 followText 设为可见
            followTexttomato2.SetActive(true);
        }
    }
}
