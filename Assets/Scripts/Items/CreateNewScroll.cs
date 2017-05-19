using UnityEngine;

public class CreateNewScroll : MonoBehaviour
{
    private BaseScroll _newScroll;
    private string[] _scrollNames = new string[4] {"Common", "Greate", "Amazing", "Insane"};
    private string _scrollDescription = "Just a Scroll";


    void Start()
    {
        CreateScroll();
        Debug.Log(_newScroll.ItemDescription);
        Debug.Log("Equipment name: " + _newScroll.ItemName);
        Debug.Log("Equipment ID: " + _newScroll.ItemId);
        Debug.Log("Equipment type: " + _newScroll.ItemType);
    }

    private void CreateScroll()
    {
        _newScroll = new BaseScroll
        {
            ItemDescription = _scrollDescription,
            ItemId = Random.Range(1, 101),
            ItemName = _scrollNames[Random.Range(0, 3)],
            SpellEffectId = Random.Range(101, 201),
            ItemType = BaseItem.ItemTypes.Scroll
        };
    }
}