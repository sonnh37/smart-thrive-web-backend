﻿namespace Smart_Thrive.RequestModel
{
    public class ProviderRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
    }
}
