namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
            // we have 3 scenarios when is admin, when the user is the same person who did the reservation
            // the 3rd scenario is when someone else try to cancel the reservation
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
