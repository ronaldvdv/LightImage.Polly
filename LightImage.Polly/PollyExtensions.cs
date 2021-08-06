﻿using Polly.Retry;
using LightImage.Polly;

namespace Polly
{
    public static class PollyExtensions
    {
        public static AsyncRetryPolicy WaitAndRetryAsync(this PolicyBuilder builder, RetryPolicyConfig policy)
        {
            return builder.WaitAndRetryAsync(policy.MaxAttempts - 1, attempt => policy.GetInterval(attempt));
        }
    }
}