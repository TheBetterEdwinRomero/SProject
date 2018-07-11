using System;
using System.Collections.Generic;




/// <summary>
/// This object is used to store state and create queries.
/// It is the primitive type to create a Rule object.
/// Made of only Context and a Value
/// </summary>
public class FactObject
{
    /// <summary>
    /// Context is used to identify who, what, where
    /// Varient is a value associated to the context
    /// The arguments will be used to form a Key Value pair
    /// </summary>
    /// <param name="context"></param>
    /// <param name="varient"></param>    
    public FactObject(string context, Object varient)
    {
        this.Context = context;
        this.VarientValue = varient;
    }

    public Object VarientValue
    {
        get
        {
            return VarientValue;
        }
        private set
        {
            VarientValue = value;
        }
    }

    public string Context
    {
        get
        {
            return Context;
        }

        private set
        {
            Context = value;
        }
    }
}

