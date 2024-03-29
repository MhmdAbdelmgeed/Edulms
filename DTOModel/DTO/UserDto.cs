﻿namespace Edulms.DTO
{
    public class UserDto
    {
        public long Id { get; set; }
        public string ApiKey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsBanned { get; set; }
        public bool IsVerified { get; set; }
        public string ConfirmCode { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? PasswordChangedAt { get; set; }
        public string DisplayName { get; set; }
        public string UserUrl { get; set; }
        public bool IsLdap { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public string RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Otp { get; set; }
        public DateTime? OtpCreatedAt { get; set; }
        public long? ProfilePictureId { get; set; }
    }
}
