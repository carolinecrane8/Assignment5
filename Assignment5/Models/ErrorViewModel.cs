using System;
//i did not create this model, but it is going to help in the future form creation.
namespace Assignment5.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
