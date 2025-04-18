﻿using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject(List<IObserver> observers)
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });  
        }
    }
}
