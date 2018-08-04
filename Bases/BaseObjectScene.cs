using UnityEngine;

namespace Base
{
    public abstract class BaseObjectScene : MonoBehaviour
    {
        private int _layer;
        private bool _isVisible;

        public Rigidbody TheRigidbody { get; private set; }

        private void AskLayer(Transform obj, int layer)
        {
            obj.gameObject.layer = layer;
            if (obj.childCount > 0)
            {
                foreach (Transform child in obj)
                {
                    AskLayer(child, layer);
                }
            }
        }

        protected virtual void Awake()
        {
            Layer = gameObject.layer;
            TheRigidbody = GetComponent<Rigidbody>();
        }

        public int Layer
        {
            get
            {
                return _layer;
            }

            set
            {
                _layer = value;
                AskLayer(transform, value);
            }
        }

        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                var tempRenderer = gameObject.GetComponent<Renderer>();
                if (tempRenderer)
                    tempRenderer.enabled = _isVisible;
                if (transform.childCount <= 0) return;
                foreach (Transform d in transform)
                {
                    tempRenderer = d.gameObject.GetComponent<Renderer>();
                    if (tempRenderer)
                        tempRenderer.enabled = _isVisible;
                }
            }
        }
    }
}