
class RequestContext
{
    private IState _currentState;

    public RequestContext()
    {
        // По умолчанию запрос находится в состоянии "Новый"
        _currentState = new NewState();
    }

    public void SetState(IState newState)
    {
        _currentState = newState;
    }

    public void HandleRequest()
    {
        _currentState.HandleRequest();
    }
}