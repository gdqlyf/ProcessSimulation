using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProcessSimulation
{
    public class WorkCollection:ICollection,ICloneable

    {
        public ArrayList dataList;
        public bool isover;
        public WorkCollection()
        {
            dataList = new ArrayList();
        }
        //public void CopyTo(Array myArr, int index)
        //{
        //    workList.CopyTo(myArr, index);
        //}
        //The IsSynchronized Boolean property returns True if the 
        //collection is designed to be thread safe; otherwise, it returns False.
        //public bool IsSynchronized
        //{
        //    get
        //    {
        //        return workList.IsSynchronized;
        //    }
        //}

        //The SyncRoot property returns an object, which is used for synchronizing 
        //the collection.This returns the instance of the object or returns the 
        //SyncRoot of other collections if the collection contains other collections.
        //public object SyncRoot
        //{
        //    get
        //    {
        //        return workList.SyncRoot;
        //    }
        //}

        //The Count read-only property returns the number 
        //of items in the collection.
        //public int Count
        //{
        //    get
        //    {
        //        return workList.Count;
        //    }
        //}
        // The IEnumerable interface is implemented by ICollection.
        //public IEnumerator GetEnumerator()
        //{
        //    return workList.GetEnumerator();
        //}


        #region ICollection 成员

        void ICollection.CopyTo(Array array, int index)
        {
            dataList.CopyTo(array, index);
        }

        public int Count
        {
            get { return dataList.Count; }
        }
        //The IsSynchronized Boolean property returns True if the 
        //collection is designed to be thread safe; otherwise, it returns False.
        bool ICollection.IsSynchronized
        {
            get { return dataList.IsSynchronized; }
        }

        object ICollection.SyncRoot
        {
            get { return dataList.SyncRoot; }
        }

        #endregion

        #region IEnumerable 成员

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dataList.GetEnumerator();
        }

        #endregion
        public WorkObject this[int index]
        {
            get {
                if (index >= dataList.Count || index < 0)
                    return (WorkObject)null;
                else return (WorkObject)dataList[index];
            }
            set {
                dataList[index] = value;
            }
        }

        #region ICloneable 成员

        object ICloneable.Clone()
        {
           return this.Clone();
        }
        public WorkCollection Clone()
        {
            WorkCollection wc = new WorkCollection();
            for (int i = 0;i < this.dataList.Count; i++)
                wc.dataList.Add(((WorkObject)this.dataList[i]).Copy());
            return wc;
        }
        #endregion
    }
}
