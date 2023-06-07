namespace Library
{
    public class NombreMasLargo : IVisitor
    {
        private string nombreLargo = "";

        public string LongestName { get { return nombreLargo; } }

        public void Visit(Node node)
        {
            if (node.Persona.Nombre.Length > nombreLargo.Length)
            {
                nombreLargo = node.Persona.Nombre;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}
