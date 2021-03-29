using System.Collections.Generic;

namespace OsuCollabTool.CoreClasses
{
    internal class MapDataExtractor
    {
        private string mapDir = string.Empty;
        public static int DataRows = 2;

        public MapDataExtractor(string mapDirIn)
        {
            mapDir = mapDirIn;
        }

        // Specialised output
        public string[,] GetGeneral()
        {
            var gen = new General(mapDir);

            return gen.ReadDataFormatted(gen.GetRawData());
        }

        public string[,] GetMetadata()
        {
            var met = new Metadata(mapDir);
            return met.ReadDataFormatted((met.GetRawData()));
        }

        public string[,] GetDiff()
        {
            var diff = new Difficulty(mapDir);
            return diff.ReadDataFormatted(diff.GetRawData());
        }

        // string output
        public List<string> GetGeneralString()
        {
            var gen = new General(mapDir);

            return gen.GetRawData();
        }

        public List<string> GetEditorString()
        {
            var edi = new Editor(mapDir);
            return edi.GetRawData();
        }

        public List<string> GetMetadataString()
        {
            var met = new Metadata(mapDir);
            return met.GetRawData();
        }

        public List<string> GetDiffString()
        {
            var diff = new Difficulty(mapDir);
            return diff.GetRawData();
        }

        public List<string> GetEventsString()
        {
            var eve = new Events(mapDir);
            return eve.GetRawData();
        }

        public List<string> GetTimingPString()
        {
            var tim = new TimingPoints(mapDir);
            return tim.GetRawData();
        }

        public List<string> GetHitObjString()
        {
            var hit = new HitObjects(mapDir);
            return hit.GetRawData();
        }

        public List<string> GetColourString()
        {
            var col = new Colours(mapDir);
            return col.GetRawData();
        }
    }
}