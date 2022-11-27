using System;
using System.Text;
using System.Net;
using System.Xml;

					
public class Program
{
	public static void Main()
	{
		string url = "https://www.bcb.gov.br/api/feed/app/normativos/normativos?ano=2021";
		
		StringBuilder sb = new StringBuilder("");

            string id = string.Empty, title = string.Empty, updated = string.Empty, link = string.Empty, content = string.Empty;
            try
            {
                if (url != string.Empty)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(url);
                    XmlNodeList nodeList = doc.GetElementsByTagName("entry");
                    if (doc.HasChildNodes)
                    {
                        int i = 1;
                        foreach (XmlNode node in nodeList)
                        {
                            if (node.HasChildNodes)
                            {
                                XmlNodeList subNodeList = node.ChildNodes;
                                foreach (XmlNode subNode in subNodeList)
                                {
                                    switch (subNode.Name.ToLower())
                                    {
                                        case "id":
                                            id = subNode.InnerText;
                                            break;
                                        case "title":
                                            title = subNode.InnerText;
                                            break;
                                        case "updated":
                                            updated = subNode.InnerText;
                                            break;
                                        case "link":
                                            link = subNode.InnerText;
                                            break;
										case "content":
                                            content = subNode.InnerText;
                                            break;
                                    }
                                    if (title != string.Empty && link != string.Empty && updated != string.Empty)
                                        break;
                                }

                                if (i > 15)
                                    break;

                                i++;
                                sb.Append(string.Format("<li>·{2} <a href='{0}' target='_blank' rel='nofollow' title='{1}'>{1}</a></li>", link, title, updated));
                            }

                            Console.WriteLine("===================================================================");
							Console.WriteLine(id);
                            Console.WriteLine(title);
                            Console.WriteLine(updated);
                            Console.WriteLine(link);
							Console.WriteLine(content);
							Console.WriteLine("===================================================================");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sb.Append(ex.Message.ToString());
            }
            
	}
	
	
}
