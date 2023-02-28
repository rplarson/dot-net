// See https://aka.ms/new-console-template for more information

MyList longList = new MyList();
MyList shortList = new MyList();
MyList emptyList = new MyList();

for(int i =0; i<20; i++){
    longList.Append(i);
}

longList.PrePend(1);
Node frontNode = longList.RemoveFromFront();
longList.Append(0);
Node backNode = longList.RemoveFromBack();

Console.WriteLine(frontNode.Data);
Console.WriteLine(backNode.Data);

longList.Insert(100,1);

shortList.Insert(1,1);
shortList.PrePend(0);
shortList.Append(2);

Console.WriteLine(emptyList.RemoveFromBack());
Console.WriteLine(emptyList.RemoveFromFront());

longList.Print();
shortList.Print();
emptyList.Print();

Console.WriteLine("It didn't crash!!");