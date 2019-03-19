//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using UnityEngine;

namespace Pixeye
{
	public class ProcTest : ProcBase, ITick
	{
		public Group<ComponentTest> group_test;

		[GroupBy(Tag.test)]
		public Group<ComponentTest> group_test2;

		[GroupBy(Tag.test2)]
		[GroupExclude(Tag.test)]
		public Group<ComponentTest> group_test3;

		public ProcTest()
		{
			void OnAdd(ent entity)
			{
				entity.Add(Tag.test2);
				entity.Remove(Tag.test);
				//Debug.Log($"{entity.id} ADDED");
			}
			group_test2.Add += OnAdd;
		}

		public void Tick()
		{
//			if (Input.GetKeyDown(KeyCode.Q))
//			{
//				this.Populate("GameObject");
//				foreach (ent entity in group_test)
//				{
//					entity.print($"{entity.id} ENTITY");
//				}
//				//	GameObject.Instantiate(StarterTest.gogo);
//			}

			if (Input.GetKeyDown(KeyCode.W))
			{
//				group_test.entities[0].Release();
				this.Populate("GameObject");

				//GameObject.Instantiate(StarterTest.gogo);
			}

			//	this.print($"{group_test.length} |  {group_test2.length} | {group_test3.length}");

			foreach (var entity in group_test)
			{
				if (Input.GetKeyDown(KeyCode.W))
				{
					//entity.Release();
					//	entity.Add(Tag.test);
					//this.Populate("GameObject");
					continue;
				}

				//	entity.print($"{entity.id} ENTITY");
			}

			// TWO VARIABLES
			// ACTIONS 
			// bit  took 3.329075400 seconds to complete over 4 iterations, averaging 0.832268850 seconds per call
			// Bool took 3.170722900 seconds to complete over 4 iterations, averaging 0.792680725 seconds per call
			// Profile TEST took 4.260658800 seconds to complete over 4 iterations, averaging 1.065164700 seconds per call
			/// Profile TEST took 3.580597000 seconds to complete over 4 iterations, averaging 0.895149250 seconds per call
			///			Profile TEST took 8.104906700 seconds to complete over 4 iterations, averaging 2.026226675 seconds per call
			//   Profile TEST took 3.620849600 seconds to complete over 4 iterations, averaging 0.905212400 seconds per call
			// Profile TEST took 4.252226500 seconds to complete over 4 iterations, averaging 1.063056625 seconds per call
			/// ! TWO VARIABLES
			/// ITERATOR
			/// bit 4.562600200 seconds to complete over 4 iterations, averaging 1.140650050 seconds per call		
			///	bool took 4.259352100 seconds to complete over 4 iterations, averaging 1.064838025 seconds per call  


			/// ! ONE VARIABLES
			/// bit  took 4.446575500 seconds to complete over 4 iterations, averaging 1.111643875 seconds per call
			/// bool took 4.237514200 seconds to complete over 4 iterations, averaging 1.059378550 seconds per call
			///
			///
			/// Profile TEST took 4.347294200 seconds to complete over 4 iterations, averaging 1.086823550 seconds per call
			///
			///
			///
			///
			///
			///
			///
			/// Profile TEST took 2.841452200 seconds to complete over 4 iterations, averaging 0.710363050 seconds per call
//			if (Input.GetKeyDown(KeyCode.B))
//			{
//				Profile.StartProfile("TEST");
//				for (int i = 0; i < 3000000; i++)
//
//				for (int j = 0; j < group_test.length; j++)
//				{
//					if (!RefEntity.statess[j]) continue;
//					var entity = group_test[j];
//				}
//				// group_test.Update();
//				//foreach (ent entity in group_test) { }
//
//				//	foreach (ent entity in group_test) { }
//				//group_test.Update();
//
//				//	var e   = group_test.entities;
//				//	var len = group_test.length;
////				for (int i = 0; i < 3000000; i++)
////				{
//////					for (int j = 0; j < group_test.length; j++)
//////					{
//////						var entity = group_test[j];
//////						if (!RefEntity.statess[entity]) continue;
//////					}
////
////					foreach (ent entity in group_test)
////					{
////					
////					}
////				}
//
//				Profile.EndProfile("TEST");
//				Profile.PrintResults();
//			}
		}

		static void TestValues(in ent entity) { }

		void TestValues2(in ent entity) { }
	}
}