using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    public class ObjDict : GenericDict<object>
    {

    }

    public class ControlActionValuePair<T>
    {
        public ControlActionValuePair()
        {

        }
        public ControlActionValuePair(T controlKey, string action, object value, object waitTime)
        {
            this.ControlKey = controlKey;
            this.Action = action;
            this.Value = value;
            this.WaitTime = waitTime;
        }

        #region Properties

        private T controlKey;

        public T ControlKey 
        {
            get { return controlKey; }
            set { controlKey = value; }    
        }

        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private object val;

        public object Value
        {
            get { return val; }
            set { val = value; }
        }

        private object waitTime;

        public object WaitTime
        {
            get { return waitTime; }
            set { waitTime = value; }
        }

        #endregion
    }

    public class GenericDict<T>
    {
        private ArrayList _controlKeyValuePairs;       
        int _currIndex;                         


        
        public GenericDict()                 //constructor to initialize the fields
        {
            _controlKeyValuePairs = new ArrayList();
            _currIndex = -1;
        }

        
        public void Add(T controlKey, string action, object value, object waitTime)
        {
            ControlActionValuePair<T> pair = new ControlActionValuePair<T>(controlKey, action, value, waitTime);
            _controlKeyValuePairs.Add(pair);
        }
                
        public void Clear()
        {
            _controlKeyValuePairs.Clear();
            _currIndex = -1;
        }

        
        public int Count
        {
            get
            {
                return _controlKeyValuePairs.Count;
            }
        }

        
        public ArrayList ControlKeys
        {
            get
            {
                ArrayList keyitems = new ArrayList();
                foreach (ControlActionValuePair<T> kvPair in _controlKeyValuePairs)
                {
                    keyitems.Add(kvPair.ControlKey);
                }
                return keyitems;
            }
        }

        
        public object Value(T controlkey)
        {
            foreach (ControlActionValuePair<T> kvPair in _controlKeyValuePairs)
            {
                if (kvPair.ControlKey.ToString() == controlkey.ToString())
                    return kvPair.Value;
            }
            return null;
        }
                        
        public string Action(T controlKey)
        {
            foreach (ControlActionValuePair<T> kvPair in _controlKeyValuePairs)
            {
                if (kvPair.ControlKey.ToString() == controlKey.ToString())
                    return kvPair.Action;
            }
            return null;
        }

      
        public int CurrentIndex
        {
            get
            {
                return _currIndex;
            }
        }

        
        public object CurrentValue
        {
            get
            {
                return Value(_currIndex);
            }
        }

        public object CurrentWaitTime
        {
            get
            {
                return WaitTime(_currIndex);
            }
        }

        public string CurrentAction
        {
            get
            {
                return Action(_currIndex);
            }
        }

      
        public T CurrentControlKey
        {
            get
            {
                return ControlKey(_currIndex);
            }
        }
                      
        public bool Exist(T controlKey)
        {
            foreach (ControlActionValuePair<T> kvPair in _controlKeyValuePairs)
            {
                if (kvPair.ControlKey.ToString() == controlKey.ToString())
                    return true;
            }
            return false;
        }

       
        public bool MoveNext()
        {
            if (Count == 0)
                return false;

            if (_currIndex >= Count - 1)
                return false;

            _currIndex++;

            return true;
        }

        
        public T ControlKey(int index)
        {
            ControlActionValuePair<T> kvpair = (ControlActionValuePair<T>)_controlKeyValuePairs[index];
            return kvpair.ControlKey;
        }

        
        public object Value(int index)
        {
            ControlActionValuePair<T> kvpair = (ControlActionValuePair<T>)_controlKeyValuePairs[index];
            return kvpair.Value;
        }

        
        public string Action(int index)
        {
            ControlActionValuePair<T> kvpair = (ControlActionValuePair<T>)_controlKeyValuePairs[index];
            return kvpair.Action;
        }

        public object WaitTime(int index)
        {
            ControlActionValuePair<T> kvpair = (ControlActionValuePair<T>)_controlKeyValuePairs[index];
            return kvpair.WaitTime;
        }


        public void Reset()
        {
            _currIndex = -1;
        }

        
        public bool Remove(T controlKeyToRemove)
        {
            foreach (ControlActionValuePair<T> kvPair in _controlKeyValuePairs)
            {
                if (kvPair.ControlKey.ToString() == controlKeyToRemove.ToString())
                {
                    _controlKeyValuePairs.Remove(kvPair);
                }
                return true;
            }
            return false;
        }

       
        public bool RemoveAt(int index)
        {
            if ((index >= Count) || (index < 0))
                return false;

            _controlKeyValuePairs.RemoveAt(index);
            if (_currIndex > index)
            {
                _currIndex--;
            }
            return true;
        }

       
        public void InsertAt(int index, T controlkey, string action, string value, object waitTime)
        {
            if ((index > Count) || (index < 0))
                return;

            ControlActionValuePair<T> pair = new ControlActionValuePair<T>(controlkey, action, value, waitTime);

            _controlKeyValuePairs.Insert(index, pair);
            if (_currIndex >= index)
            {
                _currIndex++;
            }
        }
        
       
        public GenericDict<T> Clone
        {
            get
            {
                GenericDict<T> newDict = new GenericDict<T>();

                foreach (ControlActionValuePair<T> kvPair in _controlKeyValuePairs)
                {
                    T key = kvPair.ControlKey;
                    object value = kvPair.Value;
                    string action = kvPair.Action;
                    object waitTime = kvPair.WaitTime;
                    newDict.Add(key, action, value, waitTime);
                }

                return newDict;
            }
        }
                      
        public void InsertAt(int index, T controlkey, string value, object waitTime)
        {
            if ((index > Count) || (index < 0))
                return;

            ControlActionValuePair<T> pair = new ControlActionValuePair<T>(controlkey, ActionConstants.UNDEFINED, value, waitTime);

            _controlKeyValuePairs.Insert(index, pair);
            if (_currIndex >= index)
            {
                _currIndex++;
            }
        }

       
        //public void Add(T controlkey, object value, object waitTime)
        //{
        //    ControlActionValuePair<T> pair = new ControlActionValuePair<T>(controlkey, ActionConstants.UNDEFINED, value, waitTime);
        //    _controlKeyValuePairs.Add(pair);
        //}

       
        public object Item(T key)
        {
            return Value(key);
        }


        
        public object Item(int index)
        {
            return Value(index);
        }

        
        public object CurrentItem
        {
            get
            {
                return CurrentValue;
            }
        }

        
        public ControlActionValuePair<T> CurrentControlActionValuePair
        {
            get
            {
                return (ControlActionValuePair<T>)_controlKeyValuePairs[_currIndex];
            }
        }
    }
}
