using Application.Dto.UserDto;
using Application.Services;

namespace Uchebka
{
    public partial class Form2 : Form
    {
        private readonly UserService _userService;
        private readonly CancellationToken _cancellationToken;
    
        public Form2(
            UserService userService,
            CancellationToken cancellationToken)
        {
            _userService = userService;
            _cancellationToken = cancellationToken;
            InitializeComponent();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var newUser = new AddUserRequest { Email = textBox1.Text, Password = textBox2.Text };
            var isExist = await _userService.AddAsync(newUser, _cancellationToken);
            if (isExist == null)
                MessageBox.Show(@"Пользователь с данной почтой уже существует");
            else
            {
                MessageBox.Show(@"Регистрация успешна");
                var form1 = new Form1(
                    _userService,
                    _cancellationToken);
                form1.Show();
                Hide();
            }
        }
    }
}
