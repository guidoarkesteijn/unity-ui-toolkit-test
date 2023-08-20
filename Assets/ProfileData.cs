using Unity.Properties;
using UnityEngine;

[CreateAssetMenu]
public class ProfileData : ScriptableObject
{
    [CreateProperty]
    public string Name { get; set; }

    [SerializeField] private string profileName;

    [CreateProperty]
    public string Description { get; set; }

    [SerializeField] private string description;

    [CreateProperty]
    public int Age { get; set; }

    [SerializeField] private int age;

    protected void OnValidate()
    {
        Name = profileName;
        Description = description;
        Age = age;
    }
}
