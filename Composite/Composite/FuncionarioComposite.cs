namespace Composite;

public class FuncionarioComposite : Funcionario
{
    protected List<Funcionario> _children = [];
    
    public FuncionarioComposite(string nome) : base(nome) {}

    public override void Add(Funcionario component)
    {
        this._children.Add(component);
    }
    
    public override void Remove(Funcionario component)
    {
        this._children.Remove(component);
    }

    public override Funcionario Get(int index)
    {
        return _children[index];
    }

    public override string Operation()
    {
        var i = 0;
        var result = $"Liderados de {this.Nome} (";

        foreach (var component in this._children)
        {
            result += component.Nome;

            if (i != this._children.Count - 1)
            {
                result += ", ";
            }

            i++;
        }

        return result + ")";
    }
}