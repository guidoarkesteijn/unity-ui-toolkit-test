using App.Ask;
using UnityEngine;
using UnityEngine.UIElements;

public class TestScript : MonoBehaviour
{
    public ProfileView view;

    public ProfileView[] views;

    protected void Awake()
    {
        var group = new ConverterGroup("StyleConverters");
        group.AddConverter((ref bool v) => { return StyleConverters.ResolveBool(v); });
        group.AddConverter((ref int v) => { return StyleConverters.ResolveInt(v); });
        ConverterGroups.RegisterConverterGroup(group);
    }

    // Start is called before the first frame update
    protected void Start()
    {
        ListView listView = GetComponent<UIDocument>().rootVisualElement.Q<ListView>("list");
        listView.itemsSource = views;
    }
}
