using hackaton.api.Helpers;
using hackaton.shared.Entities;
using hackaton.shared.Enums;
using System.Diagnostics.Eventing.Reader;

namespace hackaton.api.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;

        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckMentorAsync();
            await CheckHackatonAsync();
            await CheckRewardAsync();
            await CheckTeamAsync();
            await CheckParticipantAsync();
            await CheckProjectAsync();
            await CheckEvaluationAsync();

            await CheckRolesAsync();
            await CheckUserAsync("123", "OAP", "OAP", "test@gmail.com", "2554566", UserType.Admin);
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Document = document,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,

                    PhoneNumber = phone,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
            return user;
        }


        private async Task CheckMentorAsync()
        {
            if (!_context.Mentors.Any())
            {
                _context.Mentors.Add(new Mentor { Name = "Carlos", Experience = "Senior" });
                _context.Mentors.Add(new Mentor { Name = "Juan", Experience = "Junior" });
            }
            await _context.SaveChangesAsync();
        }
        private async Task CheckHackatonAsync()
        {
            if (!_context.Hackatons.Any())
            {
                _context.Hackatons.Add(new Hackaton { Name = "Hackaton 1", StartDate = DateTime.Now, EndDate =  DateTime.Now.AddDays(10), Topic = "Seguridad", Organizer= "Pepito Perez" });
                _context.Hackatons.Add(new Hackaton { Name = "Hackaton 2", StartDate = DateTime.Now, EndDate =  DateTime.Now.AddDays(20), Topic = "IA", Organizer = "Luisito Dominguez" });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckRewardAsync()
        {
            if (!_context.Rewards.Any())
            {
                var hackaton = _context.Hackatons.FirstOrDefault();
                _context.Rewards.Add(new Reward {Description= "Mackbook pro", Hackaton = hackaton });
                _context.Rewards.Add(new Reward {Description= "Iphone 16", Hackaton = hackaton });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckTeamAsync()
        {
            if (!_context.Teams.Any())
            {
                var hackaton = _context.Hackatons.FirstOrDefault();
                _context.Teams.Add(new Team { Name= "Los mejores 1", NumberMembers = 3, Hackaton = hackaton });
                _context.Teams.Add(new Team { Name= "Los mejores 2", NumberMembers = 4, Hackaton = hackaton });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckParticipantAsync()
        {
            if (!_context.Participants.Any())
            {
                var team = _context.Teams.FirstOrDefault();
                _context.Participants.Add(new Participant { Name= "Name 1", Rol = "developer", Experience = "desarrollo + test", Team = team});
                _context.Participants.Add(new Participant { Name= "Name 2", Rol = "tester", Experience = "test + UI" , Team = team });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckProjectAsync()
        {
            if (!_context.Projects.Any())
            {
                var team = _context.Teams.FirstOrDefault();
                _context.Projects.Add(new Project { Name= "Name 1", Description = "desarrollo app movil", Status = "en desarrollo", Team = team });
                _context.Projects.Add(new Project { Name= "Name 2", Description = "desarrollo app web", Status = "en analisis", Team = team });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckEvaluationAsync()
        {
            if (!_context.Evaluations.Any())
            {
                var project = _context.Projects.FirstOrDefault();
                var mentor = _context.Mentors.FirstOrDefault();
                _context.Evaluations.Add(new Evaluation { Score= 5, Remarks = "Excelente trabajo", Project = project, Mentor = mentor });
                _context.Evaluations.Add(new Evaluation { Score= 3, Remarks = "Buen trabajo, tiene oportunidad de mejora", Project = project, Mentor = mentor });
            }
            await _context.SaveChangesAsync();
        }
    }
}
