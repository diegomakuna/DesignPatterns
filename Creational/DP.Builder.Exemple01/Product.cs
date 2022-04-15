namespace DP.Builder.Exemple01;

public class Product
{
    private List<object> _parts = new List<object>();

    public void Add(string part){
        this._parts.Add(part);
    }

    public string ListParts()
    {
        string str = String.Empty;
        for (int i = 0; i < this._parts.Count; i++)
        {
            str += this._parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);
        return "Product Parts: " + str + "\n";
    }
}