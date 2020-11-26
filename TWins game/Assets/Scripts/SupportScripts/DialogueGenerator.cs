using UnityEngine;
using System.Collections;
using System.IO;
using System.Xml;

public class DialogueGenerator : MonoBehaviour
{

	public string fileName = "Example"; // имя генерируемого файла (без разрешения)
	public string folder = "Dialogues"; // подпапка в Resources, для записи
	public DialogueItem[] node;

	public void Generate()
	{
		string path = Application.dataPath + "/Resources/" + folder + "/" + fileName + ".xml";

		XmlElement DialogueElement;
		XmlElement OptionElement;
		XmlAttribute attribute;

		XmlDocument xmlDoc = new XmlDocument();
		for (int j = 0; j < node.Length; j++)
		{
			DialogueElement = xmlDoc.CreateElement("node");

			createDialogueItem(DialogueElement, node[j]);

			for (int i = 0; i < node[j].Options.Length; i++)
			{
				OptionElement = xmlDoc.CreateElement("Options");

				createOptionItem(OptionElement, node[j].Options[i]);

				DialogueElement.AppendChild(OptionElement);
			}

			xmlDoc.AppendChild(DialogueElement);
		}

		xmlDoc.Save(path);
		Debug.Log(this + " Создан XML файл диалога [ " + fileName + " ] по адресу: " + path);
	}

	public void createDialogueItem(XmlElement element, DialogueItem dialogue)
	{
		element.SetAttribute("DialogueIndex", dialogue.DialogueIndex.ToString());

		element.SetAttribute("EnergyMin", dialogue.EnergyMin.ToString());
		element.SetAttribute("EnergyMax", dialogue.EnergyMax.ToString());

		element.SetAttribute("FaithMin", dialogue.FaithMin.ToString());
		element.SetAttribute("FaithMax", dialogue.FaithMax.ToString());

		element.SetAttribute("SatietyMin", dialogue.SatietyMin.ToString());
		element.SetAttribute("SatietyMax", dialogue.SatietyMax.ToString());

		element.SetAttribute("Message", dialogue.Message);
	}

	public void createOptionItem(XmlElement element, OptionItem option)
	{
		element.SetAttribute("Text", option.Text);
		element.SetAttribute("Answer", option.Answer);

		element.SetAttribute("EnergyChange", option.EnergyChange.ToString());
		element.SetAttribute("FaithChange", option.FaithChange.ToString());
		element.SetAttribute("SatietyChange", option.SatietyChange.ToString());
		element.SetAttribute("NextDialogue", option.NextDialogue.ToString());
	}
}
