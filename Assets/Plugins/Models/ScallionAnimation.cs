using UnityEngine;

public class ShowscallionsElementsOnAppear : MonoBehaviour
{
    public GameObject scallions;
    public GameObject followTextscallions;

    private void OnBecameVisible()
    {
        // 当 ChopTomatoesElement 可见时执行的逻辑
        if (scallions != null)
        {
            // 将 tomatoanim1 设为可见
            scallions.SetActive(true);
        }

        if (followTextscallions != null)
        {
            // 将 followText 设为可见
            followTextscallions.SetActive(true);
        }
    }
}

