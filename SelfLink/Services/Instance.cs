﻿using SelfLink.Models;

namespace SelfLink.Services
{
    public static class Instance
    {
        public static readonly Collection Database = new Collection();
        public static User ClientUser = null;
        public static User SelectedRecipient = null;
            
        internal static Interface Gui = null;
    }
}