namespace Solid_2;

// Порушено принцип єдиної відповідальності (SRP): EmailSender не лише
// надсилав листи, а й сам вирішував, як вести лог (через консоль).
// Щоб змінити спосіб логування, довелося б правити клас відправки.
//
// Виправлення: логування винесено в абстракцію ILogger, яку клас отримує ззовні
// (заодно це виконує принцип інверсії залежностей, DIP).
public class EmailSender
{
    private readonly ILogger _logger;

    public EmailSender(ILogger logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
    {
        // ... sending...
        _logger.Log("Email from '" + email.From + "' to '" + email.To + "' was send");
    }
}
