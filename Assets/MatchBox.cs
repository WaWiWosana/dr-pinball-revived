using UnityEngine;

public class MatchBox : MonoBehaviour
{
    public MatchBox matchingPair;
    public GameObject wirePrefab;
    public Transform wireSpawnLocation;
    public bool isMatched = false;
    public KeyCode triggerKey;

    private static MatchBox firstSelected = null;

    void Update()
    {

        if (Input.GetKeyDown(triggerKey))
        {
            Debug.Log($"Key pressed for: {gameObject.name}");
            OnClick();
        }
    }

    void OnMouseDown()
    {
        Debug.Log($"Mouse clicked on: {gameObject.name}");
        OnClick();
    }

    public void OnClick()
    {
        if (isMatched || this == firstSelected)
            return;

        if (firstSelected == null)
        {
            firstSelected = this;
        }
        else
        {
            if (firstSelected.matchingPair == this)
            {
                Debug.Log("Matched!");

                isMatched = true;
                firstSelected.isMatched = true;

                // Spawn the wire
                if (wirePrefab != null && wireSpawnLocation != null)
                {
                    Instantiate(wirePrefab, wireSpawnLocation.position, Quaternion.identity);
                }
            }
            else
            {
                Debug.Log("Not a match.");
            }

            firstSelected = null;
        }
    }
}
