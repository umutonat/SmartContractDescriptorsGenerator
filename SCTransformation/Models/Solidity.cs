﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace SCTransformation.Models
{
    public class Solidity
    {
        public string Pragma { get; set; }
        public List<string> Imports { get; set; }
        public List<Contract> Contracts { get; set; }

        public class Contract
        {
            public string Name { get; set; }
            public List<StateVariable> StateVariables { get; set; }
            public List<Function> Functions { get; set; }
            public List<Event> Events { get; set; }
            public List<Modifier> Modifiers { get; set; }
            public List<SolidityEnum> Enums { get; set; }
            public List<Struct> Structs { get; set; }
            public ContractType ContractType { get; set; }
        }

        public class StateVariable
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public List<Keyword> Keywords { get; set; }
        }

        public class Function
        {
            public string Name { get; set; }
            public List<Parameter> Parameters { get; set; }
            public List<Parameter> ReturnParameters { get; set; }
            public ModifierList ModifierList { get; set; }
            public Scope Scope { get; set; }
        }

        public class Event
        {
            public string Name { get; set; }
            public Scope Scope { get; set; }
        }

        public class Modifier
        {
            public string Name { get; set; }
            public List<Parameter> Parameters { get; set; }
        }

        public class ModifierList
        {
            public StateMutability StateMutability { get; set; }
            public ModifierInvocation ModifierInvocation { get; set; }
            public bool IsVirtual { get; set; }
            public List<string> Override { get; set; }
        }

        public class ModifierInvocation
        {
            public string Identifier { get; set; }
            public List<string> Expressions { get; set; }
        }

        public enum StateMutability
        {
            None,
            Pure,
            Constant,
            View,
            Payable
        }

        public class Parameter
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public StorageLocation StorageLocation { get; set; }
        }

        public class SolidityEnum
        {
            public string Name { get; set; }
            public List<string> Enums { get; set; }
        }

        public class Struct
        {
            public string Name { get; set; }
            public List<Variable> Variables { get; set; }
        }

        public class Variable
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public StorageLocation StorageLocation { get; set; }
        }

        public enum StorageLocation
        {
            None,
            Memory,
            Storage,
            CallData
        }

        public enum Scope
        {
            Public,
            Internal,
            External,
            Private
        }

        public enum Keyword
        {
            Constant,
        }

        public enum ContractType
        {
            Interface,
            Library,
            Contract
        }
    }
}