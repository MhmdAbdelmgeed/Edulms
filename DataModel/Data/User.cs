namespace Edulms.Data
{
    public class User
    {
        public long Id { get; set; }
        public string? Api_Key { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public byte Is_Banned { get; set; }
        public byte Is_Verified { get; set; }
        public string? Confirm_Code { get; set; }
        public DateTime? Confirmed_At { get; set; }
        public DateTime? Password_Changed_At { get; set; }
        public string? Display_Name { get; set; }
        public string? User_Url { get; set; }
        public byte Is_Ldap { get; set; }
        public long Created_By { get; set; }
        public long Updated_By { get; set; }
        public string? Remember_Token { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
        public string? Otp { get; set; }
        public DateTime? Otp_Created_At { get; set; }
        public long? Profile_Picture_Id { get; set; }
        public List<Assessment_Enrol>? Enrols { get; set; }
        public List<Assessment_Answer>? Answers { get; set; }
    }
}
