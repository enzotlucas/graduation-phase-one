﻿using System.ComponentModel;

namespace PoliceDepartment.EvidenceManager.SharedKernel.Responses
{
    public enum ResponseMessage
    {
        [Description("An error ocurred, try again later")]
        GenericError = 0,
        [Description("Success")]
        Success = 1,
        [Description("Case does't exists")]
        CaseDontExists = 2,
        [Description("Invalid case")]
        InvalidCase = 3,
        [Description("Invalid credentials")]
        InvalidCredentials = 4,
        [Description("Action is not permited")]
        Forbidden = 5,
        [Description("Evidence does't exists")]	
        EvidenceDontExists = 6,
        [Description("User is not authenticated")]
        UserIsNotAuthenticated = 7,
        [Description("Invalid evidence")]
        InvalidEvidence = 8,
    }
}
