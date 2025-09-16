using System;

namespace PackBook.Services.Interfaces;

public interface INotificationService
{
  void SendNotification(string message);
}
