using System;
using PackBook.Services.Interfaces;

namespace PackBook.Services;

public class UserController
{
  private readonly INotificationService _notificationService;
  public UserController(INotificationService notificationService)
  {
    _notificationService = notificationService;
  }
}
