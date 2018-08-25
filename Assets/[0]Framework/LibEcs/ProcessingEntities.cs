/*===============================================================
         Product:    Cryoshock
         Developer:  Dimitry Pixeye - pixeye@hbrew.store
         Company:    Homebrew - http://hbrew.store
         Date:       25/01/2018 00:05
         ================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    public class ProcessingEntities : IDisposable
    {
        public static List<IStorageType> storageTypes = new List<IStorageType>();
        public static ProcessingEntities Default;

        public GroupBase[] GroupsBase = new GroupBase[64];
        public int groupCount;


        public Group[] GroupsActors = new Group[32];
        public int groupCountActors;


        public static void KillEntity(int index)
        {
            Actor.prevID.Push(index);
        }

        public static void Remove<T>(int index) where T : new()
        {
           
            Storage<T>.Instance.Remove(index);
        }

        public static void AddEntity(Actor monoActor)
        {
            var len = Actor.entites.Length;

            if (Actor.lastID == len)
            {
                Array.Resize(ref Actor.entites, Mathf.Clamp(Actor.lastID << 1, 0, 1000000));
            }
 
            if (Actor.prevID.Count>0)
            {
                monoActor.id = Actor.prevID.Pop();
                  //  Actor.prevID;
                //Actor.prevID = -1;
              //  Debug.Log(monoActor.id + "_" + Actor.entites.Length);
                Actor.entites[monoActor.id] = monoActor;
            }
            else
            {
                monoActor.id = Actor.lastID;
                Actor.entites[Actor.lastID++] = monoActor;
            }
        }

        public static int AddEntity()
        {
            int id;
            if (Actor.prevID.Count>0)
            {
                id = Actor.prevID.Pop();
              
            }
            else
            {
                id = Actor.lastID++;
            }

            return id;
        }


        public GroupBase AddGetGroupActors(Type groupType, Composition filter)
        {
            var i = groupCountActors - 1;

            for (; i >= 0; i--)
            {
                if (GroupsActors[i].Composition.Equals(filter))
                {
                    break;
                }
            }
 
            if (i != -1) return GroupsActors[i];

      
            var group_ = Activator.CreateInstance(groupType, true) as Group;

            group_.Composition = filter;
            group_.Populate();

            if (groupCountActors == GroupsActors.Length)
            {
                Array.Resize(ref GroupsActors, groupCountActors << 1);
            }

            GroupsActors[groupCountActors++] = group_;

            return group_;
        }

        public GroupBase AddGetGroup(Type groupType, Composition filter)
        {
            if (groupType == typeof(Group))
            {
                return AddGetGroupActors(groupType, filter);
            }

            var i = groupCount - 1;
            for (; i >= 0; i--)
            {
                if (GroupsBase[i].GetType() != groupType) continue;
                if (GroupsBase[i].Composition.Equals(filter))
                {
                    break;
                }
            }
          
            if (i != -1) return GroupsBase[i];
            
            i = groupCount;

            var group_ = Activator.CreateInstance(groupType, true) as GroupBase;

            group_.Composition = filter;

            group_.Populate();


            if (groupCount == GroupsBase.Length)
            {
                Array.Resize(ref GroupsBase, groupCount << 1);
            }

            GroupsBase[groupCount++] = group_;

            return GroupsBase[i];
        }


        public void CheckGroups(int entityID, bool active)
        {
       
            if (active)
            {
                for (var i = 0; i < groupCountActors; i++)
                {
                    GroupsActors[i].TryAddEntity(entityID);
                }

                for (var i = 0; i < groupCount; i++)
                {
                    GroupsBase[i].TryAddEntity(entityID);
                }
            }
            else
            {
                for (var i = 0; i < groupCount; i++)
                {
                    GroupsBase[i].TryRemoveEntity(entityID);
                }


                for (var i = 0; i < groupCountActors; i++)
                {
                    GroupsActors[i].TryRemoveEntity(entityID);
                }
            }
       
        }

        public void Dispose()
        {
        }
    }
}