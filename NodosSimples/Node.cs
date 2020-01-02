namespace NodosSimples
{
    internal class Node
    {
        private string content;
        private int index;
        private Node pointer;

        public int GetIndex()
        {
            return this.index;
        }

        public string GetContent()
        {
            return this.content;
        }
        public Node GetPointer()
        {
            return this.pointer;
        }
        public void SetContent(string newContent)
        {
            this.content = newContent;
        }

        public void SetIndex(int newindex)
        {
            this.index = newindex;
        }

        public void SetPointer(Node newNode)
        {
            this.pointer=newNode;
        }
    }
    
}