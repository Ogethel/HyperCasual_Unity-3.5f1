using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
	public GameAction imageAction;
	public FloatData data;
	private Image imageComponent;
	private void Start ()
	{
		imageAction.action = UpdateImageHandler;
		imageComponent = GetComponent<Image>();
	}

	public void UpdateImageHandler()
	{
		imageComponent.fillAmount = data.value;
	}
	
	public void UpdateImageComponent(float amount)
	{
		imageComponent.fillAmount += amount;
	}
	
	public void UpdateImageComponent(FloatData dataObj)
	{
		imageComponent.fillAmount = dataObj.value;
	}
}