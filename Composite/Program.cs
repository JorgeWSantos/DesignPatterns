using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form("form");
            form.Add(new Button("incluir"));
            form.Add(new Button("excluir"));
            form.Add(new TextBox("nome"));
            form.Add(new TextBox("celular"));
            form.Display();
        }
    }
}
