using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Darts
{
    class XMLPersistence
    {

        public XMLPersistence()
        {

        }
        public void SaveData(Point dart1P1Position, Point dart2P1Position, Point dart3P1Position, Point dart1P2Position, Point dart2P2Position, Point dart3P2Position, int scoreP1, int scoreP2, String player1, String player2)
        {
            XmlDocument xml = new XmlDocument();
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            var data = xml.CreateElement("data");

            //Players
            var player1element = xml.CreateElement("player1");
            player1element.InnerText = player1;
            data.AppendChild(player1element);
            var player2element = xml.CreateElement("player2");
            player2element.InnerText = player2;
            data.AppendChild(player2element);

            //Dart of Player 1
            var element1P1 = xml.CreateElement("Dart1P1Position");
            var P1D1x = xml.CreateElement("X");
            P1D1x.InnerText = dart1P1Position.X.ToString();
            element1P1.AppendChild(P1D1x);
            var P1D1y = xml.CreateElement("Y");
            P1D1y.InnerText = dart1P1Position.Y.ToString();
            element1P1.AppendChild(P1D1y);
            data.AppendChild(element1P1);

            var element2P1 = xml.CreateElement("Dart2P1Position");
            var P1D2x = xml.CreateElement("X");
            P1D2x.InnerText = dart2P1Position.X.ToString();
            element2P1.AppendChild(P1D2x);
            var P1D2y = xml.CreateElement("Y");
            P1D2y.InnerText = dart2P1Position.Y.ToString();
            element2P1.AppendChild(P1D2y);
            data.AppendChild(element2P1);

            var element3P1 = xml.CreateElement("Dart3P1Position");
            var P1D3x = xml.CreateElement("X");
            P1D3x.InnerText = dart3P1Position.X.ToString();
            element3P1.AppendChild(P1D3x);
            var P1D3y = xml.CreateElement("Y");
            P1D3y.InnerText = dart3P1Position.Y.ToString();
            element3P1.AppendChild(P1D3y);
            data.AppendChild(element3P1);

            //Dart of Player 2
            var element1P2 = xml.CreateElement("Dart1P2Position");
            var P2D1x = xml.CreateElement("X");
            P2D1x.InnerText = dart1P2Position.X.ToString();
            element1P2.AppendChild(P2D1x);
            var P2D1y = xml.CreateElement("Y");
            P2D1y.InnerText = dart1P2Position.Y.ToString();
            element1P2.AppendChild(P2D1y);
            data.AppendChild(element1P2);

            var element2P2 = xml.CreateElement("Dart2P2Position");
            var P2D2x = xml.CreateElement("X");
            P2D2x.InnerText = dart2P2Position.X.ToString();
            element2P2.AppendChild(P2D2x);
            var P2D2y = xml.CreateElement("Y");
            P2D2y.InnerText = dart2P2Position.Y.ToString();
            element2P2.AppendChild(P2D2y);
            data.AppendChild(element2P2);

            var element3P2 = xml.CreateElement("Dart3P2Position");
            var P2D3x = xml.CreateElement("X");
            P2D3x.InnerText = dart3P2Position.X.ToString();
            element3P2.AppendChild(P2D3x);
            var P2D3y = xml.CreateElement("Y");
            P2D3y.InnerText = dart3P2Position.Y.ToString();
            element3P2.AppendChild(P2D3y);
            data.AppendChild(element3P2);

            //score of player 1
            var scorep1 = xml.CreateElement("ScoreP1");
            scorep1.InnerText = scoreP1.ToString();
            data.AppendChild(scorep1);

            //score of player 2
            var scorep2 = xml.CreateElement("ScoreP2");
            scorep2.InnerText = scoreP2.ToString();
            data.AppendChild(scorep2);

            xml.AppendChild(data);


            using (XmlWriter writer = XmlWriter.Create("../../save.xml", settings))
            {
                xml.WriteTo(writer);
            }
        }

        public State GetState()
        {
            State state = new State();

            using (XmlReader reader = XmlReader.Create("../../save.xml"))
            {
                reader.ReadToDescendant("player1");
                if ((reader.Name == "player1"))
                {
                    reader.Read();
                    state.player1 = reader.Value;
                }
                reader.ReadToFollowing("player2");
                if ((reader.Name == "player2"))
                {
                    reader.Read();
                    state.player2 = reader.Value;
                }
                reader.ReadToFollowing("Dart1P1Position");
                if ((reader.Name == "Dart1P1Position"))
                {
                    reader.ReadToDescendant("X");
                    reader.Read();
                    state.dart1P1Position.X = int.Parse(reader.Value);

                    reader.ReadToFollowing("Y");
                    reader.Read();
                    state.dart1P1Position.Y = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("Dart2P1Position");
                if ((reader.Name == "Dart2P1Position"))
                {
                    reader.ReadToDescendant("X");
                    reader.Read();
                    state.dart2P1Position.X = int.Parse(reader.Value);

                    reader.ReadToFollowing("Y");
                    reader.Read();
                    state.dart2P1Position.Y = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("Dart3P1Position");
                if ((reader.Name == "Dart3P1Position"))
                {
                    reader.ReadToDescendant("X");
                    reader.Read();
                    state.dart3P1Position.X = int.Parse(reader.Value);

                    reader.ReadToFollowing("Y");
                    reader.Read();
                    state.dart3P1Position.Y = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("Dart1P2Position");
                if ((reader.Name == "Dart1P2Position"))
                {
                    reader.ReadToDescendant("X");
                    reader.Read();
                    state.dart1P2Position.X = int.Parse(reader.Value);

                    reader.ReadToFollowing("Y");
                    reader.Read();
                    state.dart1P2Position.Y = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("Dart2P2Position");
                if ((reader.Name == "Dart2P2Position"))
                {
                    reader.ReadToDescendant("X");
                    reader.Read();
                    state.dart2P2Position.X = int.Parse(reader.Value);

                    reader.ReadToFollowing("Y");
                    reader.Read();
                    state.dart2P2Position.Y = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("Dart3P2Position");
                if ((reader.Name == "Dart3P2Position"))
                {
                    reader.ReadToDescendant("X");
                    reader.Read();
                    state.dart3P2Position.X = int.Parse(reader.Value);

                    reader.ReadToFollowing("Y");
                    reader.Read();
                    state.dart3P2Position.Y = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("ScoreP1");
                if ((reader.Name == "ScoreP1"))
                {
                    reader.Read();
                    state.scoreP1 = int.Parse(reader.Value);
                }
                reader.ReadToFollowing("ScoreP2");
                if ((reader.Name == "ScoreP2"))
                {
                    reader.Read();
                    state.scoreP2 = int.Parse(reader.Value);
                }
            }
            return state;

        }
    }
}
