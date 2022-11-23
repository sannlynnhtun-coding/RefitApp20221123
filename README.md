# RefitApp20221123

Ref - <br />
https://github.com/reactiveui/refit#readme <br />
https://code-maze.com/using-refit-to-consume-apis-in-csharp/ <br />

![Refit](https://raw.githubusercontent.com/reactiveui/refit/main/refit_logo.png)

## Refit: The automatic type-safe REST library for .NET Core, Xamarin and .NET

Package Manager :
```
PM > NuGet\Install-Package Refit -Version 6.3.2
```

Refit is a library heavily inspired by Square's
[Retrofit](http://square.github.io/retrofit) library, and it turns your REST
API into a live interface:

```csharp
public interface IGitHubApi
{
    [Get("/users/{user}")]
    Task<User> GetUser(string user);
}
```

The `RestService` class generates an implementation of `IGitHubApi` that uses
`HttpClient` to make its calls:

```csharp
var gitHubApi = RestService.For<IGitHubApi>("https://api.github.com");
var octocat = await gitHubApi.GetUser("octocat");
```

.NET Core supports registering via HttpClientFactory

```csharp
services
    .AddRefitClient<IGitHubApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.github.com"));
```
