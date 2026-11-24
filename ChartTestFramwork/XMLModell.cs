using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChartTestFramwork
{
    internal class XMLModell : IModelLocalData 
    {

        public IViewECG ViewEKG { private get; set; }
        public IModelECGDevice ModelECGDevice { private get; set; }
        public IControllerECG ControllerECG { private get; set; }

        public List<double> get24hData()
        {
            throw new NotImplementedException();
        }

        public void saveLiveData(ECGValue aktuellerWert)
        {
            string path = "EKG.xml";

            XDocument doc = System.IO.File.Exists(path)
                ? XDocument.Load(path)
                : new XDocument(new XElement("EKG"));

            doc.Root.Add(new XElement("Messwert",
                new XElement("TimeStamp", aktuellerWert.TimeStamp),
                new XElement("Value", aktuellerWert.Value)));

            doc.Save(path);
        }

        public void set24hData(ECGValue aktuellerWert)
        {
            throw new NotImplementedException();
        }
    }
}

