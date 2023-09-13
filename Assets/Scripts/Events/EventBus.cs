using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Events{
    public class EventBus 
    {
        private static readonly Dictionary<EventType,UnityEvent> Events = new();
        
        public static void Subscribe(EventType type, UnityAction listener){
            UnityEvent thisEvent;
            if(Events.TryGetValue(type, out thisEvent)){
                thisEvent.AddListener(listener);
            }
            else{
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Events.Add(type,thisEvent);
            }

        }
        public static void Unsubscribe(EventType type, UnityAction listener){
            UnityEvent thisEvent;
            if(Events.TryGetValue(type, out thisEvent )){
                thisEvent.RemoveListener(listener);
            }
        }

        public static void Publish(EventType type){
            UnityEvent thisEvent;

            if(Events.TryGetValue(type, out thisEvent)){
                thisEvent.Invoke();
            }
        }
    }

    public enum EventType{
        Gamewin =0,
        Gamelose =1
    }
}
