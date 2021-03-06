﻿using System;

namespace CliFx.Attributes
{
    /// <summary>
    /// Annotates a property that defines a command parameter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CommandParameterAttribute : CommandArgumentAttribute
    {
        /// <summary>
        /// Order of this parameter compared to other parameters.
        /// All parameters in a command must have different order.
        /// Parameter whose type is a non-scalar (e.g. array), must be the last in order and only one such parameter is allowed.
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// Parameter name, which is only used in help text.
        /// If this isn't specified, property name is used instead.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Initializes an instance of <see cref="CommandParameterAttribute"/>.
        /// </summary>
        public CommandParameterAttribute(int order)
        {
            Order = order;
        }
    }
}