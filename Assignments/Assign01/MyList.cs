public class MyList{

    public Node? Head {get; set;}
    public int Length {get; set;}

    public MyList(){
        this.Head = null;
    }

    public MyList(int data){
        this.Head = new Node(data);
        this.Length++;
    }

    //=================================================
    //TODO: implement all of the below methods.
    //=================================================

    public void Print(){
        //prints all values in the list starting from the head and traversing down to the tail
        if(this.Head == null){
            Console.WriteLine("This list is empty");
        }
        else{
            Node currNode = this.Head;
            while(currNode.Next != null){
                Console.WriteLine("Current node data: " + currNode.Data);
                currNode = currNode.Next;
            }
            Console.WriteLine("Current node data: " + currNode.Data);

        }
        Console.WriteLine("This list has a length of " + this.Length);
        Console.WriteLine();
    }

    public void Append(int data){
        //creates a node with the data passed and adds the node to the end of the list
        Node newNode = new Node(data);
        if(this.Head == null){
            this.Head = newNode;
        }
        else{
            Node currNode = this.Head;
            while(currNode.Next != null){
                currNode=currNode.Next;
            }
            currNode.Next = newNode;   
        }
        this.Length++;
    }

    public void PrePend(int data){
        //creates a node with the data passed and prepends the node passed to the beginning of the list. This node will now be the new head of the list.
        Node node = new Node(data);
        if(this.Head == null){
            this.Head = node;
        }
        else{
            node.Next = this.Head;
            this.Head = node;
        }
        this.Length++;
        
    }

    public void Insert(int data, int index){
        //creates a node with the data passed and inserts the node to desired "index" in list with the head being considered index 0 for the count.

        //Hint: if index == 0 or if index == this.Length-1, think of how we can reuse methods we already have written
        //in order to reduce what we write for this method.

        if(index == 0){
            PrePend(data);
        }
        else if(index >= (this.Length-1)){
            Append(data);
        }
        else{
            Node node = new Node(data);
            Node currNode = this.Head;
            for(int i=1; i<index; i++){
                currNode = currNode.Next;
            }
            node.Next = currNode.Next;
            currNode.Next = node;
            this.Length++;
        }
    }

    public Node? RemoveFromFront(){
        //removes the head node from the list and returns node.
        //the new head will be the next node in the list.
        Node returnNode;
        if(this.Head == null){
            returnNode = this.Head;
        }

        else{
            returnNode = this.Head;
            this.Head = this.Head.Next;
            this.Length--;
        }

        return returnNode;
    }

    public Node? RemoveFromBack(){
        //removes the last node in the list and returns that node.
        Node returnNode;
        if(this.Head == null){
            returnNode = this.Head;
        }
        else if(this.Head.Next == null){
            returnNode = this.Head;
            this.Head = this.Head.Next;
            this.Length--;
        }
        else{
            Node currNode = this.Head;
            while(currNode.Next.Next != null){
                currNode = currNode.Next;
            }
            returnNode = currNode.Next;
            currNode.Next = null;
            this.Length--;
        }
        return returnNode;
        
    }

}