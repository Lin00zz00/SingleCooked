using UnityEngine;

public class Showegg2animationElementsOnAppear : MonoBehaviour
{
    public GameObject egg2animation;
    public GameObject followTextegg2;

    private void OnBecameVisible()
    {
        // 当 ChopTomatoesElement 可见时执行的逻辑
        if (egg2animation != null)
        {
            // 将 tomatoanim1 设为可见
            egg2animation.SetActive(true);
        }

        if (followTextegg2 != null)
        {
            // 将 followText 设为可见
            followTextegg2.SetActive(true);
        }
    }
}
