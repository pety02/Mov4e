﻿namespace Mov4e.Presenter.LogInPresenter
{
    public interface ILogInPresenter
    {
        void LogUser();
        void ResetPass(string username, string email);
    }
}