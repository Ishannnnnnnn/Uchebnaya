using Application.Dto.UserDto;
using Application.Services;

namespace Uchebka;

public partial class Form1 : Form
{
    private readonly UserService _userService;
    private readonly CancellationToken _cancellationToken;
    
    public Form1(
        UserService userService,
        CancellationToken cancellationToken)
    {
        _userService = userService;
        _cancellationToken = cancellationToken;
        InitializeComponent();
    }

    private async void EnterButton_Click(object sender, EventArgs e)
    {
        var loginRequest = new LoginRequest
        {
            Email = Email.Text,
            Password = Password.Text
        };
        
        var user = await _userService.LoginAsync(loginRequest, _cancellationToken);

        if (user == null)
            MessageBox.Show(@"Неверный логин или пароль");
    }

    private void ToRegisterButton_Click(object sender, EventArgs e)
    {
        var form2 = new Form2(_userService, _cancellationToken);
        Hide();
        form2.Show();
    }
}