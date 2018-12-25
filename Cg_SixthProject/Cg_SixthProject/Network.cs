using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Cg_SixthProject
{
    public class Network
    {
        public IList<Entity> entities = new List<Entity>();
        public IList<Line> lines = new List<Line>();
        //public IList<Line> constLines = new List<Line>();
        int _tagged_node = -1;
        public Network(List<Entity> entities) => this.entities = entities;
        public void AddNode(StyleObject style, string value, int id, int x, int y, int width, int height) 
            => entities.Add( new Entity(style, value, entities.Count, x, y, width, height, new Rectangle(x,y,width,height)));
        public void DrawFigure() => Drawing.DrawNetwork(this);
        public Entity e1 { get; set; }
        public Entity e2 { get; set; }

        public Network() { }
        public Entity SeacrhNode(int x, int y) => FoundNode(x,y);

        public string TextToTexbox()
        {
            string str = "";
            for (int i = 0; i < entities.Count; i++)
                str += entities[i].ToTextbox();
            return str;
        }
        private Entity FoundNode(int x, int y)
        {
            for (int i = 0; i < entities.Count; i++)
                if (entities[i].XCoordinates < x && x < entities[i].XCoordinates + entities[i].Width &&
                    entities[i].YCoordinates < y && y < entities[i].YCoordinates + entities[i].Height )
                    return entities[i];
            return null;
        }

        public void SelectNode(int x, int y)
        {
            for (int i = 0; i < entities.Count; i++)
                if (entities[i].XCoordinates < x && x < entities[i].XCoordinates + entities[i].Width &&
                    entities[i].YCoordinates < y && y < entities[i].YCoordinates + entities[i].Height)
                    entities[i].Select = !entities[i].Select; 
        }

        public int CountSelectNode()
        {
            bool fir = false;
            int count = 0;
            for (int i = 0; i < entities.Count; i++)
                if (entities[i].Select) {
                    count++;
                    if (!fir)
                    {
                        e1 = entities[i];
                        fir = true;
                    }
                    else
                        e2 = entities[i];
                }
            return count;
        }

        public void NewXY(int x_old, int y_old, int x_new, int y_new)
        {
            Entity e = FoundNode(x_old, y_old);
            if (e == null)
                return;
            e.XCoordinates = x_new;
            e.YCoordinates = y_new;
            Rectangle r = new Rectangle(x_new, y_new, e.Width, e.Height);
            e.r = r;
        }
       

        public void DeleteNetwork()
        {
            entities.Clear();
            lines.Clear();
        }

        public void DeleteNode(int x, int y)
        {
            Entity node = FoundNode(x, y);
            if (node == null)
                return;
            for (int i = 0; i < entities.Count; i++)
            {
                List<Line> _lines = new List<Line>();

                if (entities[i].list != null)
                {
                    for (int j = 0; j < entities[i].list.Count; j++)
                    {
                        Line line = entities[i].list[j];

                        if (line.Entity_1 != node.Id && node.start)
                        {
                            if (line.Id > node.Id)
                                line.Id--;
                            _lines.Add(line);
                        }
                        else if (line.Entity_2 != node.Id)
                        {
                            if (line.Id > node.Id)
                                line.Id--;
                            _lines.Add(line);
                        }
                        else
                        {
                            int delete = line.Id;
                            if (Search(line) != -1)
                            {
                                lines.Remove(lines[Search(line)]);
                                lines.Remove(lines[Search(line)]);
                            }
                            for (int m = 0; m < lines.Count; m++)
                                if (lines[m].Id > delete)
                                    lines[m].Id --;
                            for (int o = 0; o < entities.Count; o++)
                                for (int u = 0; u < entities[o].list.Count; u++)
                                    if (entities[o].list[u].Id > delete)
                                        entities[o].list[u].Id--;
                        }
                    }
                    entities[i].list = _lines;
                }
            }
            entities.Remove(node);
            for (int i = node.Id; i < entities.Count; i++)
                entities[i].Id--;
        }
        public int Search(Line line)
        {
            for (int i = 0; i < lines.Count; i++)
                if (lines[i].Id == line.Id)
                    return i;
            return -1;
        }

        public void SelectEdge(int x, int y)
        {
            Entity node = FoundNode(x, y);
            if (node != null)
            {
                if (_tagged_node != -1)
                {
                    _tagged_node = node.Id;
                    entities[node.Id].Select = true;
                }
                else
                {
                    for (int i = 0; i < entities[_tagged_node].list.Count; i++)
                        if (entities[_tagged_node].list[i].Entity_2 == node.Id)
                        {
                            entities[_tagged_node].list[i].Select = !entities[_tagged_node].list[i].Select;
                            entities[node.Id].list[i].Select = !entities[node.Id].list[i].Select;
                        }
                    entities[_tagged_node].Select = false;
                    _tagged_node = -1;
                }
            }
        }

        
        public void AddLine(StyleLine style)
        {
            if(CountSelectNode() ==2)
            {
                int i1 = -1, i2 = -1;
                for (int i = 0; i < entities.Count; i++)
                    if (entities[i].Select && i1 == -1)
                        i1 = i;
                    else if (entities[i].Select)
                        i2 = i;
                int ind = lines.Count;
                e1.list.Add(new Line(style, null, entities[i1].Id, entities[i2].Id, ind));
                e1.start = true;
                e2.list.Add(new Line(style, null, entities[i1].Id, entities[i2].Id, ind));
                lines.Add(new Line(style, null, entities[i1].Id, entities[i2].Id, ind));
                lines.Add(new Line(style, null, entities[i2].Id, entities[i1].Id, ind));
                entities[i1].Select = false;
                entities[i2].Select = false;
                e1 = null;
                e2 = null;
                Clean();
            }
            
        }
        private void Clean()
        {
            for (int i = 0; i < entities.Count; i++)
                entities[i].Select = false;
        }
        
        public void DeleteLine()
        {
            if (CountSelectNode() == 2)
            {
                int i1 = -1, i2 = -1;
                for (int i = 0; i < entities.Count; i++)
                    if (entities[i].Select && i1 == -1)
                        i1 = i;
                    else
                        i2 = i;
                int index1 = 0;
                int index2 = 0;
                for (int j = 0; j < lines.Count; j++)
                    if (lines[j].Entity_1 == i1 )
                        index1 = j;
                    else if(lines[j].Entity_1 == i2)
                        index2 = j;
               if (Lookfor(index1,index2,i1) !=-1)
                    entities[i1].list.RemoveAt(Lookfor(index1,index2,i1));
                if (Lookfor(index2,index1,i2) != -1)
                    entities[i2].list.RemoveAt(Lookfor(index2,index1,i2));
                lines.Remove(lines[Math.Max(index1,index2)]);
                lines.Remove(lines[Math.Min(index1, index2)]);
                entities[i1].Select = false;
                entities[i2].Select = false;
            }
        }
        private int Lookfor(int er, int er2,int i)
        {
            for (int j = 0; j < entities[i].list.Count; j++)
                if (entities[i].list[j].Id == lines[er].Id)
                    return j;
                else if (entities[i].list[j].Id == lines[er2].Id)
                    return j;
             return -1;
        }
       
        

        public void MoveNode(int x, int y)
        {
            if (_tagged_node == -1)
            {
                Entity node = FoundNode(x, y);
                if (node != null)
                {
                    _tagged_node = node.Id;
                    entities[node.Id].Select = true;
                }
            }
            else
            {
                entities[_tagged_node].XCoordinates = x;
                entities[_tagged_node].YCoordinates = y;
                entities[_tagged_node].Select = false;
                _tagged_node = -1;
            }
        }
    }
}
