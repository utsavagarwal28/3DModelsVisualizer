using UnityEngine;

public class TagsActivationScript : MonoBehaviour
{
    [SerializeField] private bool isTagActive = false;
    [SerializeField] private GameObject bodyPartTags;
    [SerializeField] private GameObject showTagText;
    [SerializeField] private GameObject hideTagText;

    void Start()
    {
        bodyPartTags.SetActive(isTagActive);
        showTagText.SetActive(!isTagActive);
        hideTagText.SetActive(isTagActive);
    }

    public void SwitchTagActivationStatus()
    {
        isTagActive = !isTagActive;
        bodyPartTags.SetActive(isTagActive);
        showTagText.SetActive(!isTagActive);
        hideTagText.SetActive(isTagActive);
    }
}
