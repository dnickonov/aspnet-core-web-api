using NUnit.Framework;
using NSubstitute;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services.Interfaces;
using WebApi.ViewModels;
using System.Security.Cryptography.X509Certificates;
using WebApi.Services;
using DataAccessLayer.Models;
using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Tests
{
    public class Tests
    {
        CommentNewViewModel _model;
        ICommentService _commentService;
        //ApplicationUser _applicationUser;
        //UserManager<ApplicationUser> _userManager;
        //IHttpContextAccessor _contextAccessor;
        //ApplicationDbContext _context;
        //DbContextOptions _options;

        [SetUp]
        public void Setup()
        {
            //_applicationUser = new ApplicationUser();
            //_userManager = Substitute.For<UserManager<ApplicationUser>>(_applicationUser);
            //_contextAccessor = Substitute.For<IHttpContextAccessor>();
            //_options = Substitute.For<DbContextOptions>();
            //_context = Substitute.For<ApplicationDbContext>();
            _commentService = Substitute.For<ICommentService>();

            _model = Substitute.For<CommentNewViewModel>();
        }

        [Test]
        public async Task Test1()
        {
            var result = await _commentService.CreateOrUpdateAsync(_model);
            var result2 = await _commentService.GetListAsync(234);
            var commentService = Substitute.For<ICommentService>().GetListAsync(234);


            Assert.Pass();
        }
    }
}