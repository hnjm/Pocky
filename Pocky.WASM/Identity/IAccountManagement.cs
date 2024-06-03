﻿using Pocky.WASM.Models;

namespace Pocky.WASM.Identity;

public interface IAccountManagement
{
    Task<AuthResult> LoginAsync(LoginModel credentials);
    Task<AuthResult> RegisterAsync(string email, string password);
    Task LogoutAsync();
}