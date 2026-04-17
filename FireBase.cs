FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
{
    if (task.Result == DependencyStatus.Available)
    {
        Debug.Log("Firebase listo.");
    }
});