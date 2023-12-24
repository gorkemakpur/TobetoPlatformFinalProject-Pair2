using Business.Abstracts;
using Business.Dtos.AnnouncementUser.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AnnouncementUsersController : BaseController
{
    private readonly IAnnouncementUserService _announcementUser;

    public AnnouncementUsersController(IAnnouncementUserService announcementUser)
    {
        _announcementUser = announcementUser;
    }
}