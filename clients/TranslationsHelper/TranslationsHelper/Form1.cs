using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TranslationsHelper
{
    public partial class Form1 : Form
    {
        private Dictionary<string, object> translations;
        private Dictionary<string, object> mkTranslations;
        private List<string> activeNodePath = [];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = txtPathToTranslations.Text;
            string enFileName = Path.Combine(filePath, "en.json");
            string mkFileName = Path.Combine(filePath, "mk.json");

            if (File.Exists(enFileName))
            {
                string json = await File.ReadAllTextAsync(enFileName);
                translations = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                PopulateTreeView(treeView.Nodes, translations);
            }

            if (File.Exists(mkFileName))
            {
                string json = await File.ReadAllTextAsync(mkFileName);
                mkTranslations = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            }
        }

        private void PopulateTreeView(TreeNodeCollection parentNodes, Dictionary<string, object> data)
        {
            foreach (var kvp in data)
            {
                TreeNode node = new TreeNode(kvp.Key);

                if (kvp.Value is JObject obj)
                    PopulateTreeView(node.Nodes, obj.ToObject<Dictionary<string, object>>());
                else if (kvp.Value is string)
                {
                    node.Tag = kvp.Value;
                }

                parentNodes.Add(node);
            }

            treeView.ExpandAll();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            activeNodePath = [];
            string nodeTitle = string.Empty;
            TreeNode? trackingNode = e.Node;
            while (trackingNode != null)
            {
                activeNodePath.Add(trackingNode.Text);
                nodeTitle = nodeTitle != string.Empty ? $"{trackingNode.Text}.{nodeTitle}" : $"{trackingNode.Text}";
                trackingNode = trackingNode.Parent;
            }

            activeNodePath.Reverse();
            if (e.Node.Tag != null)
            {
                txtEnTranslations.Text = e.Node.Tag.ToString();
            }

            lblNodeTitle.Text = nodeTitle;
            Dictionary<string, object> activeValue = mkTranslations;
            string lastKey = string.Empty;
            foreach (var item in activeNodePath)
            {
                lastKey = item;
                if (activeValue[item] is string)
                {
                    txtMkTranslations.Text = activeValue[item].ToString();
                    continue;
                }

                if (mkTranslations[item] == null)
                {
                    continue;
                }

                activeValue = (Dictionary<string, object>)mkTranslations[item];
            }
        }
    }
}
