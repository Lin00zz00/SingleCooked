using UnityEngine;

public class Showtomatoanim1ElementsOnAppear : MonoBehaviour
{
    public GameObject tomatoanim1;
    public GameObject followText;

    private void OnBecameVisible()
    {
        // 当 ChopTomatoesElement 可见时执行的逻辑
        if (tomatoanim1 != null)
        {
            // 将 tomatoanim1 设为可见
            tomatoanim1.SetActive(true);
        }

        if (followText != null)
        {
            // 将 followText 设为可见
            followText.SetActive(true);
        }
    }
}

