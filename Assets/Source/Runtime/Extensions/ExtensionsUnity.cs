//  Project : ecs
// Contacts : Pix - ask@pixeye.games
//     Date : 3/10/2019 


using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace Pixeye
{
//	public static class ExtensionsUnity
//	{
//		public static int path_base = "base".GetHashCode();
//		static int hash_collider2d = typeof(Collider2D).GetHashCode();
//		static int hash_collider = typeof(Collider).GetHashCode();
//		static int hash_rigidbody = typeof(Rigidbody).GetHashCode();
//		static int hash_rigidbody2d = typeof(Rigidbody2D).GetHashCode();
//		static int hash_button = typeof(Button).GetHashCode();
//		static int hash_animator = typeof(Animator).GetHashCode();
//		static int hash_spriteRenderer = typeof(SpriteRenderer).GetHashCode();
//		static int hash_canvasgroup = typeof(CanvasGroup).GetHashCode();
//		static int hash_recttransform = typeof(RectTransform).GetHashCode();
//		static int hash_navmeshagent = typeof(NavMeshAgent).GetHashCode();
//		static int hash_linerenderer = typeof(LineRenderer).GetHashCode();
//		static int hash_audiosource = typeof(AudioSource).GetHashCode();
//
//		#region path
//
//		public static Collider2D collider2D(this ent entity, int path)
//		{
//			return (Collider2D) EntityReferences.storage[entity][path][hash_collider2d];
//		}
//
//		public static Collider collider(this ent entity, int path)
//		{
//			return (Collider) EntityReferences.storage[entity][path][hash_collider];
//		}
//
//		public static Rigidbody rigidbody(this ent entity, int path)
//		{
//			return (Rigidbody) EntityReferences.storage[entity][path][hash_rigidbody];
//		}
//
//		public static Rigidbody2D rigidbody2D(this ent entity, int path)
//		{
//			return (Rigidbody2D) EntityReferences.storage[entity][path][hash_rigidbody2d];
//		}
//
//		public static Button button(this ent entity, int path)
//		{
//			return (Button) EntityReferences.storage[entity][path][hash_button];
//		}
//
//		public static Animator animator(this ent entity, int path)
//		{
//			return (Animator) EntityReferences.storage[entity][path][hash_animator];
//		}
//
//		public static SpriteRenderer spriteRenderer(this ent entity, int path)
//		{
//			return (SpriteRenderer) EntityReferences.storage[entity][path][hash_spriteRenderer];
//		}
//
//		public static CanvasGroup canvasGroup(this ent entity, int path)
//		{
//			return (CanvasGroup) EntityReferences.storage[entity][path][hash_canvasgroup];
//		}
//
//		public static RectTransform rectTransform(this ent entity, int path)
//		{
//			return (RectTransform) EntityReferences.storage[entity][path][hash_recttransform];
//		}
//
//		public static NavMeshAgent navMeshAgent(this ent entity, int path)
//		{
//			return (NavMeshAgent) EntityReferences.storage[entity][path][hash_navmeshagent];
//		}
//
//		public static LineRenderer lineRenderer(this ent entity, int path)
//		{
//			return (LineRenderer) EntityReferences.storage[entity][path][hash_linerenderer];
//		}
//
//		public static AudioSource audioSource(this ent entity, int path)
//		{
//			return (AudioSource) EntityReferences.storage[entity][path][hash_audiosource];
//		}
//
//		#endregion
//
//		#region no path
//
//		public static Collider2D collider2D(this ent entity)
//    		{
//    			return (Collider2D) EntityReferences.storage[entity][path_base][hash_collider2d];
//    		}
//    
//    		public static Collider collider(this ent entity)
//    		{
//    			return (Collider) EntityReferences.storage[entity][path_base][hash_collider];
//    		}
//    
//    		public static Rigidbody rigidbody(this ent entity)
//    		{
//    			return (Rigidbody) EntityReferences.storage[entity][path_base][hash_rigidbody];
//    		}
//    
//    		public static Rigidbody2D rigidbody2D(this ent entity)
//    		{
//    			return (Rigidbody2D) EntityReferences.storage[entity][path_base][hash_rigidbody2d];
//    		}
//    
//    		public static Button button(this ent entity)
//    		{
//    			return (Button) EntityReferences.storage[entity][path_base][hash_button];
//    		}
//    
//    		public static Animator animator(this ent entity)
//    		{
//    			return (Animator) EntityReferences.storage[entity][path_base][hash_animator];
//    		}
//    
//    		public static SpriteRenderer spriteRenderer(this ent entity)
//    		{
//    			return (SpriteRenderer) EntityReferences.storage[entity][path_base][hash_spriteRenderer];
//    		}
//    
//    		public static CanvasGroup canvasGroup(this ent entity)
//    		{
//    			return (CanvasGroup) EntityReferences.storage[entity][path_base][hash_canvasgroup];
//    		}
//    
//    		public static RectTransform rectTransform(this ent entity)
//    		{
//    			return (RectTransform) EntityReferences.storage[entity][path_base][hash_recttransform];
//    		}
//    
//    		public static NavMeshAgent navMeshAgent(this ent entity)
//    		{
//    			return (NavMeshAgent) EntityReferences.storage[entity][path_base][hash_navmeshagent];
//    		}
//    
//    		public static LineRenderer lineRenderer(this ent entity)
//    		{
//    			return (LineRenderer) EntityReferences.storage[entity][path_base][hash_linerenderer];
//    		}
//    
//    		public static AudioSource audioSource(this ent entity)
//    		{
//    			return (AudioSource) EntityReferences.storage[entity][path_base][hash_audiosource];
//    		}
//
//		#endregion
//	}
}