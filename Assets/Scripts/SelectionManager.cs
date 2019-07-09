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
    public Transform start;
    public Transform end;

    public Transform target;
    public float speed;
    Vector3 myVector;

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
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
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
                        //myVector = new Vector3(5f, -2.5f, 3f);
                        //float step = speed * Time.deltaTime;
                        //float dist = Vector3.Distance(selectionRenderer.transform.position, myVector);
                        //selectionRenderer.material = highlightMaterial;
                        //print(selectionRenderer.transform.position);
                        //selectionRenderer.transform.position = Vector3.MoveTowards(selectionRenderer.transform.position, myVector, (float) 1.0);


                        //selectionRenderer.transform.Translate(0, 0, (float)0.5 * Time.deltaTime);
                    }
                    if (selection.CompareTag(Tag2))
                    {
                        myVector = new Vector3(263.01f, 5.0f, 84.78f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag3))
                    {
                        myVector = new Vector3(262.5f, 5.1f, 84.78f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag4))
                    {
                        myVector = new Vector3(263.3f, 5.3f, 84.4f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag5))
                    {
                        myVector = new Vector3(263.3f, 5.3f, 84.4f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag6))
                    {
                        myVector = new Vector3(263.3f, 5.3f, 84.4f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag7))
                    {
                        myVector = new Vector3(263.3f, 5.3f, 84.4f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag8))
                    {
                        myVector = new Vector3(263.3f, 5.3f, 84.4f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                    if (selection.CompareTag(Tag9))
                    {
                        myVector = new Vector3(263.3f, 5.3f, 84.4f);
                        selectionRenderer.material = highlightMaterial;
                        selectionRenderer.transform.position = Vector3.Lerp(selectionRenderer.transform.position, myVector, 1);
                    }
                }
                _selection = selection;
                selectionRenderer.material = defaultMaterial;
            }
        }
    }
}
