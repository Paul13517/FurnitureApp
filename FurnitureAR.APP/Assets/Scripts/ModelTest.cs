using S123.Models.Project;
using S123.Models.Tree;
using UnityEngine;

public class ModelTest : MonoBehaviour
{
    public int ModelId = 357278; 

   private async void Start()
   {
       Project project = await Project.Get(await Directory.Get(ModelId));
       ProjectController controller = gameObject.AddComponent<ProjectController>();
       controller.Data = project;
       await controller.Initialize();
    }
}
