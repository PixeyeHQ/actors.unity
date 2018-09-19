//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 9/16/2018


using System;
using System.Collections.Generic;


namespace Homebrew
{
    public static class Tags
    {
        public static Dictionary<int, int>[] tags = new Dictionary<int, int>[EngineSettings.MinEntities];
        public static int length = -1;


        public static void AddTags(int entityID)
        {
            if (length > entityID) return;

            if (entityID >= tags.Length)
            {
                int l = entityID << 1;

                Array.Resize(ref tags, l);
            }

            length++;
            tags[entityID] = new Dictionary<int, int>(4, new FastComparable());
        }
 
        public static void Clear(int id)
        {
            tags[id].Clear();
        }


        static void HandleChange(int id)
        {
            if (Toolbox.isQuittingOrChangingScene()) return;
            //   if (state.initialized && !state.enabled) return;


            var groups = ProcessingEntities.Default.GroupsBase;
            int len = ProcessingEntities.Default.groupLength;

            for (int i = 0; i < len; i++)
            {
                groups[i].TagsChanged(id);
            }

            groups = ProcessingEntities.Default.GroupsActors;
            len = ProcessingEntities.Default.groupLengthActors;
            for (int i = 0; i < len; i++)
            {
                groups[i].TagsChanged(id);
            }
        }

        #region TAGS

        public static void RemoveTags(this int entityID, int tagID)
        {
            bool tagsChanged = false;

            int val;
            if (!tags[entityID].TryGetValue(tagID, out val)) return;
            val = Math.Max(0, val - 1);

            if (val == 0)
            {
                tags[entityID].Remove(tagID);
                tagsChanged = true;
            }
            else tags[entityID][tagID] = val;


            if (tagsChanged == false) return;
            HandleChange(entityID);
        }

        public static void RemoveTags(this int entityID, params int[] tagIds)
        {
            bool tagsChanged = false;
            foreach (int index in tagIds)
            {
                int val;
                if (!tags[entityID].TryGetValue(index, out val)) continue;
                val = Math.Max(0, val - 1);

                if (val == 0)
                {
                    tags[entityID].Remove(index);
                    tagsChanged = true;
                }
                else tags[entityID][index] = val;
            }

            if (tagsChanged == false) return;
            HandleChange(entityID);
        }

        public static void RemoveAllTags(this int entityID, params int[] tagIds)
        {
            bool tagsChanged = false;
            foreach (int index in tagIds)
            {
                if (!tags[entityID].ContainsKey(index)) continue;
                tags[entityID].Remove(index);
                tagsChanged = true;
            }

            if (tagsChanged == false) return;
            HandleChange(entityID);
        }

        
        public static void RemoveTags(this Actor a, int tagID)
        {
            bool tagsChanged = false;
            var entityID = a.id;
            int val;
            if (!tags[entityID].TryGetValue(tagID, out val)) return;
            val = Math.Max(0, val - 1);

            if (val == 0)
            {
                tags[entityID].Remove(tagID);
                tagsChanged = true;
            }
            else tags[entityID][tagID] = val;


            if (tagsChanged == false) return;
            HandleChange(entityID);
        }

        public static void RemoveTags(this Actor a, params int[] tagIds)
        {
            bool tagsChanged = false;
            var entityID = a.id;
            foreach (int index in tagIds)
            {
                int val;
                if (!tags[entityID].TryGetValue(index, out val)) continue;
                val = Math.Max(0, val - 1);

                if (val == 0)
                {
                    tags[entityID].Remove(index);
                    tagsChanged = true;
                }
                else tags[entityID][index] = val;
            }

            if (tagsChanged == false) return;
            HandleChange(entityID);
        }

        public static void RemoveAllTags(this Actor a, params int[] tagIds)
        {
            bool tagsChanged = false;
            var entityID = a.id;
            foreach (int index in tagIds)
            {
                if (!tags[entityID].ContainsKey(index)) continue;
                tags[entityID].Remove(index);
                tagsChanged = true;
            }

            if (tagsChanged == false) return;
            HandleChange(entityID);
        }

 
        
        public static void AddTags(this int entityID, int tagId)
        {
            if (tags[entityID].ContainsKey(tagId))
            {
                tags[entityID][tagId] += 1;
                return;
            }

            tags[entityID].Add(tagId, 1);
            HandleChange(entityID);
        }

        public static void AddTags(this int entityID, params int[] tagIds)
        {
            bool c = false;
            foreach (int index in tagIds)
            {
                if (tags[entityID].ContainsKey(index))
                {
                    tags[entityID][index] += 1;
                    continue;
                }


                tags[entityID].Add(index, 1);
                c = true;
            }

            if (!c) return;
            HandleChange(entityID);
        }

        
        public static void AddTags(this Actor a, int tagId)
        {
            var entityID = a.id;
            if (tags[entityID].ContainsKey(tagId))
            {
                tags[entityID][tagId] += 1;
                return;
            }

            tags[entityID].Add(tagId, 1);
            HandleChange(entityID);
        }

        public static void AddTags(this Actor a, params int[] tagIds)
        {
            var entityID = a.id;
            bool c = false;
            foreach (int index in tagIds)
            {
                if (tags[entityID].ContainsKey(index))
                {
                    tags[entityID][index] += 1;
                    continue;
                }


                tags[entityID].Add(index, 1);
                c = true;
            }

            if (!c) return;
            HandleChange(entityID);
        }

        
        public static bool Has(this int entityID, int filter)
        {
            var container = tags[entityID];
            return container.ContainsKey(filter);
        }

        public static bool Has(this int entityID, params int[] filter)
        {
            var container = tags[entityID];

            for (int i = 0; i < filter.Length; i++)
            {
                if (!container.ContainsKey(filter[i])) return false;
            }

            return true;
        }

        public static bool Has(this Actor a, int filter)
        {
            var container = tags[a.id];

            return container.ContainsKey(filter);
        }

        public static bool Has(this Actor a, params int[] filter)
        {
            var container = tags[a.id];
            for (int i = 0; i < filter.Length; i++)
            {
                if (!container.ContainsKey(filter[i])) return false;
            }

            return true;
        }

        public static bool HasAny(this Actor a, params int[] filter)
        {
            var container = tags[a.id];

            for (int i = 0; i < filter.Length; i++)
            {
                if (container.ContainsKey(filter[i]))
                    return true;
            }

            return false;
        }

        public static bool HasAny(this int entityID, params int[] filter)
        {
            var container = tags[entityID];

            for (int i = 0; i < filter.Length; i++)
            {
                if (container.ContainsKey(filter[i]))
                    return true;
            }

            return false;
        }

        #endregion
    }
}