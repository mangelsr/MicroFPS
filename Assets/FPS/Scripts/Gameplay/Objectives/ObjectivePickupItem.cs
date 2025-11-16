using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class ObjectivePickupItem : Objective
    {
        [Tooltip("Item to pickup to complete the objective")]
        public GameObject ItemToPickup;
        [SerializeField] bool isKey = false; 

        protected override void Start()
        {
            base.Start();

            EventManager.AddListener<PickupEvent>(OnPickupEvent);
        }

        void OnPickupEvent(PickupEvent evt)
        {
            if (IsCompleted || ItemToPickup != evt.Pickup)
                return;

            // this will trigger the objective completion
            // it works even if the player can't pickup the item (i.e. objective pickup healthpack while at full heath)
            CompleteObjective(string.Empty, string.Empty, "Objective complete : " + Title);

            if (gameObject)
            {
                if(isKey)
                {
                    Invoke("DoDestroy", 4.2f);
                    this.gameObject.GetComponent<Collider>().enabled = false;
                    EventManager.RemoveListener<PickupEvent>(OnPickupEvent);
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }

        void DoDestroy()
        {
            Destroy(gameObject);
        }

        void OnDestroy()
        {
            if(isKey == false) EventManager.RemoveListener<PickupEvent>(OnPickupEvent);
        }
    }
}