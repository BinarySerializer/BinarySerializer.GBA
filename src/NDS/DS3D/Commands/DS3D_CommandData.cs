﻿namespace BinarySerializer.Nintendo 
{
    public abstract class DS3D_CommandData : BinarySerializable 
    {
        public DS3D_Command Command { get; set; }
    }
}