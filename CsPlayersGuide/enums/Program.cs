ChestState state = ChestState.Locked;

while (true)
{
    state = ChangeState(state);
}

static ChestState ChangeState(ChestState currentState) 
{
    string action = "";
    if (currentState == ChestState.Closed)
    {
        Console.Write("The chest is closed. What do you want to do? ");
        action = Console.ReadLine();

        if (action.ToUpper() == "OPEN")
        {
            return ChestState.Open;
        }
        else if (action.ToUpper() == "LOCK")
        {
            return ChestState.Locked;
        }
    }
    else if (currentState == ChestState.Open)
    {
        Console.Write("The chest is open. What do you want to do? ");
        action = Console.ReadLine();
        if (action.ToUpper() == "CLOSE")
        {
            return ChestState.Closed;
        }
    }
    else if (currentState == ChestState.Locked)
    {
        Console.Write("The chest is locked. What do you want to do? ");
        action = Console.ReadLine();
        if (action.ToUpper() == "UNLOCK")
        {
            return ChestState.Closed;
        }
    }
    return currentState;
}

enum ChestState 
{
    Open,
    Closed,
    Locked
}