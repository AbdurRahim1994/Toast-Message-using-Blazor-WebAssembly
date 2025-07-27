Project : Toast Message in Blazor Web Assembly

Step : 1 
Install Blazored.Toast package from Nuget Package Manager

Step : 2
Register toast service in Program.cs 

Namespace : using Blazored.Toast
builder.Services.AddScoped<ToastHelper>(); (Write this code before await builder.Build().RunAsync();) // Your toast helper class registration
builder.Services.AddBlazoredToast(); (Write this code before await builder.Build().RunAsync();)

Step : 3
Add toast container to MainLayout.razor

@using Blazored.Toast
@using Blazored.Toast.Configuration

<BlazoredToasts Position="ToastPosition.TopRight" Timeout="5" IconType="IconType.FontAwesome" ShowProgressBar="true" ShowCloseButton="true" PauseProgressOnHover="true"/>
(Add this line of code before @Body in your MainLayout.razor. You can configure all attributes as you choice. Please check BlazoredToasts GitHub repository)

Step : 4
Make a Toast Helper class to use toast message globally 

public class ToastHelper
{
    private readonly IToastService _toastService;
    public ToastHelper(IToastService toastService) 
    {
        _toastService = toastService;
    }
    public void SuccessToast(string message)
    {
        _toastService.ShowSuccess(message);
    }
    public void ErrorToast(string message)
    {
        _toastService.ShowError(message);
    }
}

Step : 5
Now you can use toast message to your desired razor page
@inject ToastMessage.Helper.ToastHelper ToastService (Use namespace of your toast helper class)

Check empty input like this 
private void FormSubmit()
{
	if (string.IsNullOrWhiteSpace(user.Name))
	{
		ToastService.ErrorToast("Name is required");
	}
	else if (string.IsNullOrWhiteSpace(user.Email))
	{
		ToastService.ErrorToast("Email is required");
	}
	else if (string.IsNullOrWhiteSpace(user.Phone))
	{
		ToastService.ErrorToast("Phone is required");
	}
	else
	{
		ToastService.SuccessToast("Form submitted successfully");
	}
}

Now use the function in onclick method of your button# Toast_Message_Practise
