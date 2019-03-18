﻿using CyberSource.Authentication.Core;

namespace CyberSource.Authentication.Interfaces
{
    /// <summary>
    /// Token generation.
    /// </summary>
    public interface ITokenGenerator
    {
        /// <summary>
        /// Generate token based on authentication type.
        /// </summary>
        /// <returns></returns>
        Token GetToken();
    }
}
