using System;

namespace Library
{
    public class MayorEdadChild : IVisitor
    {
        private int mayorNumero = int.MinValue;

        public int MayorEdad()
        {
            throw new NotImplementedException();
        }

        public int MayorNumero()
        {
            return mayorNumero;
        }

        public void Visit(Node node)
        {
            if (node.Children.Count == 0)
            {
                // Si es un nodo hoja, comprobar si su número es mayor al mayor número registrado hasta ahora
                if (node.Number > mayorNumero)
                {
                    mayorNumero = node.Number;
                }
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }

    }

}