﻿namespace VoiceCommander.CommandLine
{
    class Register
    {
        public Register()
        {
            Command.Register("count", LineCommands.CountElements);
            Command.Register("clear", LineCommands.Clear);
            Command.Register("info", LineCommands.ShowItemDetails);
        }
    }
}
