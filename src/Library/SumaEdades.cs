namespace Library
{
    public class SumaEdades : IVisitor
    {
        public int SumaDeEdades { get; set; }

        public void Visit(Node node)
        {
            SumaDeEdades += node.Persona.Edad;

            foreach (var niño in node.Children)
            {
                niño.Accept(this);
            }
        }
    }
}