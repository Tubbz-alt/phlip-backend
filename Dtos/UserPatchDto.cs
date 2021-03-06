﻿namespace Esquire.Models
{
    /// <summary>
    /// PatchDto for updating a User object
    /// This is currently only being used by the UI to update the Avatar.
    /// </summary>
    public class UserPatchDto
    {
        /// <summary>
        /// FirstName - the User's first name.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// LastName - the User's last name.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Avatar - the User's avatar which is displayed in various places in the UI.
        /// </summary>
        public string Avatar { get; set; }
        
        /// <summary>
        /// IsActive - allows users to be deactivated
        /// </summary>
        public bool? IsActive { get; set; }
        
        //TODO: use enum
        /// <summary>
        /// Role - The Users role
        /// Coder - can only view Project details and Coding screen
        /// Coordinator - all rights of coder and can edit Project details and has access to Validation screen
        /// Admin - has all rights of Coordinator and can access User management
        /// </summary>
        public string Role { get; set; }
    }
}