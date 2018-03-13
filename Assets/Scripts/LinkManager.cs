using UnityEngine;

public class LinkManager : MonoBehaviour {

    public void GoToURL(string url)
    {
        Application.OpenURL(url);
    }
}
