//  Project : ecs
// Contacts : Pix - ask@pixeye.games
//     Date : 3/10/2019 

using UnityEngine;
 

namespace Pixeye.Framework
{
//	public static class HelperUnity
//	{
//
////		static int hash_collider2dBox = typeof(BoxCollider2D).GetHashCode();
////		static int hash_collider2dCircle = typeof(CircleCollider2D).GetHashCode();
////		static int hash_collider2d = typeof(Collider2D).GetHashCode();
////		static int hash_colliderBox = typeof(BoxCollider).GetHashCode();
////		static int hash_colliderSphere = typeof(SphereCollider).GetHashCode();
////		static int hash_collider = typeof(Collider).GetHashCode();
////		static int hash_rigidbody = typeof(Rigidbody).GetHashCode();
////		static int hash_rigidbody2d = typeof(Rigidbody2D).GetHashCode();
////		static int hash_button = typeof(Button).GetHashCode();
////		static int hash_animator = typeof(Animator).GetHashCode();
////		static int hash_spriteRenderer = typeof(SpriteRenderer).GetHashCode();
////		static int hash_canvasgroup = typeof(CanvasGroup).GetHashCode();
////		static int hash_recttransform = typeof(RectTransform).GetHashCode();
////		static int hash_navmeshagent = typeof(NavMeshAgent).GetHashCode();
////		static int hash_linerenderer = typeof(LineRenderer).GetHashCode();
////		static int hash_audiosource = typeof(AudioSource).GetHashCode();
////		static int hash_textmesh = typeof(TextMesh).GetHashCode();
//
// 
//
//		public static SpriteRenderer spriteRenderer(this in ent entity)
//		{
//			return entity.transform.GetComponent<SpriteRenderer>();
//		}
//
////		public static TextMesh textMesh(this in ent entity, int path)
////		{
////			return (TextMesh) HelperEntity.cacheMono[entity][path][hash_textmesh];
////		}
////
////		public static BoxCollider boxCollider(this in ent entity, int path)
////		{
////			return (BoxCollider) HelperEntity.cacheMono[entity][path][hash_colliderBox];
////		}
////
////		public static SphereCollider sphereCollider(this in ent entity, int path)
////		{
////			return (SphereCollider) HelperEntity.cacheMono[entity][path][hash_colliderSphere];
////		}
////
////		public static CircleCollider2D circleCollider2D(this in ent entity, int path)
////		{
////			return (CircleCollider2D) HelperEntity.cacheMono[entity][path][hash_collider2dCircle];
////		}
//
////		public static BoxCollider2D boxCollider2D(this in ent entity, int path)
////		{
////			return (BoxCollider2D) HelperEntity.cacheMono[entity][path][hash_collider2dBox];
////		}
////
////		public static Collider2D collider2D(this in ent entity, int path)
////		{
////			return (Collider2D) HelperEntity.cacheMono[entity][path][hash_collider2d];
////		}
////
////		public static Collider collider(this in ent entity, int path)
////		{
////			return (Collider) HelperEntity.cacheMono[entity][path][hash_collider];
////		}
////
////		public static Rigidbody rigidbody(this in ent entity, int path)
////		{
////			return (Rigidbody) HelperEntity.cacheMono[entity][path][hash_rigidbody];
////		}
////
////		public static Rigidbody2D rigidbody2D(this in ent entity, int path)
////		{
////			return (Rigidbody2D) HelperEntity.cacheMono[entity][path][hash_rigidbody2d];
////		}
////
////		public static Button button(this in ent entity, int path)
////		{
////			return (Button) HelperEntity.cacheMono[entity][path][hash_button];
////		}
////
////		public static Animator animator(this in ent entity, int path)
////		{
////			return (Animator) HelperEntity.cacheMono[entity][path][hash_animator];
////		}
////
////		public static SpriteRenderer spriteRenderer(this in ent entity, int path)
////		{
////			return (SpriteRenderer) HelperEntity.cacheMono[entity][path][hash_spriteRenderer];
////		}
////
////		public static CanvasGroup canvasGroup(this in ent entity, int path)
////		{
////			return (CanvasGroup) HelperEntity.cacheMono[entity][path][hash_canvasgroup];
////		}
////
////		public static RectTransform rectTransform(this in ent entity, int path)
////		{
////			return (RectTransform) HelperEntity.cacheMono[entity][path][hash_recttransform];
////		}
////
////		public static NavMeshAgent navMeshAgent(this in ent entity, int path)
////		{
////			return (NavMeshAgent) HelperEntity.cacheMono[entity][path][hash_navmeshagent];
////		}
////
////		public static LineRenderer lineRenderer(this in ent entity, int path)
////		{
////			return (LineRenderer) HelperEntity.cacheMono[entity][path][hash_linerenderer];
////		}
////
////		public static AudioSource audioSource(this in ent entity, int path)
////		{
////			return (AudioSource) HelperEntity.cacheMono[entity][path][hash_audiosource];
////		}
////
////		#endregion
////
////		#region no path
////
////		public static TextMesh textMesh(this in ent entity)
////		{
////			return (TextMesh) HelperEntity.cacheMono[entity][HelperEntity.self][hash_textmesh];
////		}
////
////		public static BoxCollider boxCollider(this in ent entity)
////		{
////			return (BoxCollider) HelperEntity.cacheMono[entity][HelperEntity.self][hash_colliderBox];
////		}
////
////		public static SphereCollider sphereCollider(this in ent entity)
////		{
////			return (SphereCollider) HelperEntity.cacheMono[entity][HelperEntity.self][hash_colliderSphere];
////		}
////
////		public static CircleCollider2D circleCollider2D(this in ent entity)
////		{
////			return (CircleCollider2D) HelperEntity.cacheMono[entity][HelperEntity.self][hash_collider2dCircle];
////		}
////
////		public static BoxCollider2D boxCollider2D(this in ent entity)
////		{
////			return (BoxCollider2D) HelperEntity.cacheMono[entity][HelperEntity.self][hash_collider2dBox];
////		}
////
////		public static Collider2D collider2D(this in ent entity)
////		{
////			return (Collider2D) HelperEntity.cacheMono[entity][HelperEntity.self][hash_collider2d];
////		}
////
////		public static Collider collider(this in ent entity)
////		{
////			return (Collider) HelperEntity.cacheMono[entity][HelperEntity.self][hash_collider];
////		}
////
////		public static Rigidbody rigidbody(this in ent entity)
////		{
////			return (Rigidbody) HelperEntity.cacheMono[entity][HelperEntity.self][hash_rigidbody];
////		}
////
////		public static Rigidbody2D rigidbody2D(this in ent entity)
////		{
////			return (Rigidbody2D) HelperEntity.cacheMono[entity][HelperEntity.self][hash_rigidbody2d];
////		}
////
////		public static Button button(this in ent entity)
////		{
////			return (Button) HelperEntity.cacheMono[entity][HelperEntity.self][hash_button];
////		}
////
////		public static Animator animator(this in ent entity)
////		{
////			return (Animator) HelperEntity.cacheMono[entity][HelperEntity.self][hash_animator];
////		}
////
////		public static SpriteRenderer spriteRenderer(this in ent entity)
////		{
////			return (SpriteRenderer) HelperEntity.cacheMono[entity][HelperEntity.self][hash_spriteRenderer];
////		}
////
////		public static CanvasGroup canvasGroup(this in ent entity)
////		{
////			return (CanvasGroup) HelperEntity.cacheMono[entity][HelperEntity.self][hash_canvasgroup];
////		}
////
////		public static RectTransform rectTransform(this in ent entity)
////		{
////			return (RectTransform) HelperEntity.cacheMono[entity][HelperEntity.self][hash_recttransform];
////		}
////
////		public static NavMeshAgent navMeshAgent(this in ent entity)
////		{
////			return (NavMeshAgent) HelperEntity.cacheMono[entity][HelperEntity.self][hash_navmeshagent];
////		}
////
////		public static LineRenderer lineRenderer(this in ent entity)
////		{
////			return (LineRenderer) HelperEntity.cacheMono[entity][HelperEntity.self][hash_linerenderer];
////		}
////
////		public static AudioSource audioSource(this in ent entity)
////		{
////			return (AudioSource) HelperEntity.cacheMono[entity][HelperEntity.self][hash_audiosource];
////		}
////
////		#endregion
//
//	}
}