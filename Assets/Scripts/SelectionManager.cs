using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string Tag1 = "ToolOne";
    [SerializeField] private string Tag2 = "ToolTwo";
    [SerializeField] private string Tag3 = "ToolThree";
    [SerializeField] private string Tag4 = "Dish";
    [SerializeField] private string Tag5 = "Drill";
    [SerializeField] private string Tag6 = "ScrewOne";
    [SerializeField] private string Tag7 = "ScrewTwo";
    [SerializeField] private string Tag8 = "ScrewThree";
    [SerializeField] private string Tag9 = "ScrewFour";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;

    public Transform target;
    public float speed;

    private void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(Tag1) || selection.CompareTag(Tag2) || selection.CompareTag(Tag3) ||
                selection.CompareTag(Tag4) || selection.CompareTag(Tag5) || selection.CompareTag(Tag6) ||
                selection.CompareTag(Tag7) || selection.CompareTag(Tag8) || selection.CompareTag(Tag9))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    if (selection.CompareTag(Tag1))
                    {
                        float step = speed * Time.deltaTime;
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.Translate(0, 0, (float)0.5 * Time.deltaTime);
                    }
                    if (selection.CompareTag(Tag2))
                    {

                    }
                    if (selection.CompareTag(Tag3))
                    {

                    }
                    if (selection.CompareTag(Tag4))
                    {

                    }
                    if (selection.CompareTag(Tag5))
                    {

                    }
                    if (selection.CompareTag(Tag6))
                    {

                    }
                    if (selection.CompareTag(Tag7))
                    {

                    }
                    if (selection.CompareTag(Tag8))
                    {

                    }
                    if (selection.CompareTag(Tag9))
                    {

                    }
                }
                _selection = selection;
            }
        }
    }
}
