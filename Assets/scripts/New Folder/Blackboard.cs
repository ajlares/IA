using System.Collections.Generic;

public class Blackboard : UnityEditor.Experimental.GraphView.Blackboard
{
    private Dictionary<string, object> data = new Dictionary<string, object>();

    public void Set<T>(string key, T value)
    {
        data.Add(key, value);
    }

    public T Get<T>(string key)
    {
        if (data.TryGetValue(key, out object value))
        {
            return (T)value;
        }
        return default(T);
    }
}
