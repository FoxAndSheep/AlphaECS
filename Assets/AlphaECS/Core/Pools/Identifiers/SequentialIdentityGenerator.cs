﻿namespace AlphaECS
{
    public class SequentialIdentityGenerator : IIdentityGenerator
    {
        private int _lastIdentifier = 0;

        public int GenerateId()
        { return ++_lastIdentifier; }
    }
}