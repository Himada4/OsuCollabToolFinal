using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsuCollabTool.CoreClasses
{
    class MapDataExtractor
    {
        string MapDir = "";
        public static int DataRows = 2;
        public MapDataExtractor(string MapDirIn)
        {
            MapDir = MapDirIn;
        }


        // Specialised output
        public string[,] GetGeneral()
        {
            var Gen = new General(MapDir);

            return Gen.ReadDataFormatted(Gen.GetRawData());
        }
        public List<string> GetEditor()
        {
            var Edi = new Editor(MapDir);
            return Edi.GetRawData();
        }
        public string[,] GetMetadata()
        {
            var Met = new Metadata(MapDir);
            return Met.ReadDataFormatted((Met.GetRawData()));
        }
        public string[,] GetDiff()
        {
            var Diff = new Difficulty(MapDir);
            return Diff.ReadDataFormatted(Diff.GetRawData());
        }
        public List<string> GetEvents()
        {
            var Eve = new Events(MapDir);
            return Eve.GetRawData();
        }
        
        
        public List<string> GetColour()
        {
            var Col = new Colours(MapDir);
            return Col.GetRawData();
        }


        //string output
        public List<string> GetGeneralString()
        {
            var Gen = new General(MapDir);

            return Gen.GetRawData();
        }
        public List<string> GetEditorString()
        {
            var Edi = new Editor(MapDir);
            return Edi.GetRawData();
        }
        public List<string> GetMetadataString()
        {
            var Met = new Metadata(MapDir);
            return Met.GetRawData();
        }
        public List<string> GetDiffString()
        {
            var Diff = new Difficulty(MapDir);
            return Diff.GetRawData();
        }
        public List<string> GetEventsString()
        {
            var Eve = new Events(MapDir);
            return Eve.GetRawData();
        }
        public List<string> GetTimingPString()
        {
            var TiP = new TimingPoints(MapDir);
            return TiP.GetRawData();
        }
        public List<string> GetHitObjString()
        {
            var HiT = new HitObjects(MapDir);
            return HiT.GetRawData();
        }
        public List<string> GetColourString()
        {
            var Col = new Colours(MapDir);
            return Col.GetRawData();
        }
    }
}
