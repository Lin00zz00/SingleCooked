using UnityEngine;

public class ShowScallions2ElementsOnAppear : MonoBehaviour
{
    public GameObject Scallions2;
    public GameObject followTextscallions2;

    private void OnBecameVisible()
    {
        // 当 ChopTomatoesElement 可见时执行的逻辑
        if (Scallions2 != null)
        {
            // 将 tomatoanim1 设为可见
            Scallions2.SetActive(true);
        }

        if (followTextscallions2 != null)
        {
            // 将 followText 设为可见
            followTextscallions2.SetActive(true);
        }
    }
}
