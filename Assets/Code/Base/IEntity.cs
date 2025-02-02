using System;
using System.Collections.Generic;

namespace JBS.Base
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }

    public interface IComponent
    {
        Guid Id { get; set; }
    }

    public interface ICharacter : IEntity
    {
        string Name { get; }
        
        bool TryGetComponent<T>(out T component) where T : class, IComponent;
        
        void AddComponent<T>(T component) where T : class, IComponent;
    }
}