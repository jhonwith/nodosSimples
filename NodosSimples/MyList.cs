namespace NodosSimples
{
    internal class MyList
    {
        private Node first;
        private int counter;

        public MyList()
        {
            first = null;
            this.counter = 1;
        }

        public void Add(string content)
        {
            Node newNode = new Node();
            newNode.SetContent(content);
            newNode.SetIndex(counter);
            counter++;
            newNode.SetPointer(null);
            if (first == null)
            {
                first = newNode;
            }
            else
            {
                Node lastNode = GetLastNode(this.first);
                lastNode.SetPointer(newNode);
            }
        }

        public string PrintList()
        {
            return this.PrintList(this.first);
        }
        private string PrintList(Node node, string result = "")
        {
            if (node == null)
            {
                return result;
            }
            else
            {
                result += "[" + node.GetIndex()+ "-" + node.GetContent() + "] ->";
                return this.PrintList(node.GetPointer(),result);
            }
        }

        private Node GetLastNode(Node node)
        {
            if (node.GetPointer() == null)
            {
                return node;
            }
            else
            {
                return this.GetLastNode(node.GetPointer());
            }
        }
    }
}